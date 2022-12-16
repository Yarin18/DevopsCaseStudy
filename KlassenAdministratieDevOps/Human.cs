using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlassenAdministratieDevOps
{
    /**
     * Represents an Abstract human, each human has a Name and an Age.
     */
    public abstract class Human
    {

        public String Name { get; set;  }
        public Int64 Age { get; set; }

        public Human(String Name, Int64 Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

    }
}
