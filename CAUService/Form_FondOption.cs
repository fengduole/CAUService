using System;
using System.Windows.Forms;
using System.IO;

namespace CAUService
{
    public partial class Form_FondOption : Form
    {
        mfUser.User nowUser = new mfUser.User();

        public Form_FondOption(ref mfUser.User NowUser)
        {
            InitializeComponent();

            nowUser = NowUser;
        }

        private void Form_FondOption_Load(object sender, EventArgs e)
        {
            ClassToControl();
        }


        //将设置映射到控件
        private void ClassToControl()
        {
            label_UserInfo.Text = "用户信息:" + nowUser.number + "(" + nowUser.name + ")";

            //主页设定
            if (nowUser.mainPage == 1)
                radioButton_MainPage_URP.Checked = true;
            else if (nowUser.mainPage == 2)
                radioButton_MainPage_Netgate.Checked = true;
            else if (nowUser.mainPage == 3)
                radioButton_MainPage_StdMgr.Checked = true;

            //自动更新
            radioButton_Update_On.Checked = nowUser.isUseUpdate;
            radioButton_Update_Off.Checked = !nowUser.isUseUpdate;
            textBox_UpdateAddress.Text = nowUser.address;
            textBox_UpdateAddress.Enabled = nowUser.isUseUpdate;


            //后台管理
            checkBox_Background_Minimize.Checked = nowUser.isUseMinimize;


            //自动计算
            if (nowUser.autoCalc == 1)
                radioButton_AutoCalc_This.Checked = true;
            else if (nowUser.autoCalc == 2)
                radioButton_AutoCalc_Each.Checked = true;
            else if (nowUser.autoCalc == 3)
                radioButton_AutoCalc_All.Checked = true;
            else
                radioButton_AutoCalc_Off.Checked = true;

            //获取时限
            numericUpDown_TimeLimit.Value = nowUser.timeLimit;

            //算法选择


            //流量设置
            numericUpDown_FlowLimit.Value = nowUser.flowLimit;

            //自动联网
            radioButton_AutoConnect_On.Checked = nowUser.isAutoConnect;
            radioButton_AutoConnect_Off.Checked = !nowUser.isAutoConnect;
        }


        //将控件映射到设置
        private void ControlToClass()
        {
            //主页设定
            if (radioButton_MainPage_URP.Checked)
                nowUser.mainPage = 1;
            else if (radioButton_MainPage_Netgate.Checked)
                nowUser.mainPage = 2;
            else if (radioButton_MainPage_StdMgr.Checked)
                nowUser.mainPage = 3;

            //自动更新
            if (radioButton_Update_On.Checked)
                nowUser.isUseUpdate = true;
            else
                nowUser.isUseUpdate = false;
            nowUser.address = textBox_UpdateAddress.Text;

            //后台管理
            nowUser.isUseMinimize = checkBox_Background_Minimize.Checked;


            //自动计算
            if (radioButton_AutoCalc_This.Checked)
                nowUser.autoCalc = 1;
            else if (radioButton_AutoCalc_Each.Checked)
                nowUser.autoCalc = 2;
            else if (radioButton_AutoCalc_All.Checked)
                nowUser.autoCalc = 3;
            else
                nowUser.autoCalc = 0;

            //获取时限
            nowUser.timeLimit = (int)numericUpDown_TimeLimit.Value;


            //流量设置
            nowUser.flowLimit = (int)numericUpDown_FlowLimit.Value;

            //自动联网
            nowUser.isAutoConnect = radioButton_AutoConnect_On.Checked;
        }


        //确定
        private void button_OK_Click(object sender, EventArgs e)
        {
            ControlToClass();

            nowUser.SaveToReg();

            this.Dispose();
        }


        //取消
        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        //算法选择
        private void button_Algorithm_Click(object sender, EventArgs e)
        {
            this.TopMost = false;

            Form_AlgSelect algSelect = new Form_AlgSelect(ref nowUser);
            algSelect.ShowDialog();

            this.TopMost = true;
        }


        //自动更新切换
        private void radioButton_Update_On_CheckedChanged(object sender, EventArgs e)
        {
            textBox_UpdateAddress.Enabled = radioButton_Update_On.Checked;
        }


        //清理当前用户缓存
        private void button_DelNow_Click(object sender, EventArgs e)
        {
            Directory.Delete(nowUser.programPath + "\\User\\" + nowUser.number,true);

            MessageBox.Show("用户 "+nowUser.number+"("+nowUser.name+") 缓存文件清理成功！","", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

       
        //清理所有用户缓存
        private void button_DelAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您将清理所有用户的缓存文件！\n\n单击“确认”：清理缓存\n单击“取消”：返回偏好设置","确认清理所有缓存文件",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Directory.Delete(nowUser.programPath + "\\User", true);

                MessageBox.Show("缓存文件清理成功！", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}