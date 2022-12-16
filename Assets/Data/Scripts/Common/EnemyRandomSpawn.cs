using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRandomSpawn : MonoBehaviour
{

    public GameObject[] enemies;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn()
    {
        int enemyIndex = Random.Range(0, enemies.Length);
        Instantiate(enemies[enemyIndex], transform.position,
            Quaternion.identity);
    }
}
