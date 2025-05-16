public class Prompt {
    public List<string> _prompts = new List<string>();

    public Prompt(){}

    public string GetRandomPrompt(){
        int num = _prompts.Count();
        Random random = new Random();

        int index = random.Next(0, num);
        return _prompts[index];
    }
}