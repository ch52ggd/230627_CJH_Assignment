using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour{
    [SerializeField ] private GameObject enemyPrefab;

    //List<Enemy> enemyList;

    List<GameObject> enemyPool = new List<GameObject>();

    private void Start()
    {
        //enemyList = new List<Enemy>();

        /*
        for(int i = 0; i < 10; i++)
        {
            GameObject obj = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity, this.transform);
            obj.transform.position = new Vector3(Random.Range(-3, 3), 10 + Random.Range(0, 5), 0);
            Enemy e = new Enemy(Enemy.EnemyType.Basic, Random.Range(5, 15), 10, Random.Range(1, 4));
            obj.GetComponent<EnemyObject>().SetEnemy(e);
        }
        */
    }


    // Update is called once per frame
    void Update()
    {
        if (enemyPool.Count != 10)
        {
            /*
            for (int i = 0; i < 10; i++)
            {
                GameObject obj = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity, this.transform);
                obj.transform.position = new Vector3(Random.Range(-3, 3), 10 + Random.Range(0, 5), 0);
                Enemy e = new Enemy(Enemy.EnemyType.Basic, Random.Range(5, 15), 10, Random.Range(1, 4));
                obj.GetComponent<EnemyObject>().SetEnemy(e);

                enemyPool.Add(obj);
            }
            */

            GameObject obj = Instantiate(enemyPrefab, Vector3.zero, Quaternion.identity, this.transform);
            obj.transform.position = new Vector3(Random.Range(-3, 3), 10 + Random.Range(0, 5), 0);
            Enemy e = new Enemy(Enemy.EnemyType.Basic, Random.Range(5, 15), 10, Random.Range(1, 4));
            obj.GetComponent<EnemyObject>().SetEnemy(e);

            enemyPool.Add(obj);

        }
        else
        {
            for (int i = 0; i < enemyPool.Count; i++)
            {
                if (enemyPool[i] == null)
                {
                    enemyPool.RemoveAt(i);
                }
            }
        }
    }
}
