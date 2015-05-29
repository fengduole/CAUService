using System;
using System.Text;
using System.Windows.Forms;

namespace CAUService
{
    public partial class Form_UserManage : Form
    {
        mfUser.UserAdmin userAdmin = new mfUser.UserAdmin(true);
        mfUser.User nowUserOld = new mfUser.User(true);
        mfUser.User nowUserNew = new mfUser.User(true);


        public Form_UserManage()
        {
            InitializeComponent();
        }

        private void Form_UserManage_Load(object sender, EventArgs e)
        {
            DisplayListView();

            label_NowUser.Text = userAdmin.nowUser.number + "(" + userAdmin.nowUser.name + ")";

            label_CreatTime.Text = "用户创建时间: " + userAdmin.nowUser.createTime;
            label_LastTime.Text = "上次使用时间: " + userAdmin.nowUser.lastTime;
     
        }


        //用户列表显示
        private void DisplayListView()
        {
            listView_UserList.Items.Clear();

            for (int i = 1; i <= userAdmin.n; i++)
            {
                ListViewItem Item = new ListViewItem(userAdmin.user[i].number);
                Item.SubItems.Add(userAdmin.user[i].name);

                listView_UserList.Items.Add(Item);
            }
        }


        //新增用户
        private void button_New_Click(object sender, EventArgs e)
        {
            Form_EditUser editUser = new Form_EditUser(ref userAdmin, 1, 0);
            editUser.ShowDialog();
        }


        //编辑用户
        private void button_Edit_Click(object sender, EventArgs e)
        {
            int selectIndex = listView_UserList.SelectedItems[0].Index + 1;

            Form_EditUser editUser = new Form_EditUser(ref userAdmin, 2, selectIndex);
            editUser.ShowDialog();
        }


        //删除用户
        private void button_Delete_Click(object sender, EventArgs e)
        {
            int selectIndex = listView_UserList.SelectedItems[0].Index + 1;
            mfUser.User deleteUser = userAdmin.user[selectIndex];

            if (MessageBox.Show("用户 " + deleteUser.number + "(" + deleteUser.name + ") 即将被删除。\n\n确认删除？", "删除用户", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (deleteUser.number == nowUserOld.number)
                {
                    if (listView_UserList.Items.Count >= 2)
                    {
                        userAdmin.Delete(selectIndex);

                        DisplayListView();

                        listView_UserList.Items[0].Selected = true;

                        button_SetNowUser.PerformClick();
                    }
                    else
                    {
                        label_NowUser.Text = "";

                        userAdmin.Delete(selectIndex);

                        DisplayListView();
                    }
                }
                else
                {
                    userAdmin.Delete(selectIndex);

                    DisplayListView();
                }

                if (listView_UserList.SelectedItems.Count == 0)
                    button_Edit.Enabled = button_Delete.Enabled = button_SetNowUser.Enabled = false;
                else
                    button_Edit.Enabled = button_Delete.Enabled = button_SetNowUser.Enabled = true;
       
            }
        }


        //设置默认用户
        private void button_SetDefault_Click(object sender, EventArgs e)
        {
            int selectIndex = listView_UserList.SelectedItems[0].Index + 1;
            nowUserNew = userAdmin.user[selectIndex];

            userAdmin.SetNowUser(nowUserNew.number);

            label_NowUser.Text = userAdmin.nowUser.number + "(" + userAdmin.nowUser.name + ")";

            if (nowUserNew.number != nowUserOld.number)
            {
                System.Diagnostics.Process.Start("CAUService.exe");

                Application.Exit();
            }
        }


        //确保选中
        private void listView_UserList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_UserList.SelectedItems.Count == 0)
                button_Edit.Enabled = button_Delete.Enabled = button_SetNowUser.Enabled = false;
            else
                button_Edit.Enabled = button_Delete.Enabled = button_SetNowUser.Enabled = true;


            int selectIndex=-1 ;
            try
            {
                selectIndex = listView_UserList.SelectedItems[0].Index + 1;

                label_CreatTime.Text ="用户创建时间: "+ userAdmin.user[selectIndex].createTime;
                label_LastTime.Text = "上次使用时间: " + userAdmin.user[selectIndex].lastTime;
            }
            catch
            {
            }
        }



        private void Form_UserManage_FormClosed(object sender, FormClosedEventArgs e)
        {
       /*     if (nowUserNew.number != nowUserOld.number)
            {
                System.Diagnostics.Process.Start("CAUService.exe");

                Application.Exit();
            }*/
        }
    }
}