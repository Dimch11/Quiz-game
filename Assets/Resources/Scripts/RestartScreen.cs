using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartScreen : MonoBehaviour, IFadeIn
{
    public void FadeIn()
    {
        var sr = GetComponent<SpriteRenderer>();

        sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, 0);

        sr.DOFade(0.8f, 1);
    }
}
