using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManager
{
    public class Player
    {
        private int age;
        private String name;

        public int Age() { return age; }
        public String Name() { return name; }
        public void SetAge(int age) { this.age = age; }

        public void SetName(string name) { this.name = name; }
    }
}
