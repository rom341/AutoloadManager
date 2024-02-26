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
            rtbListOfPrograms.Text = "";
            foreach (ProgramForProfile program in _profile.getPrograms())
            {
                rtbListOfPrograms.Text += program.Path + "\n";
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
                //}
                //Image image = Icon.ExtractAssociatedIcon(openFileDialog1.FileName).ToBitmap();
                //ProgramForProfile program = new ProgramForProfile(openFileDialog1.SafeFileName, openFileDialog1.FileName, image);
                //if (!_profile.addProgram(program))
                //{
                //    MessageBox.Show("Program already exists in profile");
                //    return;
                //}

                updateProgramList();
            }
        }
    }
}
