using System;

namespace Custodia.Core;

public class CyberKnowledgeBase
{
    /// <summary>
    /// Analyses user input and returns the appropriate security response
    /// </summary>
    /// <param name="input">String input from the user.</param>
    /// <returns>Formatted response string.</returns>
    public string GetResponse(string input)
    {
        // Normalise the input to lowercase to make keyword matching easier
        string normalisedInput = input.ToLowerInvariant();
        
        //============================================ GREETINGS & PURPOSE =============================================
        if (normalisedInput.Contains("how are you"))
        {
            return "I'm doing great - ready to answer any questions you have about cybersecurity!";
        }

        if (normalisedInput.Contains("purpose") || normalisedInput.Contains("what are you") ||
            normalisedInput.Contains("who are you"))
        {
            return
                "I'm here to serve as your cybersecurity awareness assistant. I simulate real-life cyber threats and provide guidance on common pitfalls.";
        }

        if (normalisedInput.Contains("what can i ask") || normalisedInput.Contains("help") ||
            normalisedInput.Contains("topics"))
        {
            return
                "You can ask me about various cybersecuirty topics, including: \n- Password safety (e.g., 'How do I make a strong password?') \n- Phishing (e.g., 'What is a phishing email?') \n- Safe browsing (e.g., 'How do I know if a link is safe?')";
        }
        
        //========================================== CYBERSECURITY TOPICS ==============================================
        if (normalisedInput.Contains("password"))
        {
            return
                "[SECURITY TIP - PASSWORDS]: A strong password should be at least 12 characters long, mixing uppercase, lowercase, numbers, and special characters. Avoid using personal information, and never reuse passwords across different accounts. Consider using a password manager!";
        }

        if (normalisedInput.Contains("phishing") || normalisedInput.Contains("email"))
        {
            return
                "[SECURITY TIP - PHISHING]: Phishing is a cyber attack where scammers try to trick you into revealing sensitive information. Always check the sender's actual email address, watch out for urgent or threatening language, and never click links or download attachments from unknown sources.";
        }

        if (normalisedInput.Contains("link") || normalisedInput.Contains("browsing") ||
            normalisedInput.Contains("website"))
        {
            return
                "[SECURITY TIP - SAFE BROWSING]: Before clicking a link, hover over it to see the actual URL. Ensure the website uses 'https://' (look for a padlock icon). Be extremely cautious of shortened URLs or links sent via unsolicited messages.";
        }
        
        //========================================== DEFAULT FALLBACK ==================================================
        return
            "I didn't quite understand that. Could you rephrase your question? Try asking me about passwords, phishing, or safe browsing.";
    }
}