using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public float flashDuration = 0.1f; // Время, на которое спрайт загорается красным
    public Color flashColor = Color.red; // Цвет, которым загорается спрайт
    private SpriteRenderer spriteRenderer;
    private Color originalColor;
    public TMP_Text _tmpText;
    public float health = 100f;
    
    public enum EntityType
    {
        Ground,
        Air
    }

    public EntityType Type;

    private void FixedUpdate()
    {
        _tmpText.text = health.ToString();
    }

    private void Start()
    {
        _tmpText = GetComponentInChildren<TMP_Text>();
        _tmpText.text = health.ToString();
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
            originalColor = spriteRenderer.color;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
        else
        {
            OnHit();
        }
    }

    public void OnHit()
    {
        if (spriteRenderer != null)
        {
            StartCoroutine(Flash());
        }
    }

    private IEnumerator Flash()
    {
        spriteRenderer.color = flashColor;
        yield return new WaitForSeconds(flashDuration);

        spriteRenderer.color = originalColor;
    }

    public void Die()
    {
        transform.eulerAngles = new Vector3(0, 0, 90);
        Destroy(gameObject, 2f);
    }
}
