using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityScript : MonoBehaviour
{
    [SerializeField]
    private GameObject objectMine;
    [SerializeField]
    private GameObject baricadeBlueprint;
    [SerializeField]
    private float startMineCD;
    [SerializeField]
    private float startBaricadeCD;
    private float baricadeCD = 0;
    private float mineCD = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        if (mineCD <= 0) { 
             if (Input.GetKeyDown(KeyCode.F)) {
                Instantiate(objectMine, transform.position, Quaternion.identity);
                mineCD = startMineCD;
            }
        } else {
            mineCD -= Time.deltaTime;
        }
        
        if (baricadeCD <= 0) {
            if (Input.GetKeyDown(KeyCode.LeftShift)) {
                Instantiate(baricadeBlueprint);
                baricadeCD = startBaricadeCD;
            }
        }
        else
        {
            baricadeCD -= Time.deltaTime;
            
        }
       
    }
        
}
