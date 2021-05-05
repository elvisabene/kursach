using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport_Task.TaskAbstractions;

namespace Transport_Task
{
    public partial class OutputForm : Form
    {
        InputForm parent;
        public OutputForm(InputForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        public void ShowResult(List<string> result)
        {
            this.Show();
            foreach (string str in result)
            {
                outputLabel.Text += "\n" + str;
            }
        }

        private void OutputForm_Load(object sender, EventArgs e)
        {
            Solver solver = new Solver(parent);
            ShowResult(solver.FinalResult());
        }
    }
}
