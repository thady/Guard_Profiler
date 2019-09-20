using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guard_profiler
{
    public partial class frmWaitForm : Form
    {
        public Action Worker { get; set; }
        public frmWaitForm(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentException();
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //Start new thread to run wait form dialog
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
