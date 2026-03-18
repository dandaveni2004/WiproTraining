using System;
using System.Security.Cryptography;
using System.Text;

namespace SecureUserApp
{
    public class User
    {
        public string Username { get; set; }
        public string HashedPassword { get; set; }

        public void Register(string username, string password)
        {
            try
            {
                Username = username;
                HashedPassword = HashPassword(password);
                Logger.Log("User registered successfully");
            }
            catch (Exception ex)
            {
                Logger.Log("Register Error: " + ex.Message);
                throw;
            }
        }

        public bool Authenticate(string username, string password)
        {
            try
            {
                string hashedInput = HashPassword(password);

                bool result = Username == username && HashedPassword == hashedInput;

                if (result)
                    Logger.Log("User login successful");
                else
                    Logger.Log("Login failed");

                return result;
            }
            catch (Exception ex)
            {
                Logger.Log("Authentication Error: " + ex.Message);
                throw;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
        }
    }
}