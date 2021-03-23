using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Account
    {
        private readonly List<Role> roles;

        protected Account()
        {
            roles = new List<Role>();
        }

        public Account(string email, string password) : this()
        {
            Email = email;
            Password = password;
            IsActive = false;

            AddRole(new Role("User"));
        }

        public bool IsActive { get; protected set; }
        public string Email { get; protected set; }

        public string Password { get; protected set; }

        public IEnumerable<Role> Roles
        {
            get { return roles; }
        }

        public void AddRole(Role role)
        {
            if (roles.Contains(role))
                return;

            roles.Add(role);
        }
    }
}
