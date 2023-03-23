using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
- void StampaVelocitaMassima() : mostra a video la velocità massima dell'auto
- void StampaNumeroPorte() : mostra a video il numero delle porte dell'auto
- String GetNome() : restituisce il nome dell'auto in modo che poi venga stampato nella classe Main
- void Accenditi() : stampa a video una frase che indica che l'auto si sta accendendo
- void Frena() : stampa a video una frase che indica che l'auto si sta spegnendo
 */

public abstract class Car
{
    protected string name;
    int doorCount;
    int maxSpeed;

    protected Car(string name, int doorCount, int maxSpeed)
    {
        this.name = name;
        this.doorCount = doorCount;
        this.maxSpeed = maxSpeed;
    }

    public abstract string GetName();
    public void PrintMaxSpeed() => Console.WriteLine(maxSpeed);
    public void PrintDoorCount() => Console.WriteLine(doorCount);
    public void TurnOn() => Console.WriteLine("Turning on...");
    public void TurnOff() => Console.WriteLine("Turning off...");
}
