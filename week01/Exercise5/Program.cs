using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome wellcome = new Welcome();
        wellcome.DisplayWelcome();

        Display disp = new Display();
        disp.DisplayResult();
    }
}