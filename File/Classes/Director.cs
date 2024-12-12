using System;

namespace File.Classes
{
    public class Director : Employee
    {
        public Director(string name) : base(name, "Director") { }

        public override bool CanTakeTask(Task task)
        {
            return true;
        }
    }
}

