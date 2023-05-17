try
{
    Console.WriteLine("Conversión de temperatura en Grados Celsius");
    Console.Write("Ingrese el valor de la temperatura:");
    var celsius = double.Parse(Console.ReadLine());
    Console.WriteLine("1-Fahrenheit");
    Console.WriteLine("2-Reaumur");
    Console.WriteLine("3-Kelvin");
    Console.WriteLine("4-Rankine");
    Console.Write("Ingrese una opción:");
    var opcion = int.Parse(Console.ReadLine());
    if (ValidarOpcion(opcion))
    {
        var conversion = ConvertirTemperatura(celsius, opcion);
        var escalaConvertida = EscalaConvertida(opcion);
        Console.WriteLine($"{celsius} equivale a {conversion} grados {escalaConvertida}");
    }
    else
    {
        Console.WriteLine("Conversión seleccionada fuera del rango permitido");
    }

}
catch (Exception)
{

    Console.WriteLine("Temperatura u opción mal ingresada");
}
string EscalaConvertida(int opcion)
{
    switch (opcion)
    {
        case 1: return "fahrenheit";
        case 2: return "reaumur";
        case 3: return "kelvin";
        default: return "rankine";

    }
}

double ConvertirTemperatura(double celsius, int opcion)
{
    switch (opcion)
    {
        case 1: return ConvertirCelsiusFahrenheit(celsius);
        case 2: return ConvertirCelsiusReaumur(celsius);
        case 3: return ConvertirCelsiusKelvin(celsius);
        default: return ConvertirCelsiusRankine(celsius);
    }
}

double ConvertirCelsiusRankine(double celsius) => 1.8 * celsius + 491.67;

double ConvertirCelsiusKelvin(double celsius) => celsius + 273.15;

double ConvertirCelsiusReaumur(double celsius) => 0.8 * celsius;

double ConvertirCelsiusFahrenheit(double celsius) => 1.8 * celsius + 32;

bool ValidarOpcion(int opcion) => opcion >= 1 && opcion <= 4;