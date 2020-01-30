using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXZ";
      string lowercase = "abcdefghijklmnopqrstuvwxyz";
      string digits = "0123456789";
      string specialChars = "~!@#$%^&*_+";
      
      Console.Write("Please enter a password: ");
      string password = Console.ReadLine();
      Console.WriteLine(password);
      
      int score = 0;
      
      if (password.Length >= minLength)
      {
        score++;
      } 
      if (Tools.Contains(password, uppercase))
      {
        score++;
      } 
      if (Tools.Contains(password, lowercase))
      {
        score++;
      } 
      if (Tools.Contains(password, digits))
      {
        score++;
      } 
      if (Tools.Contains(password, specialChars))
      {
        score++;
      }
      Console.WriteLine(score);
    }
  }
}
