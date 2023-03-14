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
            //prova1
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
            //prova2
            Alumne alumne1 = new Alumne("Marc", "Marquez", "16182361K");
            alumne1.NumAlumne++;
            alumne1.Telefon = 611633883;
            alumne1.Email = "marc94@gmail.com";
            alumne1.Sexe = 'H';
            alumne1.DataNaixament = new DateTime(1999, 02, 19);
            alumne1.Edat();
            alumne1.Mostra();

            //prova3
            Alumne alumne2 = new Alumne("Josep", "Pujol", "16182361K", "01/02/2008", "josep34@gmail.com", 653199746, 'H');
            Alumne alumne3 = new Alumne(alumne2);
            Alumne alumne4 = new Alumne(alumne2);
            Alumne alumne5 = new Alumne(alumne2);

            //Alumnes instanciats
            alumne3.Mostra();
            alumne4.Mostra();
            alumne5.Mostra();
            //Alumne primera copia
            alumne2.Mostra();

            //comprovacio de nif
            alumne1.Mostra();
            alumne3.Mostra();

            Equals(alumne1, alumne3);
            //segona 
            alumne4.Mostra();
            alumne5.Mostra();

            Equals(alumne4, alumne5);

            //Comprovacio de igualtat
            alumne1.Mostra();
            alumne4.Mostra();

            if (alumne1 == alumne4)
                Console.WriteLine("\r\rEls alumnes son iguals");
            else Console.WriteLine("\r\rNo son iguals");

            //Segona comprovacio de igualtat
            alumne2.Mostra();
            alumne5.Mostra();
            if (alumne2 == alumne5)
                Console.WriteLine("\r\rEls alumnes son iguals");
            else Console.WriteLine("\r\rNo son iguals");

        }
    }
}
