using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Somma di due numeri interi
Somma di due numeri double
Differenza tra due numeri interi
Differenza tra due numeri double
Moltiplicazione di due numeri interi
Moltiplicazione di due numeri double
Valore assoluto di un numero intero
Valore assoluto di un numero double
Minimo tra due numeri interi
Minimo tra due numeri double
Massimo tra due numeri interi
Massimo tra due numeri double
 */

public static class CalcoliHelper
{
    public static int Somma(int primo, int secondo) => primo + secondo;
    public static double Somma(double primo, double secondo) => primo + secondo;
    public static int Sottrai(int primo, int secondo) => primo - secondo;
    public static double Sottrai(double primo, double secondo) => primo - secondo;
    public static int Moltiplica(int primo, int secondo) => primo * secondo;
    public static double Moltiplica(double primo, double secondo) => primo * secondo;
    public static int ValoreAssoluto(int num) => num > 0 ? num : -num;
    public static double ValoreAssoluto(double num) => num > 0 ? num : -num;
    public static int Minimo(int primo, int secondo) => primo < secondo ? primo : secondo;
    public static double Minimo(double primo, double secondo) => primo < secondo ? primo : secondo;
    public static int Massimo(int primo, int secondo) => primo > secondo ? primo : secondo;
    public static double Massimo(double primo, double secondo) => primo > secondo ? primo : secondo;

    public static double? Potenza(double @base, double esponente)
    {
        if (esponente == 0) return 1;
        if (esponente < 0 && @base == 0) return null;
        if (@base == 0) return 0;
        if (@base == 1) return 1;

        double risultato = @base;
        
        for (int i = 1; i < ValoreAssoluto(esponente); i++)
        {
            risultato *= @base;
        }

        return esponente > 0 ? risultato : 1 / risultato;
    }
}
