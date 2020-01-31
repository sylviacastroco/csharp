using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
        
      // Story begins
      Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
        
     Console.WriteLine("Type YES or NO");    
     string noiseChoice = Console.ReadLine();
     noiseChoice = noiseChoice.ToUpper();
      if(noiseChoice == "NO"){
        Console.WriteLine("Not much of an adventure if we don\'t leave our room! \nTHE END.");
        System.Environment.Exit(1);
      } else if (noiseChoice == "YES") {
        Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall. You walk towards it. Do you open it or knock?");
      } 
        
      Console.WriteLine("Type OPEN or KNOCK");
      string doorChoice = Console.ReadLine();
      doorChoice = doorChoice.ToUpper();     
      if(doorChoice == "KNOCK"){
        Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle:\" \"Poor people have it. Rich people need it. If you eat it you die. What is it?\" ");
        Console.WriteLine("Type your answer: ");
        string riddleAnswer = Console.ReadLine();
        riddleAnswer = riddleAnswer.ToUpper();
        if(riddleAnswer == "NOTHING"){
          Console.WriteLine("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. \nTHE END.");
        } else {
          Console.WriteLine("You answered incorrectly. The door doesn't open. \nTHE END.");
        }
      } else if(doorChoice == "OPEN"){
        Console.WriteLine("The door is locked! See if one of your three keys will open it.");
        Console.WriteLine("Enter a number (1-3): ");
        string keyChoice = Console.ReadLine();
        keyChoice = keyChoice.ToUpper();
        
        switch(keyChoice){
          case "1":
            Console.WriteLine("You choose the first key. Lucky choice! \nThe door opens and NOTHING is there. \nStrange...\nTHE END.");
            break;
          case "2":
            Console.WriteLine("You choose the second key. The door doesn't open.\nTHE END.");
            break;
          case "3":
            Console.WriteLine("You choose the third key. The door doesn't open. \nTHE END.");
            break;
          default:
            break;
        }
      }
    }
  }
}
