// Operaciones.cs
public abstract class Operaciones
{
    public abstract double Suma(double num1, double num2);
    public abstract double Resta(double num1, double num2);
    public abstract double Multiplicacion(double num1, double num2);
    public abstract double Division(double num1, double num2);
    public abstract void Imprimir(string mensaje);
}

// Calculadora.cs
public class Calculadora : Operaciones
{
    private double _numero1;
    private double _numero2;

    public Calculadora(double numero1, double numero2)
    {
        _numero1 = numero1;
        _numero2 = numero2;
    }

    public override double Suma(double num1, double num2)
    {
        return num1 + num2;
    }

    public override double Resta(double num1, double num2)
    {
        return num1 - num2;
    }

    public override double Multiplicacion(double num1, double num2)
    {
        return num1 * num2;
    }

    public override double Division(double num1, double num2)
    {
        if (num2 == 0)
        {
            throw new DivideByZeroException("No se puede dividir entre cero");
        }
        return num1 / num2;
    }

    public override void Imprimir(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el primer número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Calculadora calculadora = new Calculadora(numero1, numero2);

        calculadora.Imprimir("Suma: " + calculadora.Suma(numero1, numero2));
        calculadora.Imprimir("Resta: " + calculadora.Resta(numero1, numero2));
        calculadora.Imprimir("Multiplicación: " + calculadora.Multiplicacion(numero1, numero2));
        calculadora.Imprimir("División: " + calculadora.Division(numero1, numero2));
    }
}