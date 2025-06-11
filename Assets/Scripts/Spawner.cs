using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject collectible;
    private float spawnRange = 10;

    private IEnumerator Spawnerr()
    {
        //while (true)
        //{
        Instantiate(collectible, new Vector3(16,3,-11), collectible.transform.rotation);
            //Instantiate(collectible, GenerateSpawnPos(), Quaternion.identity);
        yield return new WaitForSeconds(1);
        //}
    }

    private Vector3 GenerateSpawnPos()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 1, spawnPosZ);
        return randomPos;
    }

}
