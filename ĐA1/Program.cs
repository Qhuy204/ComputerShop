using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
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
    public static class SendEmail
    {
        public static Random rd = new Random();
        public static bool issended = false;

        public static bool SendMail_password(string email, string password)
        {
            // Set sender address
            var fromAddress = new MailAddress("musicapplication2@gmail.com"); //Sender

            // Add recipient correctly
            var toAddress = new MailAddress(email); //Receiver 
            const string pass = "vkagacwumrfctuwd";
            // Set subject and body
            const string subject = "THÔNG BÁO THAY ĐỔI MẬT KHẨU - CỬA HÀNG MÁY TÍNH";
            string body = "\n" + "Mật khẩu mới của bạn là: " + password;


            // Send email
            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, pass),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                issended = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return issended;
        }

        public static bool SendMail(string email, string username, string password)
        {
            int code = rd.Next(100000, 999999);
            // Set sender address
            var fromAddress = new MailAddress("musicapplication2@gmail.com"); //Sender

            // Add recipient correctly
            var toAddress = new MailAddress(email); //Receiver 
            const string pass = "vkagacwumrfctuwd";
            // Set subject and body
            const string subject = "THÔNG BÁO - CỬA HÀNG MÁY TÍNH";
            string body = "\n" + "Tài khoản nhân viên của bạn đã được tạo thành công.\nVui lòng đăng nhập và tiến hành đổi mật khẩu để bảo mật thông tin!\nTên đăng nhập: " + username + "\nMật khẩu: " + password;


            // Send email
            try
            {
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, pass),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                issended = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return issended;
        }
    }


}
