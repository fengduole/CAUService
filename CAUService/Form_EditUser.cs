using System;
using System.Text;
using System.Windows.Forms;

namespace CAUService
{
    public partial class Form_EditUser : Form
    {
        int mode;
        int editIndex = 0;
        mfUser.User editUser = new mfUser.User();
        mfUser.UserAdmin userAdmin;
        bool isSuccessful = false;//是否成功添加用户


        public Form_EditUser(ref mfUser.UserAdmin UserAdmin, int Mode, int EditIndex)
        {
            InitializeComponent();

            userAdmin = UserAdmin;
            editIndex = EditIndex;
            mode = Mode;
        }


        //窗口架子啊
        private void Form_EditUser_Load(object sender, EventArgs e)
        {
            if (mode == 1)//新增
            {
                this.Text = "新增用户";
            }
            else if (mode == 2)//编辑
            {
                editUser = userAdmin.user[editIndex];

                this.Text = "编辑用户 —— " + editUser.number;

                textBox_Number.ReadOnly = true;
                
                textBox_Number.Text = editUser.number;
                textBox_Name.Text = editUser.name;
                textBox_Pass_URP.Text = editUser.pass_URP;
                textBox_Pass_NetGate.Text = editUser.pass_Netgate;
                textBox_Pass_StdMgr.Text = editUser.pass_StdMgr;

                checkBox_SetToDefault.Visible = false;            
            }
            else if (mode == 3)//初次运行
            {
                this.Text = "您需要设置一个默认用户";

                checkBox_SetToDefault.Visible = false;
            }
        }


        //保存
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (userAdmin.IsUserExist(textBox_Number.Text))
            {
                if (mode == 1)
                {
                    MessageBox.Show("创建用户失败！\n原因：帐户已存在。", "帐户已存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (mode == 2)
                {
                    editUser.pass_URP = textBox_Pass_URP.Text;
                    editUser.pass_Netgate = textBox_Pass_NetGate.Text;
                    editUser.pass_StdMgr = textBox_Pass_StdMgr.Text;
                    editUser.name = textBox_Name.Text;

                    userAdmin.user[editIndex] = editUser;

                    userAdmin.Save();
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Dispose();
                }
            }
            else
            {
                mfUser.User newUser = new mfUser.User(textBox_Number.Text, textBox_Name.Text, textBox_Pass_URP.Text, textBox_Pass_NetGate.Text, textBox_Pass_StdMgr.Text,DateTime.Now.ToString());
                
                userAdmin.Add(newUser);

                if (checkBox_SetToDefault.Checked)
                    userAdmin.SetNowUser(newUser.number);

                userAdmin.Save();
                isSuccessful = true;

                if (mode == 1)
                {
                    System.Diagnostics.Process.Start("CAUService.exe");

                    Application.Exit();
                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
            }
        }


        //
        private void Form_EditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mode == 3 && !isSuccessful)
            {
                Application.Exit();
                MessageBox.Show("首次用户设置被取消");
            }
        }


        //首次使用提示
        private void Form_EditUser_Shown(object sender, EventArgs e)
        {
            if (mode == 3)
                MessageBox.Show("感谢您使用本软件。\n\n首次使用，您需要为本程序配置一个默认用户。\n\n本程序能方便快捷地为您提供农大所需的服务，也感谢您对Macrofuns soft的支持。", "Welcome");
        }


        //学号代替用户名
        private void textBox_Name_Leave(object sender, EventArgs e)
        {
            if (textBox_Number.Text != "" && textBox_Name.Text == "")
                textBox_Name.Text = textBox_Number.Text;
        }
    }
}