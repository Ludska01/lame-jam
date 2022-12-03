using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaricadeBlueprintScript : MonoBehaviour
{
    RaycastHit2D hit;
    Vector2 movePoint;
    [SerializeField]
    private GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        movePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = movePoint;
    }

    // Update is called once per frame
    void Update()
    {
        movePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = movePoint;
    }
    
}
