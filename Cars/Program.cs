var sportCar = new SportCar("Ferrari", 3, 356);
var utilityCar = new UtilityCar("Fiesta", 5, 160);

var cars = new List<Car>() { utilityCar, utilityCar };

sportCar.PrintMaxSpeed();
sportCar.TurnOn();
sportCar.TurnOff();
sportCar.PrintDoorCount();
sportCar.TurnOnTurbo();
Console.WriteLine(sportCar.GetName());

utilityCar.PrintMaxSpeed();
utilityCar.TurnOn();
utilityCar.TurnOff();
utilityCar.PrintDoorCount();
utilityCar.Tow();
Console.WriteLine(utilityCar.GetName());

foreach (var car in cars)
{
    car.PrintMaxSpeed();
    car.TurnOn();
    car.TurnOff();
    car.PrintDoorCount();

    if (car is SportCar sc) sc.TurnOnTurbo();
    if (car is UtilityCar uc) uc.Tow();
}