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
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
