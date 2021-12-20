namespace calculator_cli
{
  public static class Calc
  {
    public static double Somar(double a, double b)
    {
      return a + b;
    }

    public static double Subtrair(double a, double b)
    {
      return a - b;
    }

    public static double Multiplicar(double a, double b)
    {
      return a * b;
    }

    public static double Dividir(double a, double b)
    {
      if (b == 0)
      {
        throw new System.DivideByZeroException();
      }
      return a / b;
    }
  }
}