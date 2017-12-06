using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoBot
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Thread thrd1 = new Thread(new ThreadStart(Trmain));
            this.WindowState = FormWindowState.Minimized;
            thrd1.Start();
        }

        private static void Trmain()
        {
            for (;;)
            {
                //Do stuff like check the price

                //Wait one minute
                Thread.Sleep(60000);
            }
        }
    }
}
