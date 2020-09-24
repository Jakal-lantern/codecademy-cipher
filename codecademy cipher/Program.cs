using System;

namespace codecademy_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            string randList = "";   //Have to have '= ""' because otherwise intelisense thinks 'randList' will have no value at output

            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Enter a message: ");
            string message = Console.ReadLine();
            char[] messageArray = message.ToCharArray();
            char[] encryptedMessage = new char[messageArray.Length];

            for (int i = 0; i < messageArray.Length; i++)
            {
                int randNum = rand.Next(25); //Only 25 because of how many letters there are. No need to repeat
                randList = randList + randNum.ToString() + ",";

                char letter = messageArray[i];
                int index = Array.IndexOf(alphabet, letter);
                index = (index + randNum) % alphabet.Length;
                letter = alphabet[index];
                encryptedMessage[i] = letter;
            }

            string outputMessage = String.Join("", encryptedMessage);
            Console.WriteLine(outputMessage);
            Console.WriteLine(randList);
        }
    }
}
