using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public UnityEvent GameStarted;
    public UnityEvent LevelsCompleted;

    public GridManager Grid;
    public Text ExerciseText;
    public GameObject RestartButton;
    public GameObject RestartScreen;

    private List<Card> CardsBlackList = new List<Card>();
    private Queue<Level> levels;


    public void StartGame()
    {
        levels = new Queue<Level>();
        levels.Enqueue(new Level(DifficultyLevel.Easy));
        levels.Enqueue(new Level(DifficultyLevel.Normal));
        levels.Enqueue(new Level(DifficultyLevel.Hard));

        NextLevel();

        GameStarted.Invoke();
    }

    IEnumerator StartGameWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        StartGame();
    }

    public void NextLevel()
    {
        if (levels.Count > 0)
        {
            Grid.Clear();

            var curLevel = levels.Dequeue();

            // Find all cards with appropriate type
            var availableCards = Database.Cards.FindAll
                (card => card.Type == curLevel.UsedCardSet);

            // Select a few cards from approptiate ones to show to player
            var selectedCards = RandomSelector.SelectRandomCards
                (availableCards, (int)curLevel.Difficulty);

            // Select from them card we want player to find. It must not to be in black list (chosen before)
            var cardToFind = RandomSelector.SelectRandomCards
                (selectedCards.Except(CardsBlackList).ToList(), 1)[0];

            Grid.ShowCards(selectedCards, cardToFind, NextLevel);

            ExerciseText.text = "Find " + cardToFind.Text;

            CardsBlackList.Add(cardToFind);
        }
        else
        {
            ExerciseText.text = "";
            LevelsCompleted.Invoke();
        }
    }

    public void ShowRestartScreen()
    {
        RestartScreen.SetActive(true);
        RestartButton.SetActive(true);
    }
    public void HideRestartScreen()
    {
        RestartScreen.SetActive(false);
        RestartButton.SetActive(false);
    }

    void Start()
    {
        LevelsCompleted.AddListener(ShowRestartScreen);
        LevelsCompleted.AddListener(RestartScreen.GetComponent<RestartScreen>().FadeIn);
        StartCoroutine(StartGameWithDelay(1));
    }
}
