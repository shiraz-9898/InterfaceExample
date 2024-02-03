using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Boat boat = new Boat();
            Airplane airplane = new Airplane();

            car.Move();
            boat.Move();
            airplane.Move();

            Console.ReadKey();
        }
    }

    public interface IMovable
    {
        void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The Car drives on the road");
        }
    }

    public class Boat : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The Boat sails on the water");
        }

    }

    public class  Airplane : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The Airplance flies in the sky");
        }
    }
}
