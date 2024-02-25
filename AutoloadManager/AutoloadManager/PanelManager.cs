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
        public static Panel createPanel(Profile profile)
        {
            Panel panel = new Panel
            {
                Size = new System.Drawing.Size(200, 80),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lProfileName = new Label
            {
                Text = profile.name,
                Location = new System.Drawing.Point(10, 10)
            };

            PictureBox pbIcon = new PictureBox
            {
                Image = profile.icon,
                Size = new System.Drawing.Size(50, 50),
                Location = new System.Drawing.Point(10, 30)
            };

            panel.Controls.Add(lProfileName);
            panel.Controls.Add(pbIcon);

            return panel;
        }
    }
}
