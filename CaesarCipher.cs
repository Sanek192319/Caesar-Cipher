using System;

class CaesarCipher
{
    static string Encrypt(string text, int shift)
    {
        char[] buffer = text.ToCharArray();
        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                buffer[i] = (char)(((letter + shift - offset) % 26) + offset);
            }
        }
        return new string(buffer);
    }

    static string Decrypt(string text, int shift)
    {
        return Encrypt(text, 26 - shift); // Обратный сдвиг
    }

    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        Console.Write("Enter shift: ");
        int shift = int.Parse(Console.ReadLine());

        string encrypted = Encrypt(input, shift);
        Console.WriteLine($"Encrypted: {encrypted}");

        string decrypted = Decrypt(encrypted, shift);
        Console.WriteLine($"Decrypted: {decrypted}");
    }
}
