using System;
using System.Text;
namespace CursoNet
{
    class Program
    //leer las mayusculs y minusculas 
    {
        private String cadena;
        private String verMayus = "";
        private String verMinus = "";
        private int n;
        private string[] Mayusculas;
        private string[] Minusculas;
        private string[] tempMay;

        private string[] tempMin;

        public Program(string cadena)
        {
            this.cadena = cadena;
            n = cadena.Length;
            Mayusculas = new string[n];
            Minusculas = new string[n];
            tempMay = new string[n];
            tempMin = new string[n];
        }
        private String mayusculas()
        {
            for (int i = 0; i < n; i++)
            {
                if (Char.IsUpper(cadena[i]))
                {
                    tempMay[i] = Convert.ToString(cadena[i]);
                }

            }
            for (int i = 0; i < tempMay.Length; i++)
            {
                if (tempMay[i] != null)
                {
                    Mayusculas[i] = tempMay[i];
                    verMayus = verMayus+","+Mayusculas[i];

                }
            }

            return verMayus;
        }
        private String minusculas()
        {
            for (int i = 0; i < n;)
            {
                if (char.IsLower(cadena[i]))
                {
                    tempMin[i] = Convert.ToString(cadena[i]);
                }

            }
            for (int i = 0; i < tempMin.Length; i++)
            {
                if (tempMin[i] != null)
                {
                    Minusculas[i] = tempMin[i];
                    verMinus = verMinus+","+Minusculas[i];
                }
            }
            return verMinus;
        }
        static void Main()
        {
           
            Console.WriteLine("INGRESE EL TEXTO A LEER ");
            var cadena = Console.ReadLine();

            var cl = new Program(cadena);
           Console.Write(" las Mayusculas y Minusculas son \n" + "Mayusculas : \t" + cl.mayusculas() + "\n Minusculas" + cl.minusculas());
            Console.ReadLine();

        }

    }
}