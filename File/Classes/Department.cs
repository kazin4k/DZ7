using System;
using System.Collections.Generic;

namespace File.Classes
{
    public class Department
    {
        public string Name { get; }
        private List<Employee> Employees { get; }

        public Department(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AssignTask(Task task)
        {
            foreach (var employee in Employees)
            {
                if (employee.CanTakeTask(task))
                {
                    Console.WriteLine($"{employee.Name} из отдела {Name} может взять задачу: {task.Title}");
                    return;
                }
            }
            Console.WriteLine($"Ни один сотрудник в отделе {Name} не может взять задачу: {task.Title}");
        }
    }
}
