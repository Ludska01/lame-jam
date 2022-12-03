using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mineHit(){

        Die();

    }

    void Die(){

        GetComponent<Collider2D>().enabled = false;

        Destroy(gameObject);
        
    }
}
