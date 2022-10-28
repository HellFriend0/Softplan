Console.WriteLine("Hello Softplan\n");

HockeyManager.HockeyManager hm = new HockeyManager.HockeyManager();

hm.AddNewForward("James",19, 5);
hm.AddNewForward("Dwayne", 23, 9);
hm.AddNewDefender("Mike", 24, 12);
hm.AddNewDefender("Ian", 22, 19);
hm.AddNewGoalie("Hugo", 19, 6);
hm.AddNewGoalie("Robert", 23, 7);
hm.AddNewGoalie("Liam", 22, 12);

hm.PrintNameAndAgeOfTheYoungestGoalie();