using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scanScript : MonoBehaviour
{   
    private float nextActionTime = 0.0f;
    [SerializeField]
    public float period = 10f;

    private AstarPath pathfinder;
    private void Start()
    {
        pathfinder = gameObject.GetComponent<AstarPath>();
    }
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            // execute block of code here
            pathfinder.Scan();

        }
    }
}
