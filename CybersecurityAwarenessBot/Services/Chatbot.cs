using CybersecurityAwarenessBot.Models;

namespace CybersecurityAwarenessBot.Services;

public class Chatbot
{
    private readonly UserProfile user;

    public Chatbot(UserProfile user)
    {
        this.user = user;
    }

    public string GetResponse(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return "I didn't receive anything. Please enter a question.";
        }

        string question = input.Trim().ToLower();

        if (question.Contains("how are you"))
        {
            return $"I'm doing well, {user.Name}. Thanks for asking!";
        }

        if (question.Contains("purpose") ||
            question.Contains("what do you do"))
        {
            return "My purpose is to help you learn basic cybersecurity awareness.";
        }

        if (question.Contains("what can i ask") ||
            question.Contains("what can i ask about"))
        {
            return "You can ask me about passwords, phishing, safe browsing, suspicious links and malware.";
        }

        if (question.Contains("password"))
        {
            return "Use a long and unique password for each account. Avoid using easy-to-guess information and consider using a password manager.";
        }

        if (question.Contains("phishing"))
        {
            return "Phishing is a scam where criminals try to trick you into giving away information. Be careful with unexpected messages, links and attachments.";
        }

        if (question.Contains("safe browsing") ||
            question.Contains("browse safely") ||
            question.Contains("browsing"))
        {
            return "For safer browsing, check website addresses carefully, avoid suspicious downloads and keep your browser and security software updated.";
        }

        if (question.Contains("suspicious link") ||
            question.Contains("suspicious links") ||
            question.Contains("link"))
        {
            return "Do not click suspicious links. Check the sender and website address first, and when in doubt, visit the official website directly.";
        }

        if (question.Contains("malware") ||
            question.Contains("virus"))
        {
            return "Malware is malicious software that can damage devices or steal information. Keep your software updated and avoid downloading files from untrusted sources.";
        }

        if (question.Contains("thank"))
        {
            return "You're welcome! Stay safe online.";
        }

        if (question.Contains("bye") ||
            question.Contains("exit"))
        {
            return "Goodbye! Remember to stay alert online.";
        }

        return "I didn't quite understand that. Could you rephrase your question? You can ask about passwords, phishing or safe browsing.";
    }
}
