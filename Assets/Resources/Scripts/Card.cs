using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardSet
{
    Numbers,
    Letters
} 

public class Card
{
    public string Text { get; private set; }
    public CardSet Type { get; private set; }
    public string SpriteSheetPath { get; private set; }
    public string NameInSpriteSheet { get; private set; }


    public Card(string name, CardSet type, string spriteSheetPath, string nameInSpriteSheet)
    {
        Text = name;
        Type = type;
        SpriteSheetPath = spriteSheetPath;
        NameInSpriteSheet = nameInSpriteSheet;
    }
}
