using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public static WaveManager instance;

    public Level_UI level_UI;

    public List<EnnemiParent> enemis;

    public GameObject preSpawnCirle;
    public GameObject enemy;

    public int enemyToSpawn;

    public int actualWave;
    public int waveNbr;


    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void Start()
    {
        LoadNextWave();
    }

    public void LoadNextWave()
    {
        if (actualWave != waveNbr)
        {
            actualWave++;
        level_UI.UpdateUI();
        StartCoroutine(SpawnEnemies());
        }
    }

    public void Update()
    {
      
    }

    public IEnumerator SpawnEnemies()
    {
        do
        {
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(-15,15), Random.Range(-10,10));
            GameObject newPrespawnCircle = Instantiate(preSpawnCirle,RandomSpawnPosition,transform.rotation);
            yield return new WaitForSeconds(1f);
            Destroy(newPrespawnCircle);
            GameObject _enemy = Instantiate(enemy,RandomSpawnPosition, transform.rotation);
            enemyToSpawn--;
            yield return new WaitForSeconds(1f);
        } while (enemyToSpawn > 0);

        LoadNextWave();
        enemyToSpawn = 10;

        yield break;
    }
}
