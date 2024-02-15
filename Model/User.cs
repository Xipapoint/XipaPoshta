using System.Security.Cryptography;
using System;
using Xipa_Poshta.Utils;

namespace Xipa_Poshta.Model
{
    public class User
    {
        private long _id;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public required string Username { get; set; }

        public required string Password { get; set; }

        public required string Email { get; set; }

        public required DateTime BirthDate {  get; set; }

        public ulong PhoneNumber { get; set; }

        public string Avatar { get; set; } = string.Empty;

        public required ICollection<Role> Roles { get; set; } = new HashSet<Role>();

        public ICollection<Transaction>? Transactions { get; set; } = new List<Transaction>();


        private IdGenerator _idGenerator = new IdGenerator();



        public User()
        {
            Id = _idGenerator.TimestampIntGenerateId();
        }


    }
}
