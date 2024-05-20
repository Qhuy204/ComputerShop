using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐA1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI_MainForm());
        }

    }

    public static class FormHelper
    {
        public static void HienThiFormCon(Form frm, Panel panel)
        {
            // Xóa các form con hiện có khỏi panel
            panel.Controls.Clear();

            // Cài đặt thuộc tính cho form con
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            //frm.Size = frm.PreferredSize;
            // Thêm form con vào panel
            panel.Controls.Add(frm);

            // Hiển thị form con
            frm.Show();
        }
    }
}
