using System;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 5f;
    public int Damage = 40;
    private Transform target;

    public void SetTarget(Transform enemy)
    {
        if (enemy != null)
        {
            target = enemy;
            Vector2 direction = (enemy.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Entity>())
        {
            other.GetComponent<Entity>().TakeDamage(Damage);
            Destroy(gameObject);
            
        }
    }
}