using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_vjezba
{
    class Program
    {
        static void Main(string[] args)
        {
            Programer programer = new Programer();
            programer.Ime = "Edo";
            Console.WriteLine(programer.PrikaziIme());

            Vozac vozac = new Vozac();
            vozac.Ime = "Jasko";
            Console.WriteLine(vozac.PrikaziIme());
            Console.WriteLine("Reverse string " + ReverseString("abcd"));
            Console.WriteLine("Remove duplicates from string " + RemoveDuplicatesString("Goooglee"));
            Console.WriteLine("Remove %20 from string " + RemoveText("edo%2p"));
            Modulo(0, 10, 10);
            Console.ReadLine();
        }

        public static void Modulo(int start, int divider, int stop)
        {
            for (int i = start; i < stop + 1; i++)
            {
                var result = i % divider;
                Console.WriteLine(i.ToString() + "%" + divider.ToString() + " equals " + result.ToString());
            }
        }

        public static string ReverseString(string str)
        {
            if (str == null)
            {
                return str;
            }
            else
            {
                int strLength = str.Length;
                if (strLength < 2)
                {
                    return str;
                }
                else
                {
                    string newString = "";
                    for (int i = strLength; i > 0; i--)
                    {
                        newString += str[i - 1];
                    }
                    return newString;
                }
            }            
        }

        public static string RemoveDuplicatesString(string str)
        {
            if (str == null)
            {
                return str;
            }
            else
            {
                int stringLength = str.Length;
                if (stringLength < 2)
                {
                    return str;
                }
                else
                {
                    string newString = str[0].ToString();
                    for (int i = 0; i < stringLength - 1; i++)
                    {
                        if (str[i] != str[i + 1])
                        {
                            newString += str[i + 1];
                        }
                    }
                    return newString;
                }
            }
        }

        public static string RemoveText(string str)
        {
            if (str == null)
            {
                return str;
            }
            else
            {
                string newString = "";
                int stringLength = str.Length;
                // e%20
                for (int i = 0; i < stringLength; i++)
                {
                    if (str[i].ToString() == "%" && i < (stringLength - 1) - 1)
                    {
                        if (str[i + 1].ToString() == "2" && str[i + 2].ToString() == "0")
                        {
                            i += 2;
                        }
                        else
                        {
                            newString += str[i];
                        }
                    }
                    else
                    {
                        newString += str[i];
                    }                    
                }
                return newString;
            }
        }
    }
}
