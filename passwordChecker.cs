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
      
      switch(score)
       { 
        case 4:
        case 5:
          Console.WriteLine("Your password is Extremely Strong!");
          break;
        case 3:
          Console.WriteLine("Your password is Strong!");
          break;
        case 2:
          Console.WriteLine("Your password is Medium!");
          break;
        case 1:
          Console.WriteLine("Your password is Weak!!!");
          break;
        default:
          Console.WriteLine("Password does not meet standards!!!");
          break;
       }
      }
    }
  }
