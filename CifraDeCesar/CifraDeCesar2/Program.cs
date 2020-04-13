using System;

namespace CifraDeCesar
{
    class Program
    { 
        public static string Encipher(string input, int key)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            };

            string userOutput = "";
            char[] a = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                char c = a[i];
                int temp;
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    temp = (int)(a[i] + key);
                    if ((c >= 'A' && c <= 'Z' && temp > 'Z') || (c >= 'a' && c <= 'z' && temp > 'z'))
                        temp = temp - 26;
                    else
                        temp = (int)(a[i] + (key));
                }
                else
                    temp = c;
                userOutput += (char)temp;
            }
            return userOutput.ToLower();
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key).ToLower();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Encriptar (1) ou descriptar (2)?");
            int Escolha = Convert.ToInt32(Console.ReadLine());

            if (Escolha == 1)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Escreva a frase a ser encriptada:");

                string UserString = Console.ReadLine();

                Console.WriteLine("\n");
                Console.WriteLine("Escreva o número de casas:");

                int key = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");
                Console.WriteLine("Frase encriptada:");

                string cipherText = Encipher(UserString, key);
                Console.WriteLine(cipherText);

            }
            else if (Escolha == 2)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Escreva a frase a ser decriptada:");

                string UserString = Console.ReadLine();

                Console.WriteLine("\n");
                Console.WriteLine("Escreva o número de casas:");

                int key = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n");
                Console.WriteLine("Frase decriptada:");

                string decipherText = Decipher(UserString, key);
                Console.WriteLine(decipherText);
            }
            else
                Console.WriteLine("Opção ñ existente!");

            Console.ReadKey();
        }
    }
}
