using System;

namespace TaskManager.DataBase.Models
{
    public class UserEntity
    {
        public Guid id { get; private set; }
        public string name { get; private set; }
        public string lastName { get; private set; }
        public string email { get; private set; }
        public string password { get; private set; }

        public UserEntity(string name, string lastName, string email, string password)
        {
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
        }
    }
}
