using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesApp
{
    internal interface IMovable
    {
        void Move5();

        //default implementation
        void Move10()
        {
            Console.WriteLine("Move 10");
        }
    }
}
