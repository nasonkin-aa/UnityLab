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
        transform.DOMoveX(transform.position.x + 10, 3)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Linear);
    }
}


