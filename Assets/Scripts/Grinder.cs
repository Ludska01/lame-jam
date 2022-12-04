using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grinder : MonoBehaviour
{
    [SerializeField]
    private int zombiesToGrind;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (zombiesToGrind <= 0) {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D colider)
    {

        if (colider.tag == "Zombie" || colider.tag == "BigZombie")
        {
               colider.GetComponent<Zombie>().Die();
               zombiesToGrind--;
            Debug.Log("zombies left to grind: " + zombiesToGrind);
        }

    }
}
