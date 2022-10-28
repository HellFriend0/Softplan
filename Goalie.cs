using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    public class Goalie
    {
        public String name;
        public int age;
        public int victories;

        public Goalie(string name, int age, int victories)
        {
            this.name = name;
            this.age = age;
            this.victories = victories;
        }
    }
}
