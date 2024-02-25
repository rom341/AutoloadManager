using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoloadManager
{
    public class Profile
    {
        public string name { get; private set; }
        public string description { get; private set; }
        public Image icon { get; private set; }
        public string[] files { get; private set; }

        public Profile(string name, string description,Image icon, string[] files)
        {
            this.name = name;
            this.description = description;
            this.icon = icon;
            this.files = files;
        }
    }
}
