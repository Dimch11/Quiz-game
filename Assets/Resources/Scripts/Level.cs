using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DifficultyLevel
{
    Easy = 3,
    Normal = 6,
    Hard = 9
}

public class Level
{
    public DifficultyLevel Difficulty { get; set; }
    public CardSet UsedCardSet { get; set; }


    // Level with random card set
    public Level(DifficultyLevel difficulty)
    {
        Difficulty = difficulty;
        var rndCardSetNumber = RandomSelector.Rnd.Next(0, Enum.GetNames(typeof(CardSet)).Length);
        UsedCardSet = (CardSet)rndCardSetNumber;
    }
}
