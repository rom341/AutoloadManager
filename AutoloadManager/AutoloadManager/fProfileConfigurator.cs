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

        private void btnAddNewProgram_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbListOfPrograms.Text += openFileDialog1.FileName + "\n";

                Panel panel = PanelManager.createPanel(new Profile("Test", "Test", new Bitmap(50, 50), new string[] { openFileDialog1.FileName }));
                flpListOfPrograms.Controls.Add(panel);
            }
        }
    }
}
