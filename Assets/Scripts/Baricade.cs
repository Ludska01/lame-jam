using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baricade : MonoBehaviour
{  
    [SerializeField]
    private float baricadeHealth = 100;
    [SerializeField]
    private float baricadeDamage = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (baricadeHealth <= 0) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Enemy")) {
            baricadeHealth -= baricadeDamage;
            Debug.Log("Health left :" + baricadeHealth);
        }
    }

}
