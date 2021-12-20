namespace calculator_cli
{
  public class Program
  {
    private string userInput = "";
    public static void Main(string[] args)
    {
      new Program().run();

    }

    private void run()
    {

      while (true)
      {
        Console.WriteLine("=== C# Calculator ===");
        Thread.Sleep(1000);
        Console.WriteLine("Digite 'quit' para sair do programa.");
        Console.WriteLine("Digite o primeiro número: ");
        userInput = Console.ReadLine();
        if (userInput.ToLower() == "quit")
        {
          break;
        }
        var numero = VerificaUserInput.VerificaInput(userInput);

        this.PegarNovoNumero(numero);
        double a = double.Parse(userInput);
        Console.WriteLine("Digite o segundo número: ");
        userInput = Console.ReadLine();
        if (userInput.ToLower() == "quit")
        {
          break;
        }
        numero = VerificaUserInput.VerificaInput(userInput);
        this.PegarNovoNumero(numero);
        double b = double.Parse(userInput);

        this.EscolherOperacao(a, b);


      }
    }

    private void EscolherOperacao(double a, double b)
    {
      Console.WriteLine("Escolha uma operação: ");
      Console.WriteLine("1 - Somar");
      Console.WriteLine("2 - Subtrair");
      Console.WriteLine("3 - Multiplicar");
      Console.WriteLine("4 - Dividir");
      var operacao = double.Parse(Console.ReadLine());
      switch (operacao)
      {
        case 1:
          Console.WriteLine(Calc.Somar(a, b));
          break;
        case 2:
          Console.WriteLine(Calc.Subtrair(a, b));
          Console.Clear();
          break;
        case 3:
          Console.WriteLine(Calc.Multiplicar(a, b));
          Console.Clear();
          break;
        case 4:
          Console.WriteLine(Calc.Dividir(a, b));
          Console.Clear();
          break;
        default:
          Console.WriteLine("Operação inválida.");
          break;
      }
    }

    private void PegarNovoNumero(int numero)
    {
      while (numero == -1)
      {
        Console.WriteLine("Digite um número válido: ");
        this.userInput = Console.ReadLine();
        if (this.userInput.ToLower() == "quit")
        {
          Environment.Exit(0);
        }
        numero = VerificaUserInput.VerificaInput(this.userInput);
      }
    }
  }
}

