using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    public class Forward
    {
        public String name;
        public int age;
        public int goals;

        public Forward(string name, int age, int goals)
        {
            this.name = name;
            this.age = age;
            this.goals = goals;
        }
    }
}
