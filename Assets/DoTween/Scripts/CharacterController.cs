using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Публичные переменные для настройки
    public float moveSpeed = 5f; // Скорость движения персонажа
    public float jumpForce = 10f; // Сила прыжка
    public LayerMask groundLayer; // Слой, который считается "землей"

    // Приватные переменные
    private Rigidbody2D rb;
    private bool isGrounded; // Флаг для проверки, находится ли персонаж на земле
    private const float skinWidth = 1f; // Толщина для проверки земли

    void Start()
    {
        // Получаем компонент Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Вызываем методы для движения и прыжка
        Move();
        Jump();
    }

    void Move()
    {
        // Получаем горизонтальный ввод (A/D или стрелки влево/вправо)
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        // Двигаем персонажа по горизонтали
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
    }

    void Jump()
    {
        // Проверяем, находится ли персонаж на земле
        isGrounded = IsGrounded();

        // Если персонаж на земле и нажата клавиша Space, выполняем прыжок
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce); // Придаём вертикальную скорость
        }
    }

    bool IsGrounded()
    {
        // Создаём точку под персонажем для проверки контакта с землёй
        Vector2 groundCheckPoint = (Vector2)transform.position - new Vector2(0, skinWidth);

        // Проверяем, есть ли коллайдер на слое "groundLayer" в радиусе skinWidth от точки
        return Physics2D.OverlapCircle(groundCheckPoint, skinWidth, groundLayer);
    }

    void OnDrawGizmos()
    {
        // Визуализация точки проверки земли в редакторе Unity
        Gizmos.color = Color.red;
        Vector2 groundCheckPoint = (Vector2)transform.position - new Vector2(0, skinWidth);
        Gizmos.DrawWireSphere(groundCheckPoint, skinWidth);
    }
}
