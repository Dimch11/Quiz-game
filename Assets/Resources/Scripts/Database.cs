using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Database
{
    public static List<Card> Cards { get; private set; }

    static Database()
    {
        Cards = new List<Card>
        {
            new Card("A", CardSet.Letters, "Sprites/Letters 1", "a"),
            new Card("B", CardSet.Letters, "Sprites/Letters 1", "b"),
            new Card("C", CardSet.Letters, "Sprites/Letters 1", "c"),
            new Card("D", CardSet.Letters, "Sprites/Letters 1", "d"),
            new Card("E", CardSet.Letters, "Sprites/Letters 1", "e"),
            new Card("F", CardSet.Letters, "Sprites/Letters 1", "f"),
            new Card("G", CardSet.Letters, "Sprites/Letters 1", "g"),
            new Card("H", CardSet.Letters, "Sprites/Letters 1", "h"),
            new Card("I", CardSet.Letters, "Sprites/Letters 1", "i"),
            new Card("J", CardSet.Letters, "Sprites/Letters 1", "j"),
            new Card("K", CardSet.Letters, "Sprites/Letters 1", "k"),
            new Card("L", CardSet.Letters, "Sprites/Letters 1", "l"),
            new Card("M", CardSet.Letters, "Sprites/Letters 1", "m"),
            new Card("N", CardSet.Letters, "Sprites/Letters 2", "n"),
            new Card("O", CardSet.Letters, "Sprites/Letters 2", "o"),
            new Card("P", CardSet.Letters, "Sprites/Letters 2", "p"),
            new Card("Q", CardSet.Letters, "Sprites/Letters 2", "q"),
            new Card("R", CardSet.Letters, "Sprites/Letters 2", "r"),
            new Card("S", CardSet.Letters, "Sprites/Letters 2", "s"),
            new Card("T", CardSet.Letters, "Sprites/Letters 2", "t"),
            new Card("U", CardSet.Letters, "Sprites/Letters 2", "u"),
            new Card("V", CardSet.Letters, "Sprites/Letters 2", "v"),
            new Card("W", CardSet.Letters, "Sprites/Letters 2", "w"),
            new Card("X", CardSet.Letters, "Sprites/Letters 2", "x"),
            new Card("Y", CardSet.Letters, "Sprites/Letters 3", "y"),
            new Card("Z", CardSet.Letters, "Sprites/Letters 3", "z"),

            new Card("One", CardSet.Numbers, "Sprites/Numbers", "1"),
            new Card("Two", CardSet.Numbers, "Sprites/Numbers", "2"),
            new Card("Three", CardSet.Numbers, "Sprites/Numbers", "3"),
            new Card("Four", CardSet.Numbers, "Sprites/Numbers", "4"),
            new Card("Five", CardSet.Numbers, "Sprites/Numbers", "5"),
            new Card("Six", CardSet.Numbers, "Sprites/Numbers", "6"),
            new Card("Seven", CardSet.Numbers, "Sprites/Numbers", "7"),
            new Card("Eight", CardSet.Numbers, "Sprites/Numbers", "8"),
            new Card("Nine", CardSet.Numbers, "Sprites/Numbers", "9"),
            new Card("Ten", CardSet.Numbers, "Sprites/Numbers", "10")
        };
    }

    
}
