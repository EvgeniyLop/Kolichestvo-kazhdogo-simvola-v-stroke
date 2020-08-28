using System;

namespace Количество_каждого_символа_в_строке
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string s = Console.ReadLine();
            char[] array = s.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '\0') { }
                else
                {
                    int a = 1;
                    for (int j = 1; j < array.Length - i; j++)
                    {
                        if (array[i] == array[i + j])
                        {
                            a++;
                            array[i + j] = '\0';
                        }
                    }
                    Console.WriteLine(array[i] + " - " + a);
                }
            }
        }
    }
}
    

