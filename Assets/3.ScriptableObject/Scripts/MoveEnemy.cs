using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        player = FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,
            player.position,
             Time.deltaTime * 5f);
       
    }
}
