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
            Panel panel = new Panel
            {
                Size = new System.Drawing.Size(200, 80),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = System.Drawing.Color.LightGray
            };

            Label lProfileName = new Label
            {
                Text = program.Name,
                Location = new System.Drawing.Point(0, 0),
                AutoSize = false,
                Size = new System.Drawing.Size(200, 20),
                BorderStyle = BorderStyle.FixedSingle,
            };

            PictureBox pbIcon = new PictureBox
            {
                Image = program.Image,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new System.Drawing.Size(50, 50),
                Location = new System.Drawing.Point(0, 20),
                BorderStyle = BorderStyle.FixedSingle
            };

            Button btnRemove = new Button
            {
                Text = "Remove",
                Location = new System.Drawing.Point(0, 150),
                Size = new System.Drawing.Size(50, 20),
                FlatStyle = FlatStyle.Flat
            };

            panel.Controls.Add(lProfileName);
            panel.Controls.Add(pbIcon);
            panel.Controls.Add(btnRemove);

            return panel;
        }
    }
}
