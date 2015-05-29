using System;
using Microsoft.Win32;

namespace mfRegEdit
{
    public class mfRegEdit
    {
        //读取用户列表
        public string LoadUserList()
        {
            RegistryKey Options = Registry.CurrentUser;
            string s;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey("User");

            s = Options.GetValue("users", false).ToString();

            return s;
        }


        //保存用户列表
        public void SaveUserList(string value)
        {
            RegistryKey Options = Registry.CurrentUser;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey("User");

            Options.SetValue("users", value);
        }


        //读取当前用户
        public string LoadNowUser()
        {
            RegistryKey Options = Registry.CurrentUser;
            string s;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey("User");

            s = Options.GetValue("nowUser", false).ToString();

            return s;
        }


        //保存当前用户
        public void SaveNowUser(string value)
        {
            RegistryKey Options = Registry.CurrentUser;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey("User");

            Options.SetValue("nowUser", value);
        }


        //读取用户设置
        public string LoadUserOption(string number, string name)
        {
            RegistryKey Options = Registry.CurrentUser;
            string s;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey("User");
            Options = Options.CreateSubKey(number);

            s = Options.GetValue(name, false).ToString();

            return s;
        }


        //保存用户设置
        public void SaveUserOption(string number, string name,string value)
        {
            RegistryKey Options = Registry.CurrentUser;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey("User");
            Options = Options.CreateSubKey(number);

            Options.SetValue(name, value);
        }


        //保存用户设置
        public void SaveUserOption(string number, string name, int value)
        {
            RegistryKey Options = Registry.CurrentUser;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey("User");
            Options = Options.CreateSubKey(number);

            Options.SetValue(name, value);
        }


        //保存用户设置
        public void SaveUserOption(string number, string name, bool value)
        {
            RegistryKey Options = Registry.CurrentUser;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey("User");
            Options = Options.CreateSubKey(number);

            Options.SetValue(name, value);
        }

        //删除用户
        public void Delete(string number)
        {
            RegistryKey Options = Registry.CurrentUser;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey("User");

            Options.DeleteSubKeyTree(number);
        }





        //读取注册表
        public string Load(string name, string path)
        {
            RegistryKey Options = Registry.CurrentUser;
            string s;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey(path);

            s = Options.GetValue(name, false).ToString();

            return s;
        }


        //写入注册表
        public void Save(string name, string value, string path)
        {
            RegistryKey Options = Registry.CurrentUser;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey(path);

            Options.SetValue(name, value);
        }


        //写入注册表
        public void Save(string name, int value, string path)
        {
            RegistryKey Options = Registry.CurrentUser;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey(path);

            Options.SetValue(name, value);
        }


        //写入注册表
        public void Save(string name, bool value, string path)
        {
            RegistryKey Options = Registry.CurrentUser;
            int values = value ? 1 : 0;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");
            Options = Options.CreateSubKey("CAUService");
            Options = Options.CreateSubKey(path);

            Options.SetValue(name, values);
        }


        //删除注册表
        public void Delete()
        {
            RegistryKey Options = Registry.CurrentUser;

            Options = Options.OpenSubKey("software", true);
            Options = Options.CreateSubKey("Macrofuns");

            Options.DeleteSubKeyTree("CAUService");
        }


        //判断是否是Macrofuns的电脑     
        public bool IsMyComputer()
        {
            RegistryKey RegistryIsMyComputer = Registry.CurrentUser;
            string s;

            RegistryIsMyComputer = RegistryIsMyComputer.OpenSubKey("software", true);
            RegistryIsMyComputer = RegistryIsMyComputer.CreateSubKey("Macrofuns");
            s = RegistryIsMyComputer.GetValue("MyComputerID", false).ToString();

            if (s == "feng1990")
                return true;
            else
                return false;
        }
    }
}
