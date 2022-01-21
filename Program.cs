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

        }
    }
}
