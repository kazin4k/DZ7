using System;

namespace File.Classes
{
    public abstract class Employee
    {
        public string Name { get; }
        public string Role { get; }

        protected Employee(string name, string role)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Role = role ?? throw new ArgumentNullException(nameof(role));
        }

        public abstract bool CanTakeTask(Task task);
    }
}

