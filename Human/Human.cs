using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
   public class Human
    {
        private string _name;
        private int _age;
      
        public Human(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public Human()
        {
        }

        public int Age { get; set; }
        public void SetName(string name)
        {
            _name = name;
        }

        public void SetAge(int age)
        {
            _age = age;
        }

       

    }

    
}
