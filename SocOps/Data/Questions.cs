namespace SocOps.Data;

public static class Questions
{
    public const string FREE_SPACE = "FREE SPACE";

    public static readonly List<string> QuestionsList = new()
    {
        "has said 'it works on my machine' this month",
        "has more than 20 browser tabs open right now",
        "has debugged with Console.WriteLine or print",
        "has renamed a variable to make a bug disappear",
        "has merged code on a Friday and felt brave",
        "uses dark mode in at least one dev tool",
        "has copied from Stack Overflow today",
        "has reopened a ticket they thought was done",
        "has a keyboard shortcut they evangelize",
        "has written TODO: fix later and meant it",
        "has broken production (or staging) at least once",
        "has spent 30+ minutes on a missing semicolon or bracket",
        "has blamed caching before checking the code",
        "has celebrated removing more code than they added",
        "has used 'final_final_v2' in a file name",
        "has explained a bug with 'race condition maybe'",
        "has asked 'did you clear cache?' in chat",
        "has rebased and immediately doubted everything",
        "has used rubber duck debugging",
        "has fixed one bug and revealed two more",
        "has a favorite linter rule",
        "has been saved by git reflog or stash",
        "has pushed a commit with a typo in the message",
        "has read logs like tea leaves"
    };
}
