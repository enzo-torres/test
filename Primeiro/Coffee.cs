using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    class Coffee
    {
        public bool Status { set; get; }

        public bool Empty()
        {
            if (Status == false)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void Refill()
        {
            Status = true; 
        }
        public void Drink()
        {
            Status = false;
        }
    }
}
