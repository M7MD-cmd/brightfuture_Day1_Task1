using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Task
{
    public class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public Hero(string name, int level)
        {
            Name = name;
            Level = level;
        }
    }
}
