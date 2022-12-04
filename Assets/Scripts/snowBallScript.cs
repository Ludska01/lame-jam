using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowBallScript : MonoBehaviour
{
    private Rigidbody2D body;
    [SerializeField]
    private Vector3 snowBallGrowthRate;
    [SerializeField]
    private Vector3 snowBallMaxGrowth;
    [SerializeField]
    private float requiredVelocityForGrowth;
    [SerializeField]
    private float requiredVelocityForKill;
    // Start is called before the first frame update
    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Velocty is : " + body.velocity.magnitude);
            if (body.velocity.magnitude > requiredVelocityForGrowth) {
                if (transform.localScale.magnitude < snowBallMaxGrowth.magnitude) { 
                    transform.localScale += snowBallGrowthRate;
                }
            }   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (body.velocity.magnitude > requiredVelocityForKill) { 
            if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy")) { 
           
               Zombie z = collision.collider.gameObject.GetComponent<Zombie>();
                z.Die();
            }
        } else if(collision.collider.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        } 
    }
}
