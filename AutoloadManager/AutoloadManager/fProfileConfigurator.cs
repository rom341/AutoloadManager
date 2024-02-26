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
                rtbListOfPrograms.Text += openFileDialog1.FileName + "\n";

                Image image = Icon.ExtractAssociatedIcon(openFileDialog1.FileName).ToBitmap();
                ProgramForProfile program = new ProgramForProfile("TestName", openFileDialog1.FileName, image);
                if (!_profile.addProgram(program))
                {
                    MessageBox.Show("Program already exists in profile");
                    return;
                }

                updateProgramList();
            }
        }
    }
}
