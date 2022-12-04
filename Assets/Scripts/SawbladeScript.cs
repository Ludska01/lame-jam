using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawbladeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D colider)
    {

        if (colider.tag == "Zombie" || colider.tag == "BigZombie")
        {
            colider.GetComponent<Zombie>().Die();
        }

    }
}
