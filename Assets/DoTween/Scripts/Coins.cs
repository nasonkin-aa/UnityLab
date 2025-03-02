using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public Transform transform;
    public Tween tween;
    void Start()
    {
        transform = GetComponent<Transform>();
        tween = transform.DORotate(new Vector3(0f, 180f, 0f), 3f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutBounce);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        tween.Kill(true);
        Sequence sequence = DOTween.Sequence();
        
        sequence.Append(transform.DORotate(new Vector3(0f, 0f, 0f), 1f))
            .Join(transform.DOJump(transform.position + new Vector3(0,1f,0),1f,1,1))
            .Append(transform.DOLocalRotate( new Vector3(0, 0, 180), 0.3f).SetLoops(5, LoopType.Incremental).SetEase(Ease.Linear))
            .Join(transform.DOScale(new Vector3(0f,0f,0f), 2f));
        
        /*transform.DOJump(transform.position + new Vector3(0,1f,0)
            ,1f
            ,1
            ,1);*/
        //transform.DORotate(new Vector3(0f, 0f, 180f), 1f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.OutBounce);
    }
}
