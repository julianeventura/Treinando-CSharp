using System;


namespace CifraDeCesar
{
    class Program
    {
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'a' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        public static string Encipher(string message, int key)
        {
            int casas = key;

            if (message == null)
            {
                throw new ArgumentNullException();
            }
            else
                message = message.ToLower();

            string output = string.Empty;

            foreach (char ch in message)
            {
                output += cipher(ch, casas);
            }

            return output;
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
