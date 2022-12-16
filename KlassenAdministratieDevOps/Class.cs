using KlassenAdministratieDevOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenAdministratieDevOps
{
    /**
     * This class represents a class that a student can belong to.
     * Every class has a name and a Set of students.
     */
    public class Class
    {
        public String ClassName { get; set; }
        public String FieldOfStudy { get; set; }


        public Class(String className, String fieldOfStudy)
        {
            this.ClassName = className;
            this.FieldOfStudy = fieldOfStudy;
        }
    }
}
