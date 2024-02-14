using System;

public class VoteMachine
{
    private static int _totalVotes = 0;

    static VoteMachine()
    {
    }

    public static void RegisterVote()
    {
        _totalVotes += 1;
        Console.WriteLine("Registered Vote #" + _totalVotes);
    }

    public static int TotalVotes
    {
        get
        {
            return _totalVotes;
        }
    }
}
