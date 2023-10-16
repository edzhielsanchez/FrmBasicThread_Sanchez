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

namespace FrmBasicThread_Sanchez
{
    public partial class BasicThread : Form
    {
        public BasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ThreadStart delStart = new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadA.Name = "Thread A Process";
            Thread ThreadB = new Thread(MyThreadClass.Thread1);
            ThreadB.Name = "Thread B Process";
            Console.WriteLine(lblBefore.Text.ToString());
            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();
            lblBefore.Text = "-End of Thread-";
            Console.WriteLine(lblBefore.Text.ToString());
        }
    }
}