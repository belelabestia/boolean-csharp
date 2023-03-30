using static System.Console;

var students = File.ReadAllLines("data.txt");
var picker = new Picker(students);

WriteLine(picker.Pick());