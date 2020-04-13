using System;

namespace CifraDeCesar3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encriptar (1) ou descriptar (2)?");
            
            int Escolha = Convert.ToInt32(Console.ReadLine());

            try
            {
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

                    string cipherText = Cypher(UserString, key);
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

                    string decipherText = Cypher(UserString, 26 - key);
                    Console.WriteLine(decipherText);
                }
                else
                    Console.WriteLine("Opção ñ existente!");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Este programa não aceita argumento nulo!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Este programa não aceita caracter especial, nem letra maiuscula!");
            }

            Console.ReadKey();
            //o que está abaixo do "Console.ReadKey" nunca é rodado
            try
            {
                string message = "the quick brown fox jumps over the lazy dog";
                string cryptedMessage = "wkh txlfn eurzq ira mxpsv ryhu wkh odcb grj";
                int casas = 3;

                string a = Cypher(message, casas);
                string b = Cypher(cryptedMessage, 26 - casas);

                Console.WriteLine($"Messagem criptada: {a}");
                Console.WriteLine($"Mensagem decriptada: {b}");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Este programa não aceita argumento nulo!");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Este programa não aceita caracter especial, nem letra maiuscula!");
            }
        }

        public static string Cypher(string message, int casas)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz";
            string numeros = "0123456789";

            string output = string.Empty;

            if (message != null)
            {
                message = message.ToLower();
            }
            else
                throw new ArgumentNullException();

            foreach (char c in message)
            {
                if (alfabeto.Contains(c))
                {
                    int alfabetoIndex = alfabeto.IndexOf(c);
                    if (alfabetoIndex + casas >= alfabeto.Length)
                        alfabetoIndex = (alfabetoIndex + casas) - alfabeto.Length;
                    else
                        alfabetoIndex += casas;

                    output += alfabeto.Substring(alfabetoIndex, 1);
                }
                else if (numeros.Contains(c) || char.IsWhiteSpace(c))
                {
                    output += c;
                }
                else
                    throw new ArgumentOutOfRangeException();
            }

            return output;
        }
    }
}


