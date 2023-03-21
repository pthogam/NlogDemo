using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NlogDemo
{
    public class sum

    {
        log log = new log();

        public void Add(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                log.Logdebugthemessage("Entered the if condition");

                log.Logerrormessage("The addition successsfull");
            }
            else
            {
                int c = a + b;
                log.LogdedugThemessage("Entered the else condition");
                log.loginfomessage("the addition successfull");


            }
        }
    }
}  
