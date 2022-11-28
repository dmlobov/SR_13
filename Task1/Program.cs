using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул. Ильинская, 65", 20, -10, 6);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("ул, Гоголя, 2", -30, 15, 9, 3);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
