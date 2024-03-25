using System;
class Program
{
    static void Main()
    {
        Console.Write("Insira o número de horas de treinamento por dia: ");
        int horasPorDia = Convert.ToInt32(Console.ReadLine());

        int horasSemana = 0;
        int totalHoras = 0;
        int dias = 0;
        int semanas = 0;
        int meses = 0;

        while (totalHoras < 1000)
        {
            dias++;
            if (dias % 7 != 6 && dias % 7 != 0)
            {
                horasSemana += horasPorDia;
                totalHoras += horasPorDia;
            }

            if (dias % 7 == 0)
            {
                semanas++;
                horasSemana = 0;
            }
        }

        meses = (int)Math.Ceiling((double)semanas / 4.5);

        Console.WriteLine($"Seriam necessários {dias} dias, {semanas} semanas e {meses} meses para alcançar 1000 horas de treinamento.");
    }
}
