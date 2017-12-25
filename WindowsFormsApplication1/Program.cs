using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            {

                {
                    // arranger
                    int a = 1;
                    int b = 2;
                    // agir
                    /*  Class1 c1 = new Class1 (); */
                    int resultat = Class1.Addition(a, b);
                    // auditer
                    if (resultat != 3)
                        Console.WriteLine("Le test a raté");
                }
                           }
              /*  Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1()); */
            }
        }
    } 
