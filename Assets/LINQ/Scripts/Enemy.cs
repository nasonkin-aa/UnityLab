using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float flashDuration = 0.1f; // Время, на которое спрайт загорается красным
    public Color flashColor = Color.red; // Цвет, которым загорается спрайт
    private SpriteRenderer spriteRenderer;
    private Color originalColor;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
            originalColor = spriteRenderer.color;
    }
    private float health = 100f;

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
