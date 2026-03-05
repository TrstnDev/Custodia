using System;
using Custodia.Core;

namespace Custodia.Terminal;

public class ChatbotEngine
{
    // Pass the UIManager into the engine so it can use custom visual methods
    private readonly UIManager _ui;
    private string _userName = string.Empty;

    public ChatbotEngine(UIManager ui)
    {
        _ui = ui;
    }

    /// <summary>
    /// Initiates the primary sequence, asks for user's name, and starts the loop
    /// </summary>
    public void Start()
    {
        _ui.PrintHeader("User Authentication");
        _ui.TypeLine("Please enter your Name:");

        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("> ");
        _userName = Console.ReadLine()?.Trim() ?? string.Empty;
        
        // Input Validation: Ensures the user does not just hit 'Enter'
        while (string.IsNullOrEmpty(_userName))
        {
            _ui.PrintWarning("Designation cannot be empty. Please enter a valid name:");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("> ");
            _userName = Console.ReadLine()?.Trim() ?? string.Empty;
        }
        
        _ui.PrintHeader("Secure Connection Established");
        _ui.TypeLine($"Welcome, {_userName}. I am Custodia, your Cybersecurity awareness assistant.");
        _ui.TypeLine("I can help you identify phishing, manage passwords, and browse safely.");
        _ui.TypeLine("What would you like to know today? (Type 'exit' to disconnect)");

        RunMainLoop();
    }

    /// <summary>
    /// The continuous conversation loop that processes user queries.
    /// </summary>
    public void RunMainLoop()
    {
        bool isConnected = true;

        while (isConnected)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"\n[{_userName}] > ");
            string input = Console.ReadLine()?.Trim() ?? string.Empty;
            
            // Input validation for empty entries
            if (string.IsNullOrEmpty(input))
            {
                _ui.PrintWarning("I didn't catch that. Could you please rephrase or ask a question?");
                continue;
            }
            
            // Exit condition
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                _ui.TypeLine($"Terminating secure session. Stay safe online, {_userName}. Goodbye!");
                isConnected = false;
                continue;
            }
            
            // TODO: Connect knowledge base/response dictionary here
            _ui.TypeLine($"[Processing query regarding: '{input}']");
            _ui.TypeLine(CyberKnowledgeBase.GetResponse(input));
        }
    }
}