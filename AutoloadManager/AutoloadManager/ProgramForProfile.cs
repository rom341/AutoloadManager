using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoloadManager
{
    public class ProgramForProfile : IEquatable<ProgramForProfile>
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public Image Image { get; set; }

        public ProgramForProfile(string name, string path, Image image)
        {
            Name = name;
            Path = path;
            Image = image;
        }

        public bool Equals(ProgramForProfile other)
        {
            return Name == other.Name && Path == other.Path;
        }
    }
}
