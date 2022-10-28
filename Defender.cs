using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    public class Defender
    {
        public String name;
        public int age;
        public int hits;

        public Defender(string name, int age, int hits)
        {
            this.name = name;
            this.age = age;
            this.hits = hits;
        }
    }
}
