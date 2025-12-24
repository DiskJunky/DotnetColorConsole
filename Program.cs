using ConsoleText;
using static ConsoleText.ColorConsole;

WriteLine("Testing bold...", ConsoleColor.Yellow, ConsoleColor.DarkBlue, decoration: ConsoleDecoration.Bold);
WriteLine("Testing italics and fore/back colors...", ConsoleColor.DarkGreen, ConsoleColor.Gray, ConsoleDecoration.Italics);
WriteLine("Testing underline", ConsoleColor.White, decoration: ConsoleDecoration.Underline);
WriteLine("Testing stricken", ConsoleColor.Red, decoration: ConsoleDecoration.Strikethrough);
