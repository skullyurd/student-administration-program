///
///     Class:          Program.cs
///     decription:     In this file the program starts and runs. So the file where the form is set up starts here.
/// 
///     Name:           Baris Buba
///     StudentNumber:  4953347
///     date:           19-02-2023
///     
///     Version:        Version 1.0 - Final verstion
///                     All requested features are added and tested.
///                     
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp_Starter_Assignment
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
            Application.Run(new StudentAdministrationForm());



            
        }
    }
}
