using System;

namespace SecureUserApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user = new User();

                user.Register("ganesh", "1234");

                bool login = user.Authenticate("ganesh", "1234");

                Console.WriteLine("Login Success: " + login);

                string encrypted = EncryptionHelper.Encrypt("Sensitive Data");
                Console.WriteLine("Encrypted: " + encrypted);

                string decrypted = EncryptionHelper.Decrypt(encrypted);
                Console.WriteLine("Decrypted: " + decrypted);
            }
            catch
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}