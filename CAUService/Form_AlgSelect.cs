using System;
using System.Text;
using System.Windows.Forms;

namespace CAUService
{
    public partial class Form_AlgSelect : Form
    {
        mfUser.User nowUser = new mfUser.User();

        public Form_AlgSelect(ref mfUser.User NowUser)
        {
            InitializeComponent();

            nowUser = NowUser;
        }


        private void Form_AlgSelect_Load(object sender, EventArgs e)
        {
            DisplayListView();
        }


        private void DisplayListView()
        {
            listView_Algs.Items.Clear();

            for (int i = 1; i <= nowUser.algAdmin.n; i++)
            {
                ListViewItem item = new ListViewItem(nowUser.algAdmin.alg[i].name);
                item.Checked = nowUser.algAdmin.alg[i].isUse;

                listView_Algs.Items.Add(item);
            }
        }


        private void button_Ok_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 1; i <= nowUser.algAdmin.n; i++)
            {
                nowUser.algAdmin.alg[i].isUse = listView_Algs.Items[i - 1].Checked;

                if (nowUser.algAdmin.alg[i].isUse)
                    s += "[" + nowUser.algAdmin.alg[i].fileName + "]";
            }

            nowUser.alg = s;
            nowUser.SaveToReg();

            this.Close();
        }

        private void listView_Algs_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView_Algs.Items)
            {
                if (item.Selected)
                    nowUser.algAdmin.alg[item.Index + 1].DisplayImage(pictureBox_AlgImage.CreateGraphics());
            }
        }
    }
}