using UnityEngine;

public class IdleAnimationY : MonoBehaviour
{
    public float scaleVariation = 0.1f; // Максимальное изменение размера по оси Y
    public float speed = 2.0f; // Скорость изменения размера

    private Vector3 originalScale;
    private float timer = 0f;

    void Start()
    {
        originalScale = transform.localScale; // Сохраняем оригинальный размер
    }

    void Update()
    {
        // Плавно изменяем размер только по оси Y с использованием синусоиды
        float variation = Mathf.Sin(timer) * scaleVariation;
        transform.localScale = new Vector3(originalScale.x, originalScale.y + variation, originalScale.z);

        timer += Time.deltaTime * speed; // Увеличиваем таймер
    }
}