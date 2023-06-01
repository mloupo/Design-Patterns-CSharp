using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy3
{
    internal class StrategyClient
    {
        static void Main(string[] args)
        {
            string OriginalText = "Una Nueva Identidad";

            IEncryptionStrategy strategy = new CaesarStrategy();
            StrategyContext context = new StrategyContext(strategy);

            string encrypted = context.EncryptText(OriginalText);
            string decrypted = context.DecryptText(encrypted);

            Console.WriteLine("Caesar: "+ OriginalText);
            Console.WriteLine("Caesar: "+ decrypted);
            Console.ReadLine();
            strategy = new AESStrategy();
            context.SetStrategy(strategy);

            encrypted = context.EncryptText(OriginalText);
            decrypted = context.DecryptText(encrypted);

            Console.WriteLine("AES: " + OriginalText);
            Console.WriteLine("AES: " + decrypted);
            Console.ReadLine();
        }
    }
}
