using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blueprint : MonoBehaviour
{
    RaycastHit2D hit;
    Vector2 movePoint;
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private GameObject player;
    private AbilityScript sc;
    // Start is called before the first frame update
    void Start()
    {
       sc = player.GetComponent<AbilityScript>();
    }

    // Update is called once per frame
    void Update()
    {
        movePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = movePoint;

        if (Input.GetMouseButtonDown(0))
        {
           
            Instantiate(prefab, transform.position, transform.rotation);
            Destroy(gameObject);
            
        }

        if (Input.GetKeyDown(KeyCode.Q)){
            Destroy(gameObject);
        }
        if (Input.GetMouseButtonDown(1)) {
            transform.Rotate(0, 0, 45);
        }
    }
    
}
