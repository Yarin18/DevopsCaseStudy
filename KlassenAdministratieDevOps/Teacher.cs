using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenAdministratieDevOps
{
    public class Teacher : Human
    {
        public String ClassName { get; set; }
        public Teacher(String name, int Age, string className) : base(name, Age)
        {
            ClassName = className;  
        }
    }
}
