public class Picker
{
    Random random = new();
    string[] students;

    public Picker(string[] students)
    {
        this.students = students;
    }

    public int Count => students.Length;

    public string Pick()
    {
        var index = random.Next(0, students.Length);
        return students[index];
    }
}