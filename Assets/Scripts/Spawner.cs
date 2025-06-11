using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject collectible;
    private float spawnRange = 10;
    [SerializeField] private GameObject[] spawnPoints;
    private int index;

    private void Start()
    {
        StartCoroutine(Spawnerr());
    }

    private IEnumerator Spawnerr()
    { 
        index = Random.Range(0, 3);
        Instantiate(collectible, spawnPoints[index].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5);
    }

    /*private Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 1, spawnPosZ);
        return randomPos;
    }*/

}
