using COMP123_S2019_FinalTestA.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_FinalTestA
{
    public static class Program
    {
        public static HeroGenerator heroGenerator;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            heroGenerator = new HeroGenerator();

            Application.Run(heroGenerator);
        }
    }

	//public static class character
	{
	}

}
