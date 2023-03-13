using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace elements
{
    internal class alumne
    { //ATRIBUTS

        internal class Alumne
        {
            private string cognom;
            private DateTime dataNaixament;
            private string email;
            private string nif;
            private string nom;
            private int numAlumne;
            private char sexe;
            private int telefon;


            //PROPIETATS

            #region//Propietats
            public string Cognom
            {
                get { return cognom; }
                set { cognom = value; }
            }
            public DateTime DataNaixament
            {
                get { return dataNaixament; }
                set { dataNaixament = value; }
            }
            public string DataNaix
            {
                get { return dataNaixament.ToString(); }
                set { DateTime.TryParse(value, out dataNaixament); }
            }
            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            public string Nif
            {
                get { return nif; }
                set { nif = value; }
            }
            public string Nom
            {
                get { return nom; }
                set { nom = value; }
            }
            public char Sexe
            {
                get { return sexe; }
                set { sexe = value; }
            }
            public int Telefon
            {
                get { return telefon; }
                set { telefon = value; }
            }
            //METODES
            #endregion
            public bool DataValid(DateTime data)
            {
                DateTime limit = new DateTime(1900, 01, 01);
                bool valid = false;
                do
                {
                    if (data > DateTime.Now || data < limit)
                    {
                        Console.WriteLine("Data incorrecte, torna a introduirla: ");
                        data = DateTime.Parse(Console.ReadLine());
                    }
                    else
                        valid = true;
                } while (!valid);
                return valid;
            }
            public int Edat()
            {
                int edat = DateTime.Now.Year - dataNaixament.Year;
                if (DateTime.Now.Month < dataNaixament.Month)
                    edat--;
                else
                {
                    if (DateTime.Now.Day < dataNaixament.Day)
                        edat--;
                }
                return edat;
            }
            private string EmailValid(string correo)
            {
                string patron = "[^@]+@[^\\.]+\\..+";
                Regex regex = new Regex(patron);
                do
                {
                    Console.WriteLine("Error,escribe nuevamente");
                    correo = Console.ReadLine();
                }
                while (!regex.IsMatch(email));
                return correo.ToLower();
            }
        public void Mostra()
        {
            Console.WriteLine($"DADES ALUMNE {nom}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Cognom: {cognom}");
            Console.WriteLine($"NIF: {nif}\tNum Alumne: {numAlumne}");
            Console.WriteLine($"Telf: {telefon}\tE-mail: {email}");
            Console.WriteLine($"Edat: {this.Edat()}");
            Console.WriteLine($"Sexe: {sexe}");
        }
            private string NifValid(string document)
            {
                string dniLetra, dniNumeros;
                string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
                while (document.Length != 9)
                {
                    Console.WriteLine("Dni mal escrito, ingrese nuevamente.");
                    document = Console.ReadLine();
                }
                dniNumeros = document.Substring(0, document.Length - 1);
                dniLetra = document.Substring(document.Length - 1, 1);
                int numeros = Int32.Parse(dniNumeros);
                var mod = numeros % 23;
                document = dniNumeros + control[mod];
                return document;
            }
                private string NomValid(string nom)
                {
                    Regex validar = new Regex("[a-zA-Z]");
                    if (!validar.IsMatch(nom))
                    {
                        Console.WriteLine("El només pot contenir lletres, torna a escriure");
                        nom = Console.ReadLine();
                    }
                    return nom;
                }
            public int NumAlumne()
            {
            }
                private string TelfValid(string tlf)
                {
                    int i = 0, numeroInt;
                    while (tlf.Length != 9)
                    {
                        Console.WriteLine("Numero mal escrito, ingrese de nuevo.");
                        tlf = Console.ReadLine();
                    }
                    bool esNumero = int.TryParse(tlf, out numeroInt);
                    while (esNumero == false)
                    {
                        Console.WriteLine("El numero no puede contener letras, ingrese de nuevo.");
                        tlf = Console.ReadLine();
                        esNumero = int.TryParse(tlf, out numeroInt);
                    }
                    return tlf;
                }
                public string ToString()
                {
                    return $"Nom: {nom} \rCognom: {cognom}\rNum alumne: {numAlumne} \rData de naixament: {dataNaixament}\rNIF:{nif}\rEmail: {email}\r" +
                        $"Telefon: {telefon}\r Sexe:{sexe}";
                }
           
            
            public override bool Equals(object obj)
            {
                if(obj == null || GetType() != obj.GetType()) return false;
                else
                {
                    if (obj.ToString().Contains(this.Nif)) return true;
                    else return false;
                }
            }
            public static bool operator ==(Alumne a1, Alumne a2)
            {
                if (
                    a1.Nom == a2.Nom &&
                    a1.Cognom == a2.Cognom &&
                    a1.NumAlumne == a2.NumAlumne &&
                    a1.Nif == a2.Nif &&
                    a1.DataNaixament == a2.DataNaixament &&
                    a1.Email == a2.Email &&
                    a1.Telefon == a2.Telefon &&
                    a1.Sexe == a2.Sexe
                    ) return true;
                else return false;
            }
            public static bool operator !=(Alumne a1, Alumne a2)
            {
                if (a1 == a2) return false;
                else return true;
            }
        }
    }
}