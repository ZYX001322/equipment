using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 资产管理系统.UI
{
    public class UnitCommon
    {
       /// <summary>
       /// 封装提示对话框
       /// </summary>
       /// <param name="msg"></param>
       public static void InfoMsg(string msg)
       {   
           
           MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
       }

       /// <summary>
       /// 封装警告对话框
       /// </summary>
       /// <param name="msg"></param>
       public static void WarnMsg(string msg)
       {
           MessageBox.Show(msg,"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
       }

        /// <summary>
        /// 弹出错误对话框
        /// </summary>
        /// <param name="msg"></param>
       public static void ErrorMsg(string msg)
       {
           MessageBox.Show(msg,"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
    
       /// <summary>
       /// 封装询问对话框
       /// </summary>
       /// <param name="msg"></param>
       /// <returns></returns>
       public static bool ConfirmMsg(string msg)
       {
           return MessageBox.Show(msg, "资产管理系统", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes;
       }
    }
}
