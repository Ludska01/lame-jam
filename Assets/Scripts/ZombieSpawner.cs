using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> zombies;
    [SerializeField]
    private List<GameObject> big_zombies;

    [SerializeField]
    private float zombieSpawnRate = 5f;
    [SerializeField]
    private float bigZombieSpawnRate= 10f;
    private float gameTime;
    [SerializeField]
    private float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CSpawnZombies(timeToWait));
    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
    }

    void SpawnZombies(int quantityToSpawnZombie, int quantityToSpawnBigZombie){
        for (int i = 0; i < quantityToSpawnZombie; i++)
        {
            int rand = Random.Range(0, zombies.Count);
            Instantiate(zombies[rand], transform.position, Quaternion.identity);
        }

        for (int i = 0; i < quantityToSpawnBigZombie; i++)
        {
            int rand = Random.Range(0, big_zombies.Count);
            Instantiate(big_zombies[rand], transform.position, Quaternion.identity);
        }
        StartCoroutine(CSpawnZombies(timeToWait));
    }   

    IEnumerator CSpawnZombies(float timeToWait){
        yield return new WaitForSeconds(timeToWait);
        int quantityToSpawnZombie = (int) (gameTime / zombieSpawnRate);
        int quantityToSpawnBigZombie = (int) (gameTime / bigZombieSpawnRate);
        SpawnZombies(quantityToSpawnZombie, quantityToSpawnBigZombie);
    }
    
}
