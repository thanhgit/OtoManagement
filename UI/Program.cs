using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.ApplicationServices;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;

namespace UI
{
    static class Program
    {
        // Form chính cần gọi của chương trình phải đặt là static
        static FormDangNhap frm;

        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frm = new FormDangNhap();

            SingleInstanceApplication.Run(frm, NewInstanceHandler);

        }

        public static void NewInstanceHandler(object sender,
            StartupNextInstanceEventArgs e)
        {
            // Kích hoạt cửa sổ của instance đang chạy
            // Bạn có thể thay thế bằng 1 hành động khác
            frm.Activate();

        }
        /// <summary>
        /// Lớp này dùng để gọi chạy form dạng single instance
        /// </summary>
        public class SingleInstanceApplication : WindowsFormsApplicationBase
        {
            private SingleInstanceApplication()
            {
                base.IsSingleInstance = true;
            }

            public static void Run(Form f,
                StartupNextInstanceEventHandler startupHandler)
            {
                SingleInstanceApplication app = new SingleInstanceApplication();
                app.MainForm = f;
                app.StartupNextInstance += startupHandler;
                app.Run(Environment.GetCommandLineArgs());
            }
        }
    }
}
