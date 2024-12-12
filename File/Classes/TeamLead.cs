using System;

namespace File.Classes
{
    public class TeamLead : Employee
    {
        public TeamLead(string name) : base(name, "Team Lead") { }

        public override bool CanTakeTask(Task task)
        {
            return true; 
        }
    }
}
