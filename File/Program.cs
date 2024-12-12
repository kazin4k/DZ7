using System;

namespace File.Classes
{
    class Program
    {
        static void Main()
        {
            Task task1 = new Task("Подготовить отчет", "сотрудник");
            Task task2 = new Task("Проверить код", "руководитель группы");
            Task task3 = new Task("Стратегическое планирование", "директор");

            Department department = new Department("Разработка");

            Staff staffMember = new Staff("Иван Петров");
            TeamLead teamLeadMember = new TeamLead("Анна Смирнова");
            Director directorMember = new Director("Алексей Иванов");

            department.AddEmployee(staffMember);
            department.AddEmployee(teamLeadMember);
            department.AddEmployee(directorMember);

            department.AssignTask(task1);
            department.AssignTask(task2);
            department.AssignTask(task3);
        }
    }
}
