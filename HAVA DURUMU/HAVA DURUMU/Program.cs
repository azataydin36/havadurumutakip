using HavaDurumuApp;
using System;
using System.Windows.Forms;

namespace HAVA_DURUMU
{
    internal static class Program
    {

        [STAThread] 
        static void Main()
        {
            
            Application.EnableVisualStyles();

            
            Application.SetCompatibleTextRenderingDefault(false);

            
            Application.Run(new Form1());  
        }
    }
}
