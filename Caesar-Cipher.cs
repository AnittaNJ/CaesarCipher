using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Enter a secret message: ");
            string secretmsg = Console.ReadLine();
            char[] secretstoremsg = secretmsg.ToCharArray();
            char[] encryptedmsg = new char[15];
            for(int i=0;i<secretstoremsg.Length;i++)
            {
             int index = Array.IndexOf(alphabet, secretstoremsg[i]);
             int pos = (index + 3)%26;
             char enchar = alphabet[pos]; 
             encryptedmsg[i] = enchar;
            }
            string message = string.Join("", encryptedmsg);
            Console.WriteLine(message);
        }
    }
}
