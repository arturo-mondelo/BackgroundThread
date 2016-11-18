using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoGenericos
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrInts = new int[] { 2, 5, 4, 7, 1, 3, 9, 8 };
            char[] arrChar = new char[] { 'f', 'a', 'r', 'c', 'h' };

            //Ordenando integer

            for (int i = 0; i < arrInts.Length; i++)
            {
                for (int j = i + 1; j < arrInts.Length; j++)
                {
                    if (arrInts[i] > arrInts[j])
                    {
                        swap<int>(ref arrInts[i], ref arrInts[j]);

                        //debug
                        Console.WriteLine(string.Join(",", arrInts));
                        Console.ReadLine();

                    }



                }
            }

            //Ordenando char
            for (int i = 0; i < arrChar.Length; i++)
            {
                for (int j = i + 1; j < arrChar.Length; j++)
                {
                    if (arrChar[i] > arrChar[j])
                    {
                        swap<char>(ref arrChar[i], ref arrChar[j]);

                        //debug
                        Console.WriteLine(arrChar);
                        Console.ReadLine();

                    }


                }
            }

        }

        static void swap<T>(ref T valorUno, ref T valorDos)
        {

            T temp = valorUno;
            valorUno = valorDos;
            valorDos = temp;
        }
        }
    }

