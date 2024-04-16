namespace Kmakai.MemoryGame.Client.Models;

public class NormalGame
{
    public int Id { get; set; }
    public GameDifficulty GameDifficulty { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Duration { get; set; }
}

public class RaceGame
{
    public int Id { get; set; }
    public GameDifficulty GameDifficulty { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Duration { get; set; }
    
    public int Score { get; set; }
    public int TimeLimit { get; set; }
}

public class MovesGame
{
    public int Id { get; set; }
    public GameDifficulty GameDifficulty { get; set; }
    public DateTime Date { get; set; }
    public int score { get; set; }
    public int Moves { get; set; }
    public int MovesLimit { get; set; }
}
