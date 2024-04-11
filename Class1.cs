using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Greetings
    {
        /// <summary>
        /// 
        /// </summary>
        public void Welcome()
        {
            Console.WriteLine("Hello Traveler! Welcome!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        public void Hello(string name)
        {
            Console.WriteLine($"{name}, thank you for joining us today!");
        }
    }
}
