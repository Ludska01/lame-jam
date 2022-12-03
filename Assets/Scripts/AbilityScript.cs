using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityScript : MonoBehaviour
{
    [SerializeField]
    private GameObject objectMine;
    [SerializeField]
    private float startMineCD;
    private float mineCD = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        if (mineCD <= 0) { 
             if (Input.GetKeyDown(KeyCode.J)) {
                Instantiate(objectMine, transform.position, Quaternion.identity);
                mineCD = startMineCD;
            }
        } else {
            mineCD -= Time.deltaTime;
        }
       
    }
}
