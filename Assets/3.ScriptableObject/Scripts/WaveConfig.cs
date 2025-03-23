using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WaveConfig", menuName = "Config/ WaveConfig")]
public class WaveConfig : ScriptableObject
{
    public GameObject Enemy;
    public int EnemyCount;
    public float SpawnRate;
    public float SpawnDelay;
}
