using System.Linq;
using Unity.VisualScripting;
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
        var entity = FindObjectsOfType<Entity>();
        entity.Where(e => e.GetComponent<Enemy>()).ToList().ForEach(e =>SpawnArrow(e.transform) );

    }

 
   
    private void SpawnArrow(Transform enemy)
    {
        GameObject arrow = Instantiate(arrowPrefab, shootPoint.position, Quaternion.identity);
        Arrow arrowScript = arrow.GetComponent<Arrow>();
        arrowScript.SetTarget(enemy.transform);
    }
}