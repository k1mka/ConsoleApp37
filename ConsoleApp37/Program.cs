using System;

namespace ConsoleApp37
{
    class Gun
    {
        private bool isLoaded;

        private void Reload()
        {
            Console.WriteLine("Заряжаю..");

            isLoaded = true;

            Console.WriteLine("Заряжено!");
        }

        public void Shoot()
        {
            if (!isLoaded)
            {
                Console.WriteLine("Оружиме не заряжено");
                Reload();

            }
            Console.WriteLine("ТЫЩ! ТЫЩ!\n");
            isLoaded = false;
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            Gun gun = new Gun();
            gun.Shoot();

        }
    }
}
