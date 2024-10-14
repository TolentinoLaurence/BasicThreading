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

namespace BasicThreding
{
    public partial class frmBasicThred : Form
    {
        public frmBasicThred()
        {
            InitializeComponent();
        }

        public void Threads()
        {
            Console.WriteLine("-Before starting thread-");


            Thread threadA = new Thread(new ThreadStart(MyThreadClass.Thread1));
            threadA.Priority = System.Threading.ThreadPriority.Highest;
            threadA.Name = "Thread A Process";


            Thread threadB = new Thread(new ThreadStart(MyThreadClass.Thread2));
            threadB.Priority = System.Threading.ThreadPriority.Normal;
            threadB.Name = "Thread B Process";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            lblThreadStart.Text = "-End of Thread-";
            Console.WriteLine("-End of Thread-");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
                Threads();
        }
    }
}
