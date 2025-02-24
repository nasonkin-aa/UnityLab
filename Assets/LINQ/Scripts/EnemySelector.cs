using System;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySelector : MonoBehaviour
{
    private Entity[] _entities; 
    private void Start()
    {
        _entities = FindObjectsOfType<Entity>();
    }

    public void PaintAll()
    {
    }


    public void PaintRed(SpriteRenderer spriteRenderer) =>  spriteRenderer.color = Color.red;
    public void ResetColor(SpriteRenderer spriteRenderer) => spriteRenderer.color = Color.white; 
      
}