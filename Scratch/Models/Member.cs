using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Scratch.Models
{
    /*Fluent Interface Example*/
    public interface IMember
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        List<string> Roles { get; set; }
        IMember AddToRole(string role);
        IMember Create();
    }

    public class Member : IMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Roles { get; set; }

        public Member()
        {
            this.Roles = new List<string>();
        }

        public Member(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Roles = new List<string>();
        }

        public IMember AddToRole(string role)
        {
            this.Roles.Add(role);
            return this;
        }

        public IMember Create()
        {
            foreach (var role in this.Roles)
            {

            }

            return this;
        }
    }
}
