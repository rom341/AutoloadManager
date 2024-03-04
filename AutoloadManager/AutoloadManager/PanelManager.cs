using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoloadManager
{
    public class PanelManager
    {
        public static Panel createPanelWithProgramName(ProgramForProfile program)
        {
            ProgramForProfile programCopy = program;
            Panel panel = new Panel
            {
                Size = new System.Drawing.Size(200, 100),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.LightGray
            };

            Label lProgramName = new Label
            {
                Text = program.Name,
                Location = new System.Drawing.Point(0, 0),
                AutoSize = false,
                Size = new System.Drawing.Size(200, 20),
                BorderStyle = BorderStyle.FixedSingle,
            };

            Label lFileName = new Label
            {
                Text = program.Path,
                Location = new System.Drawing.Point(0, 20),
                AutoSize = false,
                Size = new System.Drawing.Size(200, 20),
                BorderStyle = BorderStyle.FixedSingle,
            };

            PictureBox pbIcon = new PictureBox
            {
                Image = program.Image,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new System.Drawing.Size(50, 50),
                Location = new System.Drawing.Point(0, 40),
                BorderStyle = BorderStyle.FixedSingle
            };

            Button btnEdit = new Button
            {
                Text = "Edit",
                Location = new System.Drawing.Point(140, 45),
                Size = new System.Drawing.Size(55, 20)
            };

            Button btnRemove = new Button
            {
                Text = "Remove",
                Location = new System.Drawing.Point(140, 70),
                Size = new System.Drawing.Size(55, 20)
            };

            btnEdit.Click += (sender, e) =>
            {
                fProgramConfigurator fProgramConfigurator = new fProgramConfigurator(ref programCopy);
                if (fProgramConfigurator.ShowDialog() == DialogResult.OK)
                {
                    lProgramName.Text = program.Name;
                    lFileName.Text = program.Path;
                    pbIcon.Image = program.Image;
                }
            };

            btnRemove.Click += (sender, e) =>
            {
                if (MessageBox.Show("Are you sure?", "Remove program", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    panel.Dispose();
                }
            };

            panel.Controls.Add(lProgramName);
            panel.Controls.Add(lFileName);
            panel.Controls.Add(pbIcon);
            panel.Controls.Add(btnEdit);
            panel.Controls.Add(btnRemove);

            return panel;
        }
    }
}
