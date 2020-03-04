using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCAutomation;//OPC自动化接口
namespace OPCtest4
{//只能修改本地新增的group和item
    public partial class Form1 : Form
    {
        OPCServer KepServer;//OPCServer对象现在可以用来获取关于opc服务端的一般信息，并创建和操作OPCGroup对象的集合
        OPCGroups KepGroups;//OPCGroups是OPCGroup对象的集合。以及创建，删除，和管理它们的方法
        //OPCGroup为客户组织数据提供了一种方式。基于异常的连接也可以在客户端和组中的项之间创建，可以根据需要启用和禁用
        OPCGroup KepGroup;
        OPCItems KepItems;//可以更改默认值，以添加具有不同初始状态的OPCItems
        OPCItem KepItem;//opc项表示服务器与数据源的连接。与每个项目相关联的是一个值，质量和时间戳。值以变量的形式出现
        bool opc_connected = false;//连接状态
        int itmHandleClient = 0;//客户端的句柄，句柄即控件名称，如“张三”，用来识别是哪个具体的对象,此处可理解为每个节点的编号
        int itmHandleServer = 0;//服务器的句柄
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetLocalServer();
        }

        /// <summary>
        /// 获取本地的OPC服务器名称
        /// </summary>
        public void GetLocalServer()
        {
            IPHostEntry host = Dns.GetHostEntry("127.0.0.1");//将主机名或IP地址解析为IPHostEntry实例
            var strHostName = host.HostName;
            try
            {
                KepServer = new OPCServer();
                object serverList = KepServer.GetOPCServers(strHostName);

                foreach (string turn in (Array)serverList)
                {//遍历opc服务器列表 ，添加入下拉选框中（枚举本地OPC服务器）
                    cmbServerName.Items.Add(turn);
                }

                cmbServerName.SelectedIndex = 0;
                btnConnServer.Enabled = true;//连接按钮设置  可以点击   状态
            }
            catch (Exception err)
            {
                MessageBox.Show("枚举本地OPC服务器出错：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// "连接"按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnConnServer_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ConnectRemoteServer(txtRemoteServerIP.Text, cmbServerName.Text))
                {//如果连接服务器失败，直接返回，不进行任何操作
                    return;
                }

                btnSetGroupPro.Enabled = true;//“设置” 按钮调整为可以点击

                opc_connected = true;//连接状态设置为true

                GetServerInfo();//获取服务器信息并显示在窗体栏上

                RecurBrowse(KepServer.CreateBrowser());//展开数枝和叶子

                if (!CreateGroup())
                {
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("初始化出错：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        /// <summary>
        /// 连接服务器
        /// </summary>
        /// <param name="remoteServerIP">服务器IP</param>
        /// <param name="remoteServerName">服务器名称</param>
        /// <returns></returns>
        public bool ConnectRemoteServer(string remoteServerIP, string remoteServerName)
        {
            try
            {
                KepServer.Connect(remoteServerName, remoteServerIP);//尝试连接OPC服务器

                if (KepServer.ServerState == (int)OPCServerState.OPCRunning)
                {//如果服务器状态是在运行，则显示已连接到+服务器名称
                    tsslServerState.Text = "已连接到-" + KepServer.ServerName + "   ";
                }
                else
                {
                    //这里你可以根据返回的状态来自定义显示信息，请查看自动化接口API文档
                    tsslServerState.Text = "状态：" + KepServer.ServerState.ToString() + "   ";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("连接远程服务器出现错误：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 获取服务器信息，并显示在窗体状态栏上
        /// </summary>
        public void GetServerInfo()
        {
            tsslServerStartTime.Text = "开始时间:" + KepServer.StartTime.ToString() + "    ";
            tsslversion.Text = "版本:" + KepServer.MajorVersion.ToString() + "." + KepServer.MinorVersion.ToString() + "." + KepServer.BuildNumber.ToString();
        }

        /// <summary>
        /// 展开树枝和叶子
        /// </summary>
        /// <param name="oPCBrowser">opc浏览器</param>
        public void RecurBrowse(OPCBrowser oPCBrowser)
        {
            //展开分支
            oPCBrowser.ShowBranches();
            //展开叶子
            oPCBrowser.ShowLeafs(true);
            foreach (object turn in oPCBrowser)
            {//添加到listbox控件中
                listBox1.Items.Add(turn.ToString());
            }
        }


        /// <summary>
        /// 创建组，将本地组和服务器上的组对应
        /// </summary>
        /// <returns></returns>
        public bool CreateGroup()
        {
            try
            {
                KepGroups = KepServer.OPCGroups;//将服务端的组集合复制到本地
                KepGroup = KepGroups.Add("S");//添加一个组
                SetGroupProperty();//设置组属性
                
                KepItems = KepGroup.OPCItems;//将组里的节点集合复制到本地节点集合

                KepGroup.DataChange += KepGroup_DataChange;
                KepGroup.AsyncWriteComplete += KepGroup_AsyncWriteComplete;
            }
            catch (Exception err)
            {
                MessageBox.Show("创建组出现错误：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

      
        /// <summary>
        /// 设置组的属性，从对应的控件里获取,可以手动修改
        /// </summary>
        public void SetGroupProperty()
        {
            KepServer.OPCGroups.DefaultGroupIsActive = Convert.ToBoolean(txtGroupIsActive.Text);//激活组
            KepServer.OPCGroups.DefaultGroupDeadband = Convert.ToInt32(txtGroupDeadband.Text);// 死区值，设为0时，服务器端该组内任何数据变化都通知组
            KepGroup.UpdateRate = Convert.ToInt32(txtUpdateRate.Text);//服务器向客户程序提交数据变化的刷新速率
            KepGroup.IsActive = Convert.ToBoolean(txtIsActive.Text);//组的激活状态标志
            KepGroup.IsSubscribed = Convert.ToBoolean(txtIsSubscribed.Text);//是否订阅数据
        }


        /// <summary>
        /// 异步写方法
        /// </summary>
        /// <param name="TransactionID">处理ID</param>
        /// <param name="NumItems">项个数</param>
        /// <param name="ClientHandles">OPC客户端的句柄</param>
        /// <param name="Errors">错误个数</param>
        private void KepGroup_AsyncWriteComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array Errors)
        {
            lblState.Text = "";
            for (int i = 1; i <= NumItems; i++)
            {
                lblState.Text += "Tran:" + TransactionID.ToString() + "   CH:" + ClientHandles.GetValue(i).ToString() + "   Error:" + Errors.GetValue(i).ToString();
            }

        }


        /// <summary>
        /// 数据订阅方法
        /// </summary>
        /// <param name="TransactionID">处理ID</param>
        /// <param name="NumItems">项个数</param>
        /// <param name="ClientHandles">OPC客户端的句柄</param>
        /// <param name="ItemValues">节点的值</param>
        /// <param name="Qualities">节点的质量</param>
        /// <param name="TimeStamps">时间戳</param>
        private void KepGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {//编写的订阅事件，当服务端数据有变化时，会把添加的节点的对应值返回来，并显示在对应的文本框上
            for (int i = 1; i <= NumItems; i++)//下标一定要从1开始，NumItems参数是每次事件触发时Group中实际发生数据变化的Item的数量，而不是整个Group里的Items
            {
                this.txtTagValue.Text = ItemValues.GetValue(i).ToString();
                this.txtQualities.Text = Qualities.GetValue(i).ToString();
                this.txtTimeStamps.Text = TimeStamps.GetValue(i).ToString();
            }
        }


        /// <summary>
        /// 选择列表时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//添加一个节点（也就是通过选择列表里的节点达成添加操作）
            try
            {
                if (itmHandleClient != 0)
                {
                    this.txtTagValue.Text = "";
                    this.txtQualities.Text = "";
                    this.txtTimeStamps.Text = "";

                    Array Errors;
                    OPCItem bItem = KepItems.GetOPCItem(itmHandleServer);
                    //注：OPC中以1为数组的基数
                    int[] temp = new int[2] { 0, bItem.ServerHandle };
                    Array serverHandle = (Array)temp;
                    //移除上一次选择的项
                    KepItems.Remove(KepItems.Count, ref serverHandle, out Errors);


                    itmHandleClient = 1;//节点编号为1
                    KepItem = KepItems.AddItem(listBox1.SelectedItem.ToString(), itmHandleClient);//第一个参数为ItemID,第二个参数为节点编号，节点编号可自定义
                    itmHandleServer = KepItem.ServerHandle;//获取该节点的服务器句柄
                }
                else
                {
                    itmHandleClient = 1;//节点编号为1
                    KepItem = KepItems.AddItem(listBox1.SelectedItem.ToString(), itmHandleClient);//第一个参数为ItemID,第二个参数为节点编号，节点编号可自定义
                    itmHandleServer = KepItem.ServerHandle;//获取该节点的服务器句柄

                }
               
            }
            catch (Exception err)
            {
                //没有任何权限的项，都是OPC服务器保留的系统项，此处可不做处理。
                itmHandleClient = 0;
                txtTagValue.Text = "Error ox";
                txtQualities.Text = "Error ox";
                txtTimeStamps.Text = "Error ox";
                MessageBox.Show("此项为系统保留项:" + err.Message, "提示信息");
            }
        }


        /// <summary>
        /// 设置组属性的按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSetGroupPro_Click(object sender, EventArgs e)
        {
            SetGroupProperty();
        }


        /// <summary>
        /// “写入”按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWrite_Click(object sender, EventArgs e)
        {
            OPCItem bItem = KepItems.GetOPCItem(itmHandleServer);
            int[] temp = new int[2] { 0, bItem.ServerHandle };
            Array serverHandles = (Array)temp;
            object[] valueTemp = new object[2] { "", txtWriteTagValue.Text };
            Array values = (Array)valueTemp;
            Array Errors;
            int cancelID;
            KepGroup.AsyncWrite(1, ref serverHandles, ref values, out Errors, 2009, out cancelID);
            //KepItem.Write(txtWriteTagValue.Text);//这句也可以写入，但并不触发写入事件
            GC.Collect();
        }


        /// <summary>
        /// 关闭窗口事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!opc_connected)
            {
                return;
            }

            if (KepGroup != null)
            {
                KepGroup.DataChange -= new DIOPCGroupEvent_DataChangeEventHandler(KepGroup_DataChange);
            }

            if (KepServer != null)
            {
                KepServer.Disconnect();
                KepServer = null;
            }

            opc_connected = false;
        }
    }
}
