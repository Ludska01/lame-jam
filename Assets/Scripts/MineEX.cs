using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineEX : MonoBehaviour
{

    [SerializeField]
    private LayerMask zombieLayer;
    [SerializeField]
    private float explosionRadius;
    [SerializeField]
    private GameObject explosion;
   
    void OnTriggerEnter2D(Collider2D colider){

        if(colider.tag == "Zombie" || colider.tag == "BigZombie"){

            Collider2D[] hitZombies = Physics2D.OverlapCircleAll(transform.position, explosionRadius, zombieLayer);

            foreach (Collider2D zombie in hitZombies)
            {
                zombie.GetComponent<Zombie>().mineHit();
                //zombie.GetComponent<ZombieBig>().mineHit();

            }
            Instantiate(explosion, transform.position ,Quaternion.identity);
            Destroy(gameObject);
        }
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }

}
