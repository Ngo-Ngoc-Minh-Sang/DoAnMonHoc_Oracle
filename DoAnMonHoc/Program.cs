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
            ///Application.Run(new GUI.frmHuongDanKetNoiDB());
<<<<<<< HEAD
            Application.Run(new GUI.menu());
=======
            Application.Run(new GUI.FormDonHang());
>>>>>>> 5be84415aa808ad8c406a0ea23c50f7ba7d68fee
        }
    }
}
