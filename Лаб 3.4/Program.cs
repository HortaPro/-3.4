//Миронова Анастасия 22-ИСП-2/1
//3.4 Вариант 4
//Уровень Сложный
try
{
    const double h = 0.1;

    for (double x = 1; x <= 2; x += h)
    {
        double sum = 0;
        var k = 1;
        while (true)
        {
            long factorial = 1;
            for (var n = 1; n <= 3 * k; n++) factorial *= n;
            var numerator = Math.Pow(-1, 3 * k) * Math.Pow(x, 3 * k);

            if (numerator == 0 || factorial == 0) break;
            sum += numerator / factorial;
            k++;
        }
        Console.WriteLine($"x = {x:F1}\nf(x) = {sum:F3}\n");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}