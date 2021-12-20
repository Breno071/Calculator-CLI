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
        var numero = double.TryParse(userInput, out double num);
        while (numero == false)
        {
          Console.WriteLine("Digite um número válido: ");
          userInput = Console.ReadLine();
          numero = double.TryParse(userInput, out num);
        }

        double a = num;
        Console.WriteLine("Digite o segundo número: ");
        userInput = Console.ReadLine();
        if (userInput.ToLower() == "quit")
        {
          break;
        }
        numero = double.TryParse(userInput, out num);

        while (numero == false)
        {
          Console.WriteLine("Digite um número válido: ");
          userInput = Console.ReadLine();
          numero = double.TryParse(userInput, out num);
        }
        double b = num;

        this.EscolherOperacao(a, b);
      }
      Console.WriteLine("=== Fim do programa ===");
    }

    private void EscolherOperacao(double a, double b)
    {
      Console.WriteLine("Escolha uma operação: ");
      Console.WriteLine("1 - Somar");
      Console.WriteLine("2 - Subtrair");
      Console.WriteLine("3 - Multiplicar");
      Console.WriteLine("4 - Dividir");
      var operacao = double.TryParse(Console.ReadLine(), out double operacaoEscolhida);
      if (operacao)
      {
        switch (operacaoEscolhida)
        {
          case 1:
            Console.WriteLine("{0} + {1} = {2}", a, b, Calc.Somar(a, b));
            break;
          case 2:
            Console.WriteLine("{0} - {1} = {2}", a, b, Calc.Subtrair(a, b));
            break;
          case 3:
            Console.WriteLine("{0} * {1} = {2}", a, b, Calc.Multiplicar(a, b));
            break;
          case 4:
            Console.WriteLine("{0} / {1} = {2}", a, b, Calc.Dividir(a, b));
            break;
          default:
            Console.WriteLine("Operação inválida.");
            break;
        }
      }
      else
      {
        Console.WriteLine("Operação inválida.");
      }
    }
  }
}

