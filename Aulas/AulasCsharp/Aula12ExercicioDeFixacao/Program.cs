using System;

namespace Aula12ExercicioDeFixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented ?");
            int n = int.Parse(Console.ReadLine());

            Reserva[] vect = new Reserva[10];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Rent #{i + 1}");
                Console.Write("\nName: ");
                string name = Console.ReadLine();
                Console.Write("\nEmail: ");
                string email = Console.ReadLine();
                Console.Write("\nRoom: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Reserva(name, email);
            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine($"{i}: " + vect[i]);
                }
            }
        }
    }
}
