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
        transform.DOLocalRotate(new Vector3(0, 0, 5f), 2f, RotateMode.LocalAxisAdd)
            .SetEase(Ease.InOutSine)
            .SetLoops(-1, LoopType.Yoyo);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
