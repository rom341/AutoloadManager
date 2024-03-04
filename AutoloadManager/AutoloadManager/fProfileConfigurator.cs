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
    public partial class fProfileConfigurator : Form
    {
        private Profile _profile;
        public fProfileConfigurator(ref Profile profile)
        {
            InitializeComponent();
            _profile = profile;
            updateProgramList();
        }
        private void updateProgramList()
        {
            flpListOfPrograms.Controls.Clear();
            foreach (ProgramForProfile program in _profile.getPrograms())
            {
                Panel panel = PanelManager.createPanelWithProgramName(program);
                flpListOfPrograms.Controls.Add(panel);
            }
        }

        private void btnAddNewProgram_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string existingFiles = "";
                foreach (string filename in openFileDialog1.FileNames)
                {
                    Image image = Icon.ExtractAssociatedIcon(filename).ToBitmap();
                    ProgramForProfile program = new ProgramForProfile(System.IO.Path.GetFileName(filename), filename, image);
                    if (!_profile.addProgram(program))
                    {
                        existingFiles += filename + "\n";
                        continue;
                    }
                }
                if(existingFiles!="")
                {
                    MessageBox.Show($"Next programs is already exist:\n{existingFiles}");
                }

                updateProgramList();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            _profile.name = tbName.Text;
            _profile.description = tbDescription.Text;
            _profile.image = pbIcon.Image;
            DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnChangeIcon_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbIcon.Image = Icon.ExtractAssociatedIcon(openFileDialog1.FileName).ToBitmap();
            }
        }
    }
}
