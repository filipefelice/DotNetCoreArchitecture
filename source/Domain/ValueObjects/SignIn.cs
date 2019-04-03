namespace DotNetCoreArchitecture.Domain
{
    public sealed class SignIn
    {
        public SignIn(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public string Login { get; }

        public string Password { get; }
    }
}
