namespace Kmakai.MemoryGame.Client.Models;

public class CardList
{
    private static List<Card> CardsList = new List<Card>()
    {
        new Card { Image = "https://via.placeholder.com/150", Name = "one", IsFlipped = false, IsMatched = false },
        new Card { Image = "https://via.placeholder.com/150", Name = "two", IsFlipped = false, IsMatched = false },
        new Card { Image = "https://via.placeholder.com/150", Name = "three", IsFlipped = false, IsMatched = false },
        new Card { Image = "https://via.placeholder.com/150", Name = "four", IsFlipped = false, IsMatched = false },
        new Card { Image = "https://via.placeholder.com/150", Name = "five", IsFlipped = false, IsMatched = false },
        new Card { Image = "https://via.placeholder.com/150", Name = "6", IsFlipped = false, IsMatched = false },
        new Card { Image = "https://via.placeholder.com/150", Name = "7", IsFlipped = false, IsMatched = false },
        new Card { Image = "https://via.placeholder.com/150", Name = "8", IsFlipped = false, IsMatched = false },
        new Card { Image = "https://via.placeholder.com/150", Name = "9", IsFlipped = false, IsMatched = false },

    };

    public static List<Card> GetCards()
    {
        return CardsList.ToList();
    }

    public static List<Card> GetRandomCards(int n)
    {
        return CardsList.OrderBy(x => Guid.NewGuid()).Take(n).ToList();
    }


}
