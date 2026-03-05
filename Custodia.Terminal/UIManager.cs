using System;
using System.Threading;

namespace Custodia.Terminal;

public class UIManager
{
    /// <summary>
    /// Displays the Custodia ASCII art logo in colour
    /// </summary>
    public void DisplayLogo()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(@"
 $$$$$$\                        $$\                     $$\ $$\           
$$  __$$\                       $$ |                    $$ |\__|          
$$ /  \__|$$\   $$\  $$$$$$$\ $$$$$$\    $$$$$$\   $$$$$$$ |$$\  $$$$$$\  
$$ |      $$ |  $$ |$$  _____|\_$$  _|  $$  __$$\ $$  __$$ |$$ | \____$$\ 
$$ |      $$ |  $$ |\$$$$$$\    $$ |    $$ /  $$ |$$ /  $$ |$$ | $$$$$$$ |
$$ |  $$\ $$ |  $$ | \____$$\   $$ |$$\ $$ |  $$ |$$ |  $$ |$$ |$$  __$$ |
\$$$$$$  |\$$$$$$  |$$$$$$$  |  \$$$$  |\$$$$$$  |\$$$$$$$ |$$ |\$$$$$$$ |
 \______/  \______/ \_______/    \____/  \______/  \_______|\__| \_______|                                                                                                                              
                                          ");
        Console.ResetColor();
    }

    
    /// <summary>
    /// Prints a structured section header to separate conversation topics
    /// </summary>
    public void PrintHeader(string title)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(new string('=', 50));
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($" {title.ToUpper()} ");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine(new string('=', 50));
        Console.ResetColor();
    }


    /// <summary>
    /// Simulates a human typing effect by printing characters with a slight delay
    /// </summary>
    public void TypeLine(string message, int delayMs = 30)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Custodia > ");
        Console.ForegroundColor = ConsoleColor.Gray;

        foreach (char c in message)
        {
            Console.Write(c);
            Thread.Sleep(delayMs); // Pauses execution for a few milliseconds per character
        }
        Console.WriteLine();
        Console.ResetColor();
    }


    /// <summary>
    /// Formats error messages or invalid input warnings gracefully
    /// </summary>
    public void PrintWarning(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"[!] {message} [!]");
        Console.ResetColor();
    }
}