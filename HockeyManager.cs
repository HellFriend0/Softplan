using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HockeyManager
{
    public class HockeyManager
    {
        public ArrayList Attackers = new ArrayList();
        public ArrayList Deffenders = new ArrayList();
        public ArrayList Goalkeepers = new ArrayList();

        public HockeyManager() {
        
        }

        public void AddNewForward(String name, int age, int goals)
        {
            Forward player = new Forward(name, age, goals);
            Attackers.Add(player);
        }
        public void AddNewDefender(String name, int age, int hits)
        {
            Defender player = new Defender(name, age, hits);
            Deffenders.Add(player);
        }
        public void AddNewGoalie(String name, int age, int victories)
        {
            Goalie player = new Goalie(name, age, victories);
            Goalkeepers.Add(player);
        }
        public void PrintNameAndAgeOfTheYoungestGoalie()
        {
            int tmp = 100;
            String name = "Not added";
            int age = 0;
            foreach (Goalie player in Goalkeepers) {
                if (player.age < tmp) {
                    tmp = player.age;
                    name = player.name;
                    age = player.age;
                }
            }

            Console.WriteLine("Youngest GoalKeeper in our team is {0} and his age is {1}",name,age);
        }
    }
}
