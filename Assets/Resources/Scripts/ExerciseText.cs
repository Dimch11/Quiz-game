using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ExerciseText : MonoBehaviour, IFadeIn
{
    public void FadeIn()
    {
        var text = GetComponent<Text>();

        var normalAlpha = text.color.a;
        text.color = new Color(text.color.r, text.color.g, text.color.b, 0);

        text.DOFade(normalAlpha, 1);
    }

    void Awake()
    {
        var gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        gm.GameStarted.AddListener(FadeIn);
    }
}
