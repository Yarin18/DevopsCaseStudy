using KlassenAdministratieDevOps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KlassenAdministratieDevOps
{
    /**
     * This class represents a student.
     * Each student has a name, age, a Dictionary of Subjects and their grades for it.
     */
    public class Student : Human
    {
        public String ClassName;
        public Dictionary<Subject, Double> Grades { get; set; } = new Dictionary<Subject, double>(); 

        public Student(String name, Int64 age, string className) : base(name, age)
        {
            ClassName = className;  
            this.Grades = new Dictionary<Subject, Double>();
        }

        public Student(String name, Int64 age, String className, Dictionary<Subject, Double> grade) : this(name, age, className)
        {
            this.Grades=grade;
        }
    }
}
