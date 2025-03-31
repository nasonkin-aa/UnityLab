using UnityEngine;

public class TorchSwing : MonoBehaviour
{
    public float swingSpeed = 2f; // Скорость движения
    public float swingAmount = 10f; // Амплитуда (насколько сильно двигается)

    private Vector3 startPos;
    private float time;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        time += Time.deltaTime * swingSpeed;
        float offset = Mathf.Sin(time) * swingAmount;
        transform.localPosition = startPos + new Vector3(0, offset * 0.05f, 0); // Движение вверх-вниз
        transform.localRotation = Quaternion.Euler(0, 0, Mathf.Sin(time) * swingAmount); // Раскачивание
    }
}