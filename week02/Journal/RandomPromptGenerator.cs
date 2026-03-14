
using System.Collections.Generic;
using System.Dynamic;

public class RandomPromptGenerator
{

    public List<string> _prompts = new List<string>();

    public RandomPromptGenerator()
    {
        _prompts.Add("What is a small detail from today that you don't want to forget?");
        _prompts.Add("What was the most challenging 'unwritten rule' you encountered today?");
        _prompts.Add("Describe a moment today when you felt a strong emotion.");
        _prompts.Add("What is something you learned today that changed your perspective, even just a little?");
        _prompts.Add("If you could send a one-sentence message to yourself 10 years ago, what would it say?");
        _prompts.Add("Describe your favorite part of the day.");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}