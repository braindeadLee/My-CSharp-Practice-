using System;
using System.Security.Cryptography;
using System.Text;

namespace Cryptography;

public class ProgramRunner
{
    public string plain = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    public string encrypted = "";
    public string decrypted = "";
    public int shiftkey = 3;
    public static void Main()
    {
        ProgramRunner runner = new ProgramRunner();

        //ENCRYPTING AND DECRYPTING

        Console.WriteLine($"Plain Text Message = {runner.plain}\n");

        runner.encrypted = Shifting.Encrypt(runner.plain, runner.shiftkey);
        Console.WriteLine($"Encrypted Text: {runner.encrypted}\n");

        runner.decrypted = Shifting.Decrypt(runner.encrypted, runner.shiftkey);
        Console.WriteLine($"Decrypted Text: {runner.decrypted}\n\n\n");

        //HASHING
        string source = runner.plain;

        using (SHA256 sha256Hash = SHA256.Create())
        {
            string plainhash = GetHash(sha256Hash, runner.plain);
            string decryptedhash = GetHash(sha256Hash, runner.decrypted);

            Console.WriteLine($"The SHA256 hash of plain text {runner.plain} is: \n{plainhash}.\n");
            Console.WriteLine($"The SHA256 hash of decrypted text {runner.plain} is: \n{decryptedhash}.\n\n");


            Console.WriteLine("Verifying the hash...");

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;


            if (comparer.Compare(plainhash, decryptedhash) == 0)
            {
                Console.WriteLine("The hashes are the same.");
            }
            else
            {
                Console.WriteLine("The hashes are not same.");
            }
        }
    }

    private static string GetHash(HashAlgorithm hashAlgorithm, string input)
    {

        // Convert the input string to a byte array and compute the hash.
        byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

        // Create a new Stringbuilder to collect the bytes
        // and create a string.
        var sBuilder = new StringBuilder();

        // Loop through each byte of the hashed data
        // and format each one as a hexadecimal string.
        for (int i = 0; i < data.Length; i++)
        {
            sBuilder.Append(data[i].ToString("x2"));
        }

        // Return the hexadecimal string.
        return sBuilder.ToString();
    }

    // Verify a hash against a string.
    private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
    {
        // Hash the input.
        var hashOfInput = GetHash(hashAlgorithm, input);

        // Create a StringComparer an compare the hashes.
        StringComparer comparer = StringComparer.OrdinalIgnoreCase;

        return comparer.Compare(hashOfInput, hash) == 0;
    }



}