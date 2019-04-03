using DotNetCoreArchitecture.Model;
using System;

namespace DotNetCoreArchitecture.Domain
{
    public class UserDomain
    {
        protected internal UserDomain(long userId)
        {
            UserId = userId;
        }

        protected internal UserDomain(SignIn signIn)
        {
            SignIn = signIn;
        }

        protected internal UserDomain(long userId, Roles roles)
        {
            UserId = userId;
            Roles = roles;
        }

        protected internal UserDomain
        (
            long userId,
            FullName fullName,
            string email,
            Roles roles
        )
        {
            UserId = userId;
            FullName = fullName;
            Email = email;
            Roles = roles;
        }

        protected internal UserDomain
        (
            long userId,
            FullName fullName,
            string email,
            SignIn signIn,
            Roles roles
        )
        {
            UserId = userId;
            FullName = fullName;
            Email = email;
            SignIn = signIn;
            Roles = roles;
        }

        public long UserId { get; private set; }

        public FullName FullName { get; private set; }

        public string Email { get; private set; }

        public SignIn SignIn { get; private set; }

        public Roles Roles { get; private set; }

        public Status Status { get; private set; }

        public void Add()
        {
            UserId = 0;
            Roles = Roles.User;
            Status = Status.Active;
        }

        public void Inactivate()
        {
            Status = Status.Inactive;
        }

        public void Update(UpdateUserModel updateUserModel)
        {
            FullName = new FullName(updateUserModel.Name, updateUserModel.Surname);
            Email = updateUserModel.Email;
        }
    }
}
