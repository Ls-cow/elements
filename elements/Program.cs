using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alumne alumne = new Alumne();

            Console.WriteLine("Escriu el nom");
            alumne.Nom = Console.ReadLine();

            Console.WriteLine("Escriu el cognom");
            alumne.Cognom = Console.ReadLine();

            Console.WriteLine("Escriu la data de naixament");
            alumne.DataNaixament = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Escriu Email");
            alumne.Email = Console.ReadLine();

            Console.WriteLine("Escriu nif");
            alumne.Nif = Console.ReadLine();

            Console.WriteLine("Escriu el sexe");
            alumne.Sexe = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Escriu telefon");
            alumne.Telefon = Convert.ToInt32(Console.ReadLine());

            alumne.Mostra();
            
        }
    }
}
