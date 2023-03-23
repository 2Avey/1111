using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    class Program
    {
        static void Main(string[] args)
        {
            ComputerClub computerClub = new ComputerClub(8);
            computerClub.Work();
        }
    }
    class ComputerClub   
    {
        private int _money = 0;
        private List<Computer> _computers = new List<Computer>();
        private Queue<Schoolboy> _schoolboys = new Queue<Schoolboy>();

        public ComputerClub(int computerCount) 
        { 
            Random rand= new Random();
            for (int i = 0; i < computerCount; i++)
            {
                _computers.Add(new Computer(rand.Next(5,15)));
            }

            CreateNewSchoolboy(25);
        }
        private void CreateNewSchoolboy(int count)//цыкл в методе с подачей на определенное колво итераций
        {
            Random rand= new Random();
            for (int i=0;i< count; i++)
            {
                _schoolboys.Enqueue(new Schoolboy(rand.Next(100,250), rand));
            }
        }
        public void Work()
        {
            while (_schoolboys.Count>0) 
            {
                Console.WriteLine($"In Computer Club now {_money} dollars, wait new clients");

                Schoolboy schoolboy= _schoolboys.Dequeue();
                Console.WriteLine($"Now 1 client, he wanna buy {schoolboy.DesiredMinutes} minuts");
                Console.WriteLine("\n Computer list: ");

                ShowAllComputers();

                Console.Write("\nYou choise number PC for client - ");
                int computerNumber = Convert.ToInt32( Console.ReadLine() );

                if (computerNumber >= 0 && computerNumber < _computers.Count)
                {
                    if (_computers[computerNumber].IsBusy)
                    {
                        Console.WriteLine("You choise computer what is BUSY, YOU lose client...");
                    }
                    else
                    {
                        if (schoolboy.CheakSoIvency(_computers[computerNumber]))
                        {
                            Console.WriteLine($"Cient go to computer {computerNumber}");
                            _money += schoolboy.ToPay();

                            _computers[computerNumber].TakeThePlace(schoolboy);
                        }
                        else
                        {
                            Console.WriteLine("Client don't have money, he leave");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You write bad info, you lose client, nice work");
                }


                Console.WriteLine("Press any kay to next client");
                Console.ReadKey();
                Console.Clear();
                SkipMinute();
            }
        }
        public void SkipMinute()
        {
            foreach (var compute in _computers)
            {
                compute.SkipMinute();
            }
        }
        public void ShowAllComputers()
        {
            for (int i = 0; i < _computers.Count; i++)
            {
                Console.Write($"{i} - ");
                _computers[i].ShowInfo();
            }
        }
    }
    class Computer
    {
        private Schoolboy _schoolboy;
        private int _minutsLeft;

        public int PriceForMinutes { get; private set; }
        public bool IsBusy
        {
            get
            {
                return _minutsLeft > 0 ;//возвращает проверку (истина или нет)
            }
        }
        public Computer (int priceForMinutes)
        {
            PriceForMinutes= priceForMinutes;
        }
        public void TakeThePlace(Schoolboy schoolboy)
        {
            _schoolboy= schoolboy;
            _minutsLeft = _schoolboy.DesiredMinutes;
        }
        public void FreeThePlace()
        {
            _schoolboy = null;
        }
        public void SkipMinute()
        {
            _minutsLeft--;
        }
        public void ShowInfo()
        {
            if (IsBusy)
                Console.WriteLine($"Computer is nusy, minute to free {_minutsLeft}");
            else
                Console.WriteLine($"Computer is Free Preic per minute {PriceForMinutes}");
        }
    }
    class Schoolboy
    {
        private int _money;
        private int _moneyToPay;
        public int DesiredMinutes { get; private set; }

        public Schoolboy(int money, Random rand) 
        { 
            _money = money;
            DesiredMinutes = rand.Next(10,30);
        }
        public bool CheakSoIvency(Computer computer)
        {
            _moneyToPay = computer.PriceForMinutes * DesiredMinutes;
            if (_money >= _moneyToPay)
            {
                return true;
            }
            else
            {
                _moneyToPay = 0;
                return false;
            }
        }
        public int ToPay()
        {
            _money -= _moneyToPay;
            return _moneyToPay;
        }
    }
}
