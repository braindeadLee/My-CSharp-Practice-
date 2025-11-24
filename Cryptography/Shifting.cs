using System;
using System.Text;

namespace Cryptography;

public class Shifting
{
    public static string Encrypt(string plaintext, int key)
    {

        byte[] ascii_values = Encoding.ASCII.GetBytes(plaintext);

        for(int i = 0; i < plaintext.Length; i++)
        {
            int rev = ascii_values[i];
            int minus = rev < 96 ? 64 : 96;

            rev -= minus;
            rev += key;
            rev = rev > 26 ? rev - 26 : rev;
            rev += minus;

            ascii_values[i] = (byte)rev;
        }

        return Encoding.ASCII.GetString(ascii_values);
    }

    public static string Decrypt(string ciphertext, int key)
    {

        byte[] ascii_values = Encoding.ASCII.GetBytes(ciphertext);

        for (int i = 0; i < ciphertext.Length; i++)
        {
            int rev = ascii_values[i];
            int minus = rev < 96 ? 64 : 96;

            rev -= minus;
            rev -= key;
            rev = rev < 1 ? rev + 26 : rev;
            rev += minus;

            ascii_values[i] = (byte)rev;
        }

        return Encoding.ASCII.GetString(ascii_values);
    }
}
