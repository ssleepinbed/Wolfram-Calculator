using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolfram_Calculator
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Add this to your code if you keep getting errors regarding ml32i4.dll. Be sure to add both:
            //The dll file to your project resources (preferences -> resources)
            //The name of the file as a string in the same way.
            if (!File.Exists(Properties.Resources.ml32i4_dll))
            {
                var outStream = new StreamWriter(Properties.Resources.ml32i4 + ".DLL", false);
                var binStream = new BinaryWriter(outStream.BaseStream);
                binStream.Write(Properties.Resources.ml32i4  + ".DLL");
                binStream.Close();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
