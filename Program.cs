using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boucle7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int counter;
            for (counter = 0; counter < 10; counter++)//variable, condition, incrémentation | on peut remplacer counter par i
            {
                Console.WriteLine(numbers[counter]);//tableau[indice]
            }
            /*Méthode foreach
            foreach (int number in numbers.Take(10)) Récupère les10 premiers nombre grace à la fonction .take()
            {
                Console.WriteLine(number);
            }*/
        }
    }
}
