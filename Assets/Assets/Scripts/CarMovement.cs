using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    
    private float move;
    private float lastTime;
    [SerializeField]
    private float moveSpeed;
    private float rotation;
    [SerializeField]
    private float rotationSpeed;
    private int speed;
    private Vector3 mLastPosition;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;
        rotationSpeed = 200f;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * -rotationSpeed * Time.deltaTime;
    }

    private void LateUpdate()
    {
        CalculateSpeed();
        transform.Translate(0f, move, 0f);
        if(speed > 0)
        {
            transform.Rotate(0f, 0f, rotation);
        }
        
    }
    //Calculate speed if moving it will be 1 and above 
    private void CalculateSpeed(){
        speed = (int)((transform.position - mLastPosition).magnitude / Time.deltaTime - lastTime);
        mLastPosition = transform.position;
        lastTime = Time.deltaTime;
    }
}
