using System;

namespace File.Classes
{
    public class Task
    {
        public string Title { get; }
        public string AssignedTo { get; }

        public Task(string title, string assignedTo)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            AssignedTo = assignedTo ?? throw new ArgumentNullException(nameof(assignedTo));
        }
    }
}


