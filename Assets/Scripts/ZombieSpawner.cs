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
    [SerializeField]
    private GameObject startPoint;
    [SerializeField]
    private GameObject endPoint;
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
        float startX = startPoint.transform.position.x;
        float endX = endPoint.transform.position.x;
        float startY = startPoint.transform.position.y;
        float endY = endPoint.transform.position.y;
       

        for (int i = 0; i < quantityToSpawnZombie; i++)
        {
            Vector2 spawnLine = new Vector2(Random.Range(startX, endX), Random.Range(startY, endY));
            int rand = Random.Range(0, zombies.Count);
            Instantiate(zombies[rand], spawnLine , Quaternion.identity);
        }

        for (int i = 0; i < quantityToSpawnBigZombie; i++)
        {
            Vector2 spawnLine = new Vector2(Random.Range(startX, endX), Random.Range(startY, endY));
            int rand = Random.Range(0, big_zombies.Count);
            Instantiate(big_zombies[rand], spawnLine , Quaternion.identity);
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
