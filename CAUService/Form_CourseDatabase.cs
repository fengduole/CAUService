using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CAUService
{
    public partial class Form_CourseDatabase : Form
    {
        mfCourse.DataCourseAdmin database = new mfCourse.DataCourseAdmin("CourseLibrary.txt");

        public Form_CourseDatabase()
        {
            InitializeComponent();
        }


        //窗口加载
        private void Form_CourseDatabase_Load(object sender, EventArgs e)
        {
            if (!database.isLoadSuccess)
            {
                MessageBox.Show("未找到课程数据库，请通过“自动更新”检查并获取更新后再使用该功能。","数据库丢失",MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
            }

            database.Display(ref listView_CourseDatabase);

            label_TotalRecord.Text = "总课程数:" + database.n.ToString();
            label_Version.Text = "数据库版本:" + database.version;

            listView_CourseDatabase.ListViewItemSorter = new ListViewColumnSorter();
            listView_CourseDatabase.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
        }


        //查找
        private void button_Search_Click(object sender, EventArgs e)
        {
            label_SearchCount.Text = "共找到 " + database.Search(textBox_KeyWord.Text,false).ToString() + " 条记录";
            label_SearchCount.Visible = true;

            database.Display(ref listView_CourseDatabase);
        }


        //打开课程
        private void listView_CourseDatabase_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             
        }
    }
}