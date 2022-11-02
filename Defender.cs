using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    public class Defender : Player
    {
        public int hits;

        public Defender(string name, int age, int hits)
        {
            this.SetName(name);
            this.SetAge(age);
            //this.name = name;
            //this.age = age;
            this.hits = hits;
        }
    }
}
