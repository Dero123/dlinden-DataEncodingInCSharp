using System;

namespace dlinden_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // char ch;
            // ch = 'A';
            // Console.WriteLine($"ch is storing the value: {ch}");

            // int ch_decimal;
            // ch_decimal = ch;
            // Console.WriteLine($"the decimal value  of ch is: {ch_decimal}");

            // int toConvert;
            // Console.WriteLine("Enter an integer: ");
            // toConvert = int.Parse(Console.ReadLine());

            // char asChar;
            // asChar = (char)toConvert;
            // Console.WriteLine($"The integer {toConvert} cast to a char is '{asChar}'");

            // char b;
            // b = (char)('o' + -3);
            // Console.WriteLine($"'A' + 1 = '{b}'");
            
            Cipher cipher;
            cipher = new Cipher(5);

            string encrypted;
            encrypted = cipher.Encrypt("rosebud");
            int shift;
            Console.WriteLine($"the encrypted message is: '{encrypted}'");
           
            string decrypted;
            decrypted = cipher.Decrypt(encrypted);
            Console.WriteLine($"The decrypted message is: '{decrypted}'");

            string message;
            message = System.IO.File.ReadAllText("secrets/1.txt");
            Console.WriteLine($"The encrypted message is: '{message}'");

            string newDecrypted;
            Cipher newCipher;
            newCipher = new Cipher(3);
            newDecrypted = newCipher.Decrypt(message);
            Console.WriteLine($"the decrypted message is: '{newDecrypted}'");

            string filePath = args[0];
            Console.WriteLine($"Loading '{filePath}'.");

            // string message;
            message = System.IO.File.ReadAllText(filePath);
            // Console.WriteLine.($"The encrypted message is: {message}");
            
            int newShift = 1;
            while (newShift <= 10)
            {
                Cipher newestCipher;
                newestCipher = new Cipher(newShift);
                 string newestDecrypted;
                 newestDecrypted = newestCipher.Decrypt(message);
                 Console.WriteLine($"the decrypted message is: '{newestDecrypted}'");
                newShift = newShift+1;

            }

        }
    }
}
