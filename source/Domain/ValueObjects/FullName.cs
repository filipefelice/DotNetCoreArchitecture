namespace DotNetCoreArchitecture.Domain
{
    public sealed class FullName
    {
        public FullName(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; }

        public string Surname { get; }
    }
}
