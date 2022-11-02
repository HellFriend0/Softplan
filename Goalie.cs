using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    public class Goalie : Player
    {
        public int victories;

        public Goalie(string name, int age, int victories)
        {
            this.SetName(name);
            this.SetAge(age);
            //this.name = name;
            //this.age = age;
            this.victories = victories;
        }
    }
}
