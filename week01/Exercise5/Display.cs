using System;

public class Display
{
    public void DisplayResult()
    {
       Username userrname = new Username();
       string naame = userrname.PromptUserName();

       Number numberObj = new Number();
       int number = numberObj.PromptUserNumber();

      Square square = new Square();
      int squared = square.GetSquare(number);

      Console.WriteLine($"Hello {naame}, the square of your number is {squared}"); 
    }
}