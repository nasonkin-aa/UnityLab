using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform shootPoint;
    public float shootInterval = 1f;

    private float shootTimer = 0f;

    void Update()
    {
        shootTimer += Time.deltaTime;
        if (shootTimer >= shootInterval)
        {
            ShootAtAllEnemies();
            shootTimer = 0f;
        }
    }

    void ShootAtAllEnemies()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();

        foreach (Enemy enemy in enemies)
        {
            GameObject arrow = Instantiate(arrowPrefab, shootPoint.position, Quaternion.identity);
            Arrow arrowScript = arrow.GetComponent<Arrow>();
            if (arrowScript != null)
            {
                arrowScript.SetTarget(enemy.transform);
            }
        }
    }
}