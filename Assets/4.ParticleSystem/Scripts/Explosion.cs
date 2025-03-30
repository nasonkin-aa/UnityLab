using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
   public ParticleSystem ps;
   public GameObject Tnt;


   private void OnCollisionEnter2D(Collision2D other)
   {
      Debug.Log(other.gameObject.name);
      GetComponent<Collider2D>().enabled = false;
      ps.Play();
      Tnt.SetActive(false);
      
   }




}
