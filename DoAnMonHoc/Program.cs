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
            //Application.Run(new GUI.frmHuongDanKetNoiDB());

<<<<<<< HEAD
            //Application.Run(new GUI.FormDonHang());
            Application.Run(new GUI.frmDangNhap());
=======
            Application.Run(new GUI.frmDangNhap());
            //Application.Run(new GUI.TestProcedure());
>>>>>>> c006b95ee3da12aabbf6a473ff100466305e805e
        }
    }
}
