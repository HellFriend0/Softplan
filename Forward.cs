using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    public class Forward : Player
    {
        public int goals;

        public Forward(string name, int age, int goals)
        {
            this.SetName(name);
            this.SetAge(age);
            //this.name = name;
            //this.age = age;
            this.goals = goals;
        }
    }
}
