using System;
using System.Text;

namespace Cryptography;

public class Atbash
{
    public static string Encrypt(string plaintext)
    {

        byte[] ascii_values = Encoding.ASCII.GetBytes(plaintext);

        for(int i = 0; i < plaintext.Length; i++)
        {
            int rev = ascii_values[i];
            int minus = rev < 96 ? 64 : 96;

            rev -= minus;
            rev -= 27;
            rev *= -1;
            rev += minus;

            ascii_values[i] = (byte)rev;
        }

        return Encoding.ASCII.GetString(ascii_values);
    }

    public static string Decrypt(string ciphertext)
    {

        byte[] ascii_values = Encoding.ASCII.GetBytes(ciphertext);

        for (int i = 0; i < ciphertext.Length; i++)
        {
            int rev = ascii_values[i];
            int minus = rev < 96 ? 64 : 96;

            rev -= minus;
            rev -= 27;
            rev *= -1;
            rev += minus;

            ascii_values[i] = (byte)rev;
        }

        return Encoding.ASCII.GetString(ascii_values);
    }
}
