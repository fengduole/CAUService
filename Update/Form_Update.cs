using System;
using System.Windows.Forms;

namespace Update
{
    public partial class Form_Update : Form
    {
        //-hide = 隐藏窗口
        //-user 0908140824 = 用户
        string[] args;
        bool isHide=false;
        string user = "", email = "";
        
        bool createdNew;//是否可实例化程序，保证进程中只有一个实例
           
        string nowVersion, version = "", level = "", note = "", address = "";


        public Form_Update(string[] Args)
        {
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, "Update.exe", out createdNew);
           
            InitializeComponent();

            args = Args;
        }

        private void Form_Update_Load(object sender, EventArgs e)
        {
            if (!createdNew)
                this.Dispose();

            this.Height = 125;

            //参数解析
            CmdHandle();

            //读取版本信息
            mfRegEdit.mfRegEdit regEdit = new mfRegEdit.mfRegEdit();
            nowVersion = regEdit.Load("ProgramVersion", "");
            label_NowVersion.Text = "当前版本:" + nowVersion;

            //读取用户设置
            email = regEdit.LoadUserOption(user, "Address");
            if (email == "False"||email=="")
                button_Email.Enabled = false;

            //获取更新信息
            WebBrowser wb_update = new WebBrowser();
            wb_update.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_update_DocumentCompleted);
            wb_update.Navigate("http://hi.baidu.com/macrofuns/item/cc052413b271520dd1d66d43");

            //更新获取时限
            Timer updateLimit = new Timer();
            updateLimit.Interval = 60000;
            updateLimit.Tick += new EventHandler(updateLimit_Tick);
            updateLimit.Start();
        }


        void wb_update_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = sender as WebBrowser;

            if (browser.ReadyState != WebBrowserReadyState.Complete)
                return;

            AnalyzeUpdate(browser.Document.Body.InnerText);
        }


        //解析升级数据
        private void AnalyzeUpdate(string text)
        {
            mfText.TextFunction textFunc = new mfText.TextFunction();
            
            progressBar_Process.Visible = false;

            if (text.IndexOf("配置设置【自动更新】") < 0)
            {
                UpdateFail();
                return;
            }
            else
            {
                textFunc.AnalyzeUpdateInfo(text, ref version, ref level, ref note, ref address);
            }
            

            if (String.Compare(nowVersion, version) < 0)//存在新版本
            {
                this.Height = 425;
                label_State.Text = "检测到可用更新";

                label_NewVersion.Text = "最新版本:"+version;
                label_Level.Text = "推 荐 度:"+level;
                label_Note.Text = "更新内容:\n    " + note;
             
                panel_Update.Visible = true;

                if (isHide)
                {
                    ShowInTaskbar = true;
                    WindowState = FormWindowState.Normal;
                    this.Show();
                }

            }
            else//不存在新版本
            {
                this.Height = 110;

                label_State.Text = "您已是最新版！";

                Timer close = new Timer();
                close.Interval = 2000;
                close.Tick += new EventHandler(close_Tick);
                close.Start();
            }
        }


        //延迟关闭
        void close_Tick(object sender, EventArgs e)
        {
            Timer close =sender as Timer;

            close.Stop();

            this.Dispose();
        }


        //更新获取时限
        void updateLimit_Tick(object sender, EventArgs e)
        {
            Timer updateLimit=sender as Timer;
            updateLimit.Stop();

            UpdateFail();
        }


        //获取更新失败
        private void UpdateFail()
        {
            label_State.Text = "获取更新失败。";

            Timer close = new Timer();
            close.Interval = 2000;
            close.Tick += new EventHandler(close_Tick);
            close.Start();
        }


        private void CmdHandle()
        {
            for (int i = 0; i < args.Length; i++)
                args[i] = args[i].ToLower();

            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-hide")
                {
                    isHide = true;
                    WindowState = FormWindowState.Minimized;
                    ShowInTaskbar = false;
                    Hide();
                }

                if (args[i] == "-user")
                {
                    user = args[i + 1];
                }
            }
        }


        //邮件推送
        private void button_Update_Click(object sender, EventArgs e)
        {
            MessageBox.Show(email);
        }


        //下载更新
        private void button_Download_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(address);
        }
    }
}