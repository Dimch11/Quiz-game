using System;
using System.Collections.Generic;
using System.Linq;

public static class RandomSelector
{
    public static Random Rnd = new Random();

    // Select "number" of random cards from list
    public static List<Card> SelectRandomCards(List<Card> cards, int number)
    {
        return cards.OrderBy(a => Rnd.Next()).ToList().GetRange(0, number);
    }
}
