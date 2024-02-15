using System.Text;
using System.Security.Cryptography;

namespace Xipa_Poshta.Utils
{
    public class IdGenerator
    {

        /* BLOCK OF PUBLIC SERVICES*/
        public long TimestampIntGenerateId()
        {
            string timestamp = DateTime.Now.ToString("yyMMddmm");
            string randomChars = GenerateRandomNumber(5);
            return long.Parse(timestamp + randomChars);
        }


        public ushort SHA16bitGenerateId()
        {
            string randomString = GenerateRandomString(6);
            return ParseStringToNum16Bit(randomString);
        }

        public uint SHA32bitGenerateId()
        {
            string randomString = GenerateRandomString(6);
            return ParseStringToNum32Bit(randomString);
        }



        /* BLOCK OF PRIVATE SERVICES */
        private string GenerateRandomNumber(int length)
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string GenerateRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPRSTEQZXVY0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        //Converting a string to a number to get access to service/entity etc.
        private ushort ParseStringToNum16Bit(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                ushort numericValue = BitConverter.ToUInt16(bytes, 0);
                return numericValue;
            }
        }

        private uint ParseStringToNum32Bit(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                uint numericValue = BitConverter.ToUInt32(bytes, 0);
                return numericValue;
            }
        }



    }
}
