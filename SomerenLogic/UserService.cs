using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using SomerenModel;
using SomerenDAL;

namespace SomerenLogic
{
    public class UserService
    {

        UserDao userdb = new UserDao();

        public UserService()
        {
            userdb = new UserDao();
        }

        public List<User> GetUsers()
        {
            List<User> users = userdb.GetAllUsers();
            return users;
        }

        public bool Login(string username, string password)
        {
            User user = userdb.userLogin(username, password);
            if (user.Username == username && user.Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void AddUser(User user)
        {
            /*
            PasswordWithSaltHasher saltyHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashedPassword = saltyHasher.HashWithSalt(user.Password, 64, SHA256.Create());
            user.Password = hashedPassword.Digest;
            user.Salt = hashedPassword.Salt;
            */
            userdb.AddUser(user);
        }

        public void EditPassword(string userName, string password)
        {
            userdb.EditPassword(userName, password);
        }

        public void ForgotPassword(string userName, string password)
        {
            userdb.ForgotPassword(userName, password);
        }
    }

    public class HashWithSaltResult
    {
        public string Salt { get; }
        public string Digest { get; set; }

        public HashWithSaltResult(string salt, string digest)
        {
            Salt = salt;
            Digest = digest;
        }
    }

    public class RNG
    {
        public string GenerateRandomCryptographicKey(int keyLength)
        {
            return Convert.ToBase64String(GenerateRandomCryptographicBytes(keyLength));
        }

        public byte[] GenerateRandomCryptographicBytes(int keyLength)
        {
            RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] randomBytes = new byte[keyLength];
            rngCryptoServiceProvider.GetBytes(randomBytes);
            return randomBytes;
        }

    }

    public class PasswordWithSaltHasher
    {
        public HashWithSaltResult HashWithSalt(string password, int saltLength, HashAlgorithm hashAlgo)
        {
            RNG rng = new RNG();
            byte[] saltBytes = rng.GenerateRandomCryptographicBytes(saltLength);
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltBytes), Convert.ToBase64String(digestBytes));
        }

        public HashWithSaltResult SaltedHashInput(string input, string salt, HashAlgorithm hashAlgo)
        {
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(input);
            byte[] saltAsBytes = Convert.FromBase64String(salt);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltAsBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return new HashWithSaltResult(Convert.ToBase64String(saltAsBytes), Convert.ToBase64String(digestBytes));
        }
    }

}
