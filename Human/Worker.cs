using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
   public class Worker : Human 
    {
        
            public Worker()
                : base()
            { }

            public override string ToString()
            {
                return String.Format("{0},{1},{2}", Age);
            }
        
    }
}
