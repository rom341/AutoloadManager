using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoloadManager
{
    public partial class fProgramConfigurator : Form
    {
        private ProgramForProfile _program;
        public fProgramConfigurator(ref ProgramForProfile program)
        {
            InitializeComponent();
            _program = program;

            pbIcon.Image = _program.Image;
            lFileName.Text = _program.Path;
            tbName.Text = _program.Name;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _program.Name = tbName.Text; 
            _program.Path = lFileName.Text;
            _program.Image = pbIcon.Image;

            DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnChangeIcon_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbIcon.Image = Icon.ExtractAssociatedIcon(openFileDialog1.FileName).ToBitmap();
            }
        }

        private void btnChangeFileName_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lFileName.Text = openFileDialog1.FileName;
            }
        }
    }
}
