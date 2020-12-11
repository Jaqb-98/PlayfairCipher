using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlayfairCipher
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Key: ");
            var key = Console.ReadLine().ToLower();
            var playfair = new PlayFair();
            Console.Write("text: ");
            string txt = Console.ReadLine().ToLower();

            playfair.SetKey(key);
            playfair.KeyGen();
            string e = "";
            if (txt.Length % 2 == 0)
            {
                e = playfair.EncryptMessage(txt);

                Console.WriteLine("Encryption: " + e);
            }
            else
            {
                txt = txt + 'x';
                e = playfair.EncryptMessage(txt);
            }   

            Console.WriteLine("Decryption: " + playfair.DecryptMessage(e));

            Console.ReadLine();
        }
    }
}
