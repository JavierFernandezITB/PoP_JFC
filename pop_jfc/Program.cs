using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
namespace PoPRefactoring;

public class PopProject {
    public static void Main(string[] args) {
        int dia;
        int mes;
        int any;
        bool validat;
        Console.WriteLine("Introdueix el dia, mes i any");
        validat = valida(dia, mes, any);
        Console.WriteLine("El format no és correcte");
        Console.WriteLine("La data és correcta {1}", validat);
    }

    public static bool valida(int day, int month, int year)
    {

        if (day < 1 || day > 31)

            return false;

        if (month < 1 || month > 12)

            return false;

        // determinem la quantitat de dies del mes:

        int totalDaysMonth = 0;

        switch (month)
        {

            case 1:

            case 3:

            case 5:

            case 7:

            case 8:

            case 10:

            case 12: totalDaysMonth = 31; break;

            case 4:

            case 6:

            case 9:

            case 11: totalDaysMonth = 30; break;

            case 2: // verifica l'any de traspàs

                if ((year % 400 == 0) ||

                ((year % 4 == 0) && (year % 100 != 0)))
                    totalDaysMonth = 29;

                else totalDaysMonth = 28;

                break;

        }

        if (day > totalDaysMonth)

            return false;

        else return true;

    }
}