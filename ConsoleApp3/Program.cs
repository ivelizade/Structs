using System;
namespace HomeWork
{
    enum Destrinations
    {
        Baki, Gence, Zaqatala, Tiblisi
    }
    enum Position
    {
        Manager = 195, Developer = 200
    }
    struct Accauntant
    {
        public bool AskForBonus(Position worker, int hours)
        {
            if (hours<0)
            {
                throw new Exception("Number Of Hours Cannot Be Negative");
            }
            return hours > 45;
        }
    }
    struct Train
    {
        public int trainNumber { get; set; }
        public DateTime trainTime { get; set; }
        public Destrinations Destrination { get; set; }

        public Train(int trainNumber, DateTime trainTime, Destrinations destrination) : this()
        {
            this.trainNumber = trainNumber;
            this.trainTime = trainTime;
            Destrination = destrination;
        }
    }
    struct Person
    {
        string name;
        string surname;
        string idNumber;

    }
    class Prog
    {
        static Train[] allTrains =
         {
            new Train(123456,new DateTime(2018,5,9,3,0,0),Destrinations.Baki),
            new Train(789456,new DateTime(2018,9,12,5,30,0), Destrinations.Zaqatala),
            new Train(562122,new DateTime(2018,1,25,10,45,0), Destrinations.Gence),
             new Train(316931,new DateTime(2018,11,11,22,45,0), Destrinations.Tiblisi),
             new Train(897456,new DateTime(2018,7,5,1,45,0), Destrinations.Tiblisi),
         new Train(987452,new DateTime(2018,8,4,4,14,0), Destrinations.Gence)
        };
        static void Register()
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string idNumber = Console.ReadLine();
            if (idNumber.Length != 8)
            {
                throw new Exception("Wrong ID Number");
            }
            Console.WriteLine("Choose Your Direction");
            string dest = Console.ReadLine();
            for (int i = 0; i < allTrains.Length; i++)
            {
                for (int j = 0; j < allTrains.Length; j++)
                {
                    if (allTrains[i].trainTime.CompareTo(allTrains[i].trainTime) > 0)
                    {
                        DateTime dateTime = allTrains[i].trainTime;
                        allTrains[i].trainTime = allTrains[j].trainTime;
                        allTrains[j].trainTime = dateTime;
                    }
                }
            }

            for (int i = 0; i < allTrains.Length; i++)
            {
                if (allTrains[i].Destrination.ToString() == dest)
                {
                    Console.WriteLine($"{allTrains[i].trainNumber}\t{allTrains[i].trainTime.ToString()}\t{allTrains[i].Destrination}");
                }
            }
            int choose = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < allTrains.Length; i++)
            {
                if (choose == allTrains[i].trainNumber)
                {
                    Console.WriteLine("Thanks For Your Registration");
                    break;
                }
            }
        }
        static void Bonus()
        {
            Accauntant ac;
            string position = Console.ReadLine();
            int hours = Convert.ToInt32(Console.ReadLine());
            if (position == Position.Developer.ToString())
            {
                Console.WriteLine(ac.AskForBonus(Position.Developer, hours) == true ? "Bonus Dusur" : "Bonus Dusmur");
            }
           else if (position == Position.Manager.ToString())
            {
                Console.WriteLine(ac.AskForBonus(Position.Manager, hours) == true ? "Bonus Dusur" : "Bonus Dusmur");
            }
            else
            {
                throw new Exception("Wrong Position");
            }
        }
        static void Main()
        {

            try
            {
                Bonus();//Tapsiriq 1
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            try
            {
                Register();//Tapsiriq 2
            }
            catch (Exception err) 
            {
                Console.WriteLine(err.Message);
            }

        }
    }
}

