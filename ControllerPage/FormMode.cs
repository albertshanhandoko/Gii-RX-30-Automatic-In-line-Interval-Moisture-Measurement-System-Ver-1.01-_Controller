using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerPage
{
    public partial class FormMode : Form
    {
        public FormMode()
        {
            InitializeComponent();
        }
        public string ModeSelection { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ModeSelection = "Interval";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ModeSelection = "Fixed Time";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.ModeSelection = "Fixed Pieces";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
