using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN2A2U3
{
    internal class Program
    {
        public static void Main()
        {

            try
            {
                var lista = new List<string>();
                List<String> variantesCovid = new List<String>();
                variantesCovid.InsertRange(0, new String[] { "alfa", "beta", "gama", "delta", "omicron", "psi" });

                int[] enteros4 = { 3, 6, 9, 12, 15, 18, 21 };
                int[] enteros5 = new int[6];
                int[] valores = null;
                int[] dividendos = { 20, 7, 0 };

                Console.WriteLine("Número de elementos de lista: {0}", lista.Count);

                Console.WriteLine("El primer elemento de la lista es: '{0}'", lista[0]);


                for (int control = 0; control <= variantesCovid.Count; control++)
                    Console.Write("'{0}' ", variantesCovid[control]);
                enteros5[enteros4.Length - 1] = enteros4[enteros4.Length - 1];


                for (int i = 0; i <= 9; i++)
                    valores[i] = i * 2;


                foreach (var value in valores)
                    Console.WriteLine(value);

                foreach (var value in dividendos)

                {
                    Console.WriteLine("{0} dividido entre 2 es {1}", value, DivideEntreDos(value));
                }




                Console.WriteLine(Divide(1, 0));


            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);

            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);

            }


            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        static int DivideEntreDos(int num)
        {

            return num / 2;

        }
        static double Divide(int dividendo, int divisor)
        {

            return dividendo / divisor;


        }

    }

}
