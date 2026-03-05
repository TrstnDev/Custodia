using System;

namespace Custodia.Core;

public class CyberKnowledgeBase
{
    /// <summary>
    /// Analyses user input and returns the appropriate security response
    /// </summary>
    /// <param name="input">String input from the user.</param>
    /// <returns>Formatted response string.</returns>
    public static string GetResponse(string input)
    {
        // Normalise the input to lowercase to make keyword matching easier
        string normalisedInput = input.ToLowerInvariant();
        
        //============================================ GREETINGS & PURPOSE =============================================
        if (normalisedInput.Contains("how are you") || normalisedInput.Contains("hello") || 
            normalisedInput.Contains("hi"))
        {
            return "I'm doing great - ready to answer any questions you have about cybersecurity!";
        }

        if (normalisedInput.Contains("purpose") || normalisedInput.Contains("what are you") ||
            normalisedInput.Contains("who are you"))
        {
            return
                "I'm here to serve as your cybersecurity awareness assistant. " +
                "I simulate real-life cyber threats and provide guidance on common pitfalls.";
        }

        if (normalisedInput.Contains("what can i ask") || normalisedInput.Contains("help") ||
            normalisedInput.Contains("topics"))
        {
            return
                "You can ask me about various cybersecuirty topics, including:" +
                "\n\t   - Password safety (e.g., 'How do I make a strong password?')" +
                "\n\t   - Phishing (e.g., 'What is a phishing email?')" +
                "\n\t   - Safe browsing (e.g., 'How do I know if a link is safe?')";
        }
        
        //========================================== CYBERSECURITY TOPICS ==============================================
        if (normalisedInput.Contains("password"))
        {
            return
                "[SECURITY TIP - PASSWORDS]: A strong password should..." +
                "\n\t\t\t\t\t- Be at least 12 characters long" +
                "\n\t\t\t\t\t- Mix uppercase, lowercase, numbers, and special characters" +
                "\n\t\t\t\t\t- Not contain any personal information" +
                "\n\t\t\t\t\t- Never be reused across different accounts - consider using a password manager!";
        }

        if (normalisedInput.Contains("phishing") || normalisedInput.Contains("email") || 
            normalisedInput.Contains("scam") || normalisedInput.Contains("fishing"))
        {
            return
                "[SECURITY TIP - PHISHING]: Phishing is a cyber attack where scammers try to trick you into revealing sensitive information." +
                "\n\t\t\t\t\t- Always check the sender's actual email address" +
                "\n\t\t\t\t\t- Watch out for urgent or threatening language" +
                "\n\t\t\t\t\t- Never click links or download attachments from unknown sources.";
        }

        if (normalisedInput.Contains("link") || normalisedInput.Contains("browsing") ||
            normalisedInput.Contains("website") || normalisedInput.Contains("internet") || 
            normalisedInput.Contains("web") || normalisedInput.Contains("url"))
        {
            return
                "[SECURITY TIP - SAFE BROWSING]: Remember..." +
                "\n\t\t\t\t\t- Before clicking a link, hover over it to see the actual URL." +
                "\n\t\t\t\t\t- Ensure the website uses 'https://' (look for a padlock icon)." +
                "\n\t\t\t\t\t- Be extremely cautious of shortened URLs or links sent via unsolicited messages.";
        }
        
        //========================================== DEFAULT FALLBACK ==================================================
        return
            "I didn't quite understand that. Could you rephrase your question? Try asking me about passwords, phishing, or safe browsing.";
    }
}