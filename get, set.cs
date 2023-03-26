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
