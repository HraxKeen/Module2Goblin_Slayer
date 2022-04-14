using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject swarmerPrefab;
    [SerializeField]
    private GameObject bigswarmerPrefab;

    [SerializeField]
    private float swarmerInterval = 3.5f;
    [SerializeField]
    private float bigSwarmerInterval = 10f;
    void Update()
    {
        
    }
    
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmerInterval, swarmerPrefab));
        StartCoroutine(spawnEnemy(bigSwarmerInterval, bigswarmerPrefab));
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3
        (Random.Range(-1f, 5), Random.Range(-1f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
