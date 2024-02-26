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
    public partial class fMain : Form
    {
        private fProfileConfigurator _fProfileConfigurator;
        private Profile _lastProfile;
        public fMain()
        {
            InitializeComponent();
            _lastProfile = new Profile("TestName", "TestDescription", null, new List<ProgramForProfile>());
            _fProfileConfigurator = new fProfileConfigurator(ref _lastProfile);
            
        }

        private void btnAddNewProfile_Click(object sender, EventArgs e)
        {
            _fProfileConfigurator.ShowDialog();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            btnAddNewProfile.PerformClick();
        }
    }
}
