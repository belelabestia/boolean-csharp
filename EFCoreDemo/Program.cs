using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

using var context = new SchoolContext();

var student = new Student { Name = "Francesco" };

context.Students.Add(student);
context.SaveChanges();

Console.WriteLine("Recupero lista di Studenti");

var students = context.Students
    .Include(s => s.Courses ?? new List<Course>())
    .ThenInclude(c => c.Image)
    .Where(s => (s.Email ?? "").Length > 5)
    .OrderBy(s => s.Name)
    .ToList();

var s = students.First();

var coursesOfStudent = s.Courses?.ToList() ?? new List<Course>();

_ = students.Single(s => s.Id == 1);

student.Name = "Veronica";
context.SaveChanges();

context.Students.Remove(student);
context.SaveChanges();