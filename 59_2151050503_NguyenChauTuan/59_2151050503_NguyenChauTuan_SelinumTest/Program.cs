using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _59_2151050503_NguyenChauTuan_SelinumTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _59_NguyenChauTuan_Selinum_DangKy a = new _59_NguyenChauTuan_Selinum_DangKy();
             a.selinum_DangKy_TC1_59_NCT();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
