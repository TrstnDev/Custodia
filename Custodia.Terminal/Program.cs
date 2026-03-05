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
        
        // 4. Display initial System Boot visuals
        ui.DisplayLogo();
        ui.PrintHeader("System Initialisation");
        ui.TypeLine("System booted successfully. All security protocols active.");
        
        // 5. Instantiate and start chatbot engine
        // Pass 'ui' into engine so it can use typing and colour effects
        ChatbotEngine engine = new ChatbotEngine(ui);
        engine.Start();
    }
}