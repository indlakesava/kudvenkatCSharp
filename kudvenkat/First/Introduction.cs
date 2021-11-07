using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kudvenkat.First
{
    class Introduction
    {
        #region First
        public void first()
        {
            Console.WriteLine("Welcome to C# Tutorials");
            first1();
        }

        private void first1()
        {
            Console.WriteLine("This function is called from main");
        }
        #endregion

        #region Second
        public void second()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.Read();
        }
        #endregion
    }
}
