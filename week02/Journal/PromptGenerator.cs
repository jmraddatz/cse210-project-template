using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was your favorite part about today?",
        "How did you see God's hand today?",
        "What is an experience you had where you helped someone or someone helped you?",
        "What happened today that was unexpected?",
        "What is something new that you learned today?",
        "What challenege were you able to overcome today?"
    };


    public string GetRandomPrompt()
    {
        Random randomPrompt = new Random();
        int promptNumber = randomPrompt.Next(0, _prompts.Count);

        return _prompts[promptNumber];
    }
}