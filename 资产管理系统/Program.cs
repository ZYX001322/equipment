using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;
using 资产管理系统.UI;

namespace 资产管理系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmBase());
            frmStart start=new frmStart();
            if (start.ShowDialog() == DialogResult.OK)
            {
                frmLogin login=new frmLogin();
                if (login.ShowDialog()==DialogResult.OK)
                {
                    frmMain main=new frmMain();
                    //传递frmLogin窗体的loginUser对象给frmMain窗体的User对象
                    main.User = login.loginUser;
                    Application.Run(main);
                }
            }

        }
    }
}
