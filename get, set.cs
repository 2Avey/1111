using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    class Proram
    {
        static void Main(string[] args)
        {



            /*Console.WriteLine(GetLastHalf("I love CSharp!"));
            Console.WriteLine(GetLastHalf("1234567890"));
            Console.WriteLine(GetLastHalf("до ре ми фа соль ля си"));

            static string GetLastHalf(string text)
            {
                int mid = text.Length / 2;
                string str = text.Substring(mid);
                str = str.Replace(" ", "");
                return str;
            }
            G();
            H();
        }
        static string who = "class";

        static void F()
        {
            string who = "F";
        }

        static void G()
        {
            F();
            Console.WriteLine(who);
        }

        static void H()
        {
            string who = "H";
            F();
            Console.Write(who);*/

            Player player = new Player();
            player.Name = "admin";

            player.SetName("admin");
        }
        

    }
    class Player
    {
        
        
        public string Test { get; set; }
        
        public string Test1 ()
        {
            return null;
        }


        private string _name;
        public string GetName()
        {
            return _name;
        }
        public void SetName(string value) 
        {
            _name = value;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "admin")
                    return;
                _name= value;
            }
        }
    }
} 
