using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Transform transform;
    void Start()
    {
        transform = GetComponent<Transform>();
        transform.DORotate(new Vector3(0f, 0f, -5f), 3f)
            .SetLoops(-1, LoopType.Yoyo)
            .SetEase(Ease.Flash);

    }

   
}
