namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        const string AskForDate = "Introdueix el dia, mes i any (separado por /).";
        const string CorrectDate = "La data és correcta {0}/{1}/{2}";
        const string IncorrectDate = "El format no és correcte";

        int[] fecha;
        bool validatedResult;

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