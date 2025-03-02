using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public Transform transform;
    void Start()
    {
        transform = GetComponent<Transform>();
        var tween = transform.DOMoveX(transform.position.x + 10, 2).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    
}
