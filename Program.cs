using EntityFramework_3.Models;
using EntityFramework_3.Repositories;

namespace EntityFramework_3;

public class Program
{
    static void Main(string[] args)
    {
        var unitOfWork = new UnitOfWork();

        Student student1 = new Student()
        {
            FirstName = "Niko",
            LastName = "Akremi",
            Id_Group = 4214
        };

        unitOfWork.StudentRepository.Add(student1);
        Console.WriteLine(student1.FirstName);
        unitOfWork.StudentRepository.Remove(student1);
        Console.WriteLine(student1.LastName);

        unitOfWork.Save();;
    }
}
