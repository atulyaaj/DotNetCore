using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;

namespace CodeFirst
{
    public class Program
    {
        static void Main(string[] args)
        {
            var context = new SchoolDbContext();
            var std = new Student()
            {
                StudentName = "Amit",
                Contact = 1234567891

            };

            context.students.Add(std);
            context.SaveChanges();
            Console.WriteLine("Added Successfully.....");
            Console.Read();

            var std1 = context.students.Find(3);
            context.Entry(std1).State = EntityState.Deleted;
            context.SaveChanges();
            Console.Read();

            Console.WriteLine("Atulya Added Code.......");

        }
    }
}
