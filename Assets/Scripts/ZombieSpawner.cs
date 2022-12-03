using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject zombie;
    [SerializeField]
    private GameObject big_zombie;

    private float zombie_interval = 5f;

    private float big_zombie_interval = 10f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawn_enemy(zombie_interval,zombie));
        StartCoroutine(spawn_enemy(big_zombie_interval,big_zombie));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawn_enemy(float interval, GameObject zombie) {
        yield return new WaitForSeconds(interval);
        GameObject new_zombie = Instantiate(zombie, new Vector3(Random.Range(-5f,5), Random.Range(-5f,5), 0), Quaternion.identity);
        StartCoroutine(spawn_enemy(interval,zombie));
    }
}
