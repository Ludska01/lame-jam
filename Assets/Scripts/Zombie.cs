using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField]
    private float stunTime;
   
    private Pathfinding.AIPath path;
    private Rigidbody2D zombieBody;
    // Start is called before the first frame update
    void Start()
    {
        zombieBody = gameObject.GetComponent<Rigidbody2D>();
        path = gameObject.GetComponent<Pathfinding.AIPath>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mineHit(){
        if (gameObject.tag == "BigZombie") {
            Stun(stunTime);
        } else
        {
            Die();
        }
        

    }

    public void Die(){

        GetComponent<Collider2D>().enabled = false;

        Destroy(gameObject);
        
    }


    public void Stun(float time) {
        //stun
        path.canMove = false;
        zombieBody.isKinematic = true;
        zombieBody.velocity = Vector2.zero;
        StartCoroutine(StunTime(time));
        
    }

    IEnumerator StunTime(float timeToWait)
    {
        yield return new WaitForSeconds(timeToWait);
        //unstun
        path.canMove = true;
        zombieBody.isKinematic = false;

    }
}
