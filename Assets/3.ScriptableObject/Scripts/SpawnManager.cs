using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    public Transform SpawnPosition;
    private int index;
    public WaveConfig[] waveConfig;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    public IEnumerator Spawn()
    {
        while (index < waveConfig.Length)
        {
            Debug.Log("Spawn new wave");
            for (int i = 0; i < waveConfig[index].EnemyCount; i++)
            {
                SpawnEnemy(waveConfig[index].Enemy);
                yield return new WaitForSeconds(waveConfig[index].SpawnRate);
            }

            index++;
            yield return new WaitForSeconds(waveConfig[index].SpawnDelay);
        }
        Debug.Log("END");
    }
    

    void SpawnEnemy(GameObject enemy)
    {
       var e = Instantiate(enemy, SpawnPosition.position, Quaternion.identity);
       e.AddComponent<MoveEnemy>();
    }

}