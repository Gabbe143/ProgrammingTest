using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AREA_SAKER
{
    class Program
    {
        static void Main(string[] args)
        {
            //ETT PROGRAM SOM KAN RÄKNA UT AREA, OMKRETS ETC FÖR OLIKA FORMER
            //GEMENSAMT? -> SKA LIGGA I SHAPE
            //2D (PRIO) -> CIRKEL, REKTANGEL, KVADRAT, TRIANGEL

            //ALLA VARIABLER/OBJEKT SKA LIGGA I EN GEMENSAM LISTA
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            shapes.Add(new Square());
            shapes.Add(new Triangle());

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.GetArea());
            }

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.GetCircumference());
            }


            //3D -> CYLINDER, KUB, KON
            //UTÖKA
        }
    }
}
