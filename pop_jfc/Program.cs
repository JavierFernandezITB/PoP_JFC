using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        const string AskForDate = "Introdueix el dia, mes i any (separado por /).";
        const string CorrectDate = "La data és correcta {0}/{1}/{2}";
        const string IncorrectDate = "El format no és correcte";
        const string MenuOptions = "A. Saltar\nB. Correr\nC. Agacharse\nD. Esconderse.";

        int[] fecha;
        bool validatedResult;

        Console.WriteLine(MenuOptions);
        DoAction(Console.ReadLine().ToLower());

        Console.WriteLine(AskForDate);
        fecha = ConvertToIntArray(Console.ReadLine().Split("/"));

        validatedResult = valida(fecha[0], fecha[1], fecha[2]);

        Console.WriteLine(validatedResult ? CorrectDate : IncorrectDate, fecha[0], fecha[1], fecha[2]);
    }

    public static int[] ConvertToIntArray(string[] strArray)
    {
        int[] intArr = new int[strArray.Length];
        for (int i = 0; i < strArray.Length; i++)
        {
            intArr[i] = Convert.ToInt32(strArray[i]);
        }
        return intArr;
    }

    public static void DoAction(string choice)
    {
        const string JumpAction = "Saltas.", RunAction = "Corres.", CrouchAction = "Te agachar.", HideAction = "Te escondes.", NoAction = "No haces nada.";
        switch (choice)
        {
            case "a": Console.WriteLine(JumpAction); break;
            case "b": Console.WriteLine(RunAction); break;
            case "c": Console.WriteLine(CrouchAction); break;
            case "d": Console.WriteLine(HideAction); break;
            default:
                Console.WriteLine(NoAction); break;
        }
    }

    public static bool valida(int day, int month, int year)
    {
        if ((day < 1 || day > 31) || (month < 1 || month > 12) )
            return false;

        int totalDaysMonth;

        if (month == 2)
        {
            if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
            {
                totalDaysMonth = 29;
            }
            else
            {
                totalDaysMonth = 28;
            }
        }
        else
        {
            totalDaysMonth = (month % 2 == 1 ? 31 : 30);
        }
        return (day <= totalDaysMonth);
    }
}