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
        public Image image { get; private set; }
        private List<ProgramForProfile> _programs;
        
        public Profile(string name, string description, Image image, List<ProgramForProfile> programs)
        {
            this.name = name;
            this.description = description;
            this.image = image;
            this._programs = programs;
        }
        public bool addProgram(ProgramForProfile program)
        {
            if (_programs.Contains(program))
            {
                return false;
            }
            _programs.Add(program);
            return true;
        }

        public List<ProgramForProfile> getPrograms()
        {
            return _programs;
        }
    }
}
