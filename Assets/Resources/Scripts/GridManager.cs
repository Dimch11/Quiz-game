using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GridManager : MonoBehaviour
{
    public GameObject CellPrefab;

    public List<GameObject> Cells { get; private set; } = new List<GameObject>();

    public const int WIDTH_IN_CELLS = 3;

    public void ShowCards(List<Card> cards, Card card, UnityAction nextLevel)
    {
        BuildGrid(cards.Count / WIDTH_IN_CELLS, WIDTH_IN_CELLS);

        for (int i = 0; i < cards.Count; i++)
        {
            // Add sprite to cell image
            Cells[i].transform.GetChild(0).GetComponent<SpriteRenderer>().sprite =
                Array.Find(Resources.LoadAll<Sprite>(cards[i].SpriteSheetPath),
                spr => spr.name == cards[i].NameInSpriteSheet);

            // Add corresponding card object to cell class
            Cells[i].GetComponent<Cell>().CellCard = cards[i];


            // Add corresponding animations and transition to next level when selected right card
            if (cards[i] == card)
            {
                Cells[i].GetComponent<Cell>().CellClicked.AddListener
                    (Cells[i].transform.GetChild(0).GetComponent<CellImage>().Bounce);
                Cells[i].transform.GetChild(0).GetComponent<CellImage>().NextLevel = nextLevel;
            }
            else
            {
                Cells[i].GetComponent<Cell>().CellClicked.AddListener
                    (Cells[i].transform.GetChild(0).GetComponent<CellImage>().EaseInBounce);
            }
        }
    }

    public void Clear()
    {
        foreach (var cell in Cells)
        {
            Destroy(cell);
        }
        Cells.Clear();
    }

    private void BuildGrid(int height, int width)
    {
        var cellSize = CellPrefab.GetComponent<Renderer>().bounds.size.x;

        var startPosX = cellSize * (width - 1) * -0.5f;
        var startPosY = cellSize * (height - 1) * 0.5f;

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                var newCell = Instantiate(CellPrefab);
                newCell.transform.SetParent(transform);
                newCell.transform.localPosition = new Vector3
                    (startPosX + cellSize * j, startPosY - cellSize * i, 0);
                Cells.Add(newCell);
            }
        }
    }
}
