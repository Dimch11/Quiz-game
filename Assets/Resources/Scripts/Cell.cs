using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class Cell : MonoBehaviour, IBounce
{
    public UnityEvent CellClicked;
    public Card CellCard { get; set; }

    public void Bounce()
    {
        var normalScale = transform.localScale;
        transform.localScale = new Vector3(0, 0, 0);
        transform.DOScale(new Vector3(normalScale.x * 1.2f, normalScale.y * 1.2f), 0.3f).OnComplete(() =>
        {
            transform.DOScale(new Vector3(normalScale.x * 0.95f, normalScale.y * 0.95f), 0.3f).OnComplete(() =>
            {
                transform.DOScale(new Vector3(normalScale.x, normalScale.y), 0.3f);
            });
        });
    }

    void OnMouseDown()
    {
        CellClicked.Invoke();
    }

    void Awake()
    {
        var gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        gm.GameStarted.AddListener(Bounce);
    }
}
