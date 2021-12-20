namespace calculator_cli
{
  public static class VerificaUserInput
  {
    public static int VerificaInput(string input)
    {
      int numero = 0;
      try
      {
        double.Parse(input);
        numero = 1;
      }
      catch (System.Exception)
      {
        numero = -1;
      }
      return numero;
    }
  }
}