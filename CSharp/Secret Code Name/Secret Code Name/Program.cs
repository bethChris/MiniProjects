// create a program that will ask the user for their name and age
// then encrypt the name and age 
// then display the user's secret code name that is the encrypted name and age 
// ask the user to enter in their secret code name
// then decrypt the secret code name and display the user's name and age

// create a class called Encryptor
// create a method called encrypt that will take in a name and age and encrypt it and return the value
// create a method called decrypt that will take in a secret code name and decrypt it and return the value

using System; 

namespace SecretCodeName
{
    class Encryptor
    {
        private readonly string key = "minecon";
        private readonly string lowercase = "abcdefghijklmnopqrstuvwxyz";
        private readonly string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string Encrypt(string name) 
        {
            string codeName = "";
            int index = 0;
            foreach (char c in name)
            {
                char keyValue = key[index++%key.Length];
                int keyIndex = lowercase.IndexOf(Char.ToLower(keyValue));

                if (char.IsUpper(c))
                {
                    string shiftedAlpha = uppercase.Substring(keyIndex, uppercase.Length - keyIndex) + uppercase.Substring(0, keyIndex);
                    
                    //how many away from start of normal alphabet
                    int charValue = (c - 'A') %26;

                    //corresponding char in shifted alphabet
                    codeName += shiftedAlpha[charValue];

                }
                else if (char.IsLower(c))
                {
                    string shiftedAlpha = lowercase.Substring(keyIndex, lowercase.Length - keyIndex) + lowercase.Substring(0, keyIndex);

                    //how many away from start of normal alphabet
                    int charValue = (c - 'a') % 26;

                    //corresponding char in shifted alphabet
                    codeName += shiftedAlpha[charValue];
                }
                else
                {
                    codeName += c;
                }
                
            }
            return codeName;
        }

        public string Decrypt(string codeName)
        {
            string oldName = "";
            int index = 0;
            foreach (char c in codeName)
            {
                char keyValue = key[index++ % key.Length];
                int keyIndex = lowercase.IndexOf(Char.ToLower(keyValue));

                if (char.IsUpper(c))
                {
                    string shiftedAlpha = uppercase.Substring(keyIndex, uppercase.Length - keyIndex) + uppercase.Substring(0, keyIndex);

                    //how many away from start of shifted alphabet
                    int shiftedValue = shiftedAlpha.IndexOf(c);

                    //corresponding char in normal alphabet
                    oldName += uppercase[shiftedValue];

                }
                else if (char.IsLower(c))
                {
                    string shiftedAlpha = lowercase.Substring(keyIndex, lowercase.Length - keyIndex) + lowercase.Substring(0, keyIndex);

                    //how many away from start of shifted alphabet
                    int shiftedValue = shiftedAlpha.IndexOf(c);

                    //corresponding char in normal alphabet
                    oldName += lowercase[shiftedValue];
                }
                else
                {
                    oldName += c;
                }
            }
            return oldName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Encryptor encryptor = new Encryptor();

            // Type the message and press enter
            Console.WriteLine("Enter Message to Encrypt:");

            // Create a string variable and get user input from the keyboard and store it in the variable

            string message = null;
            while (message ==  null)
            {
                message = Console.ReadLine();
            }
           
            Console.WriteLine(encryptor.Encrypt(message));



            Console.WriteLine("\nEnter Message to Decrypt:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            message = null;
            while (message == null)
            {
                message = Console.ReadLine();
            }

            Console.WriteLine(encryptor.Decrypt(message));

        }
    }

}
