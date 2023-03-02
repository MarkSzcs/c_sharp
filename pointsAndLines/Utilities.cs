using System;

static class Utilities
{
    //a static class is eqvivalent of the singleton structure, in java and in general.
    //static classes do not have constructors
    public static void ColorfulWriteLine(string message, ConsoleColor color)
    {
        Console.ForegroungColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}