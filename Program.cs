using System.Runtime.CompilerServices;
using ConsoleText;
using static ConsoleText.ColorConsole;

Write("Console", ConsoleColor.Cyan, decoration: ConsoleDecoration.Italics);
WriteLine("Text", ConsoleColor.Yellow, decoration: ConsoleDecoration.Underline);
WriteLine();

{
    Write("This ");
    Write("application", ConsoleColor.Green);
    Write(" demonstrates the use of ");
    Write("color", ConsoleColor.DarkYellow);
    Write(" and ");
    Write("text", decoration: ConsoleDecoration.Underline);
    Write(" effects", decoration: ConsoleDecoration.Italics);
    Write(" using ");
    Write("console", ConsoleColor.Black, ConsoleColor.Yellow);
    Write(" ");
    Write("output", ConsoleColor.DarkRed, ConsoleColor.White);

    WriteLine(".");
}

