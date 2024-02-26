using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoloadManager
{
    public struct ProgramForProfile : IEquatable<ProgramForProfile>
    {
        public string Name { get; private set; }
        public string Path { get; private set; }
        public Image Image { get; private set; }

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
