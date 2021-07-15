using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CellImage : MonoBehaviour, IBounce, IEaseInBounce
{
    public GameObject Effect;
    public UnityAction NextLevel { private get; set; }

    public void Bounce()
    {
        var normalScale = transform.localScale;
        transform.localScale = new Vector3(0, 0, 0);
        transform.DOScale(new Vector3(normalScale.x * 1.2f, normalScale.y * 1.2f), 0.3f).OnComplete(() =>
        {
            transform.DOScale(new Vector3(normalScale.x * 0.95f, normalScale.y * 0.95f), 0.3f).OnComplete(() =>
            {
                transform.DOScale(new Vector3(normalScale.x, normalScale.y), 0.3f).OnComplete(() => 
                {
                    NextLevel.Invoke();
                });
            });
        });
        var effect = Instantiate(Effect);
        effect.transform.position = transform.parent.position;
    }

    public void EaseInBounce()
    {
        transform.DOMoveX(transform.position.x + 0.1f, 0.8f).SetEase(Ease.InBounce).OnComplete(() =>
        {
            transform.DOMoveX(transform.position.x - 0.1f, 0.2f);
        });
    }
}
