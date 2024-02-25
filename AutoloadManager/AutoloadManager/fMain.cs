﻿using System;
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
        private Profile lastProfile;
        public fMain()
        {
            InitializeComponent();
            _fProfileConfigurator = new fProfileConfigurator(ref lastProfile);
            
        }

        private void btnAddNewProfile_Click(object sender, EventArgs e)
        {
            _fProfileConfigurator.ShowDialog();
        }
    }
}
