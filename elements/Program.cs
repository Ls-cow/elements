﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
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

            Thread.Sleep(5000);
            Console.Clear();

            //program moduls
            int index = 0;
            Console.CursorVisible = false;
            do
            {
                Console.Clear();
                MenuPrincipal();
                Pinta(2, 4, ">");
                index = Seleccio(index, 6);
                switch (index)
                {
                    case 0:
                        Console.Write("Introdueix la mida del mòdul: ");
                        int mida = Convert.ToInt32(Console.ReadLine());
                        Modul(mida);
                        Console.WriteLine("Mòdul creat amb èxit!"); 
                        break;
                    case 2:
                        Modul.ToString();
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13://sortir
                        break;

                }
            } while (index != 13);

        }
        //MENU
        public static void Pinta(int x, int y, string l)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(l);
        }
        public static void Recuadre(int max)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Pinta(0, 1, "Prem Q per sortir");
            Console.ForegroundColor = ConsoleColor.White;
            Pinta(0, 3, "********************************");
            for (int i = 4; i < max; i++)
                Pinta(0, i, "*                              *");
            Pinta(0, max, "********************************");
        }
        public static void MenuPrincipal()
        {
            Recuadre(7);
            Pinta(4, 4, "Crear Modul");
            Pinta(4, 5, "Mostrar Modul");
            Pinta(4, 6, "Afegir alumne a Modul");
            Pinta(4, 7, "Consultar alumne a Modul");
            Pinta(4, 7, "Eliminar alumne a Modul");
            Pinta(4, 7, "Llistar alumnes de Modul");
        }
        public static int Seleccio(int select, int max)
        {
            ConsoleKey key = ConsoleKey.Spacebar;
            int x = 2, y = 4;
            while (key != ConsoleKey.Enter)
            {
                //Sortir del menu al apretar Q
                if (key == ConsoleKey.Q)
                {
                    select = 13;
                    Console.Clear();
                    return select;
                }
                else
                {
                    //Mou selector per teclat
                    key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.UpArrow)
                    {
                        select--;
                        y--;
                    }
                    else if (key == ConsoleKey.DownArrow)
                    {
                        select++;
                        y++;
                    }
                    //Si arriba al final del menú
                    if (select < 0)
                    {
                        select = max;
                        y = max + 4;
                    }
                    else if (select > max)
                    {
                        select = 0;
                        y = 4;
                    }
                    //Pinta el selector i repinta el menú
                    Console.Clear();
                    MenuPrincipal();
                    Pinta(x, y, ">");
                }
            }
            Console.Clear();
            return select;
        }

    }
}
