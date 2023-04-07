using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnMonHoc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            ///Application.Run(new GUI.frmHuongDanKetNoiDB());
            Application.Run(new GUI.frmKhachHang());
=======
            Application.Run(new GUI.DichVu());
>>>>>>> 331a1f95af5f5db40d9347e84d1b66443fb65ae4
        }
    }
}
