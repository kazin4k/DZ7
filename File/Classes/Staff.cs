using System;

namespace File.Classes
{
    public class Staff : Employee
    {
        public Staff(string name) : base(name, "Staff") { }

        public override bool CanTakeTask(Task task)
        {
            return string.Equals(task.AssignedTo, "staff", StringComparison.OrdinalIgnoreCase);
        }
    }
}
