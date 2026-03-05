using System;
using System.IO;

namespace Custodia.Terminal;

class Program
{
    static void Main(string[] args)
    {
        // 1. Build a cross-platform path to audio file
        // AppDomain.CurrentDomain.BaseDirectory ensures it looks in the exact folder where the compiled .exe/.dll is running
        string audioFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "greeting.wav");
        
        // 2. Instantiate the controllers
        AudioController audio = new AudioController();
        UIManager ui = new UIManager();
        
        // 3. Attempt to play greeting wav file
        audio.PlayGreeting(audioFilePath);
        
        // 4. Display the UI elements
        ui.DisplayLogo();
        ui.PrintHeader("System Initialisation");
        
        // 5. Test the typing effect
        ui.TypeLine("System booted successfully. All security protocols active.");
        ui.TypeLine("Connecting to user terminal...");
        
        // 6. Test warning format
        ui.PrintWarning("Awaiting user input sequence.");
        
        Console.ReadKey();
    }
}