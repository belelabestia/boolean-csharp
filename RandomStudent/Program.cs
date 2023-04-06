using static System.Console;

var students = File
    .ReadAllLines("data.txt")
    .Where(l => !l.StartsWith('#'))
    .ToArray();

var picker = new Picker(students);

WriteLine(picker.Pick());