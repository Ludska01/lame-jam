using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    
    
    [SerializeField]
    private float accelerationFactor = 30.0f;
    [SerializeField]
    private float turnFactor = 3.5f;
    [SerializeField]
    private float driftFactor = 0.95f;
    [SerializeField]
    private float maxSpeed = 20;
    //Local variables 
    float accelerationInput = 0;
    float steeringInput = 0;
    float rotationAngle = 0;
    float velocityVsUp = 0;

    //Components 
    Rigidbody2D carRigidbody2D;

    private void Awake()
    {
        carRigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    private void FixedUpdate()
    {
        ApplyEngineForce();
        KillSideVeloscity();
        ApplySteering();
    }

    private void ApplyEngineForce()
    {
        // Calculate speed 
        velocityVsUp = Vector2.Dot(transform.up, carRigidbody2D.velocity);

        //Limit speed 
        if (velocityVsUp > maxSpeed && accelerationInput > 0)
            return;
        if (velocityVsUp < -maxSpeed * 0.5 && accelerationInput < 0)
            return;
        if (carRigidbody2D.velocity.sqrMagnitude > maxSpeed * maxSpeed && accelerationInput > 0)
            return;


        //Apply drag 
        if (accelerationInput == 0)
        {
            carRigidbody2D.drag = Mathf.Lerp(carRigidbody2D.drag, 3.0f, Time.deltaTime * 3);
        }
        else {
            carRigidbody2D.drag = 0;
        }
        //Create force for engine
        Vector2 engineForceVector = transform.up * accelerationInput * accelerationFactor;

        carRigidbody2D.AddForce(engineForceVector, ForceMode2D.Force);
       
    }

    private void ApplySteering()
    {
        //Minimum speed to turn
        float minSpeedAllowToTurn = (carRigidbody2D.velocity.magnitude / 8);
        minSpeedAllowToTurn = Mathf.Clamp01(minSpeedAllowToTurn);
        //Update rotation angle based on input 
        rotationAngle -= steeringInput * turnFactor * minSpeedAllowToTurn;

        //Apply steering 
        carRigidbody2D.MoveRotation(rotationAngle);

    }

    public void SetInputVector(Vector2 inputVector) {
        steeringInput = inputVector.x;
        accelerationInput = inputVector.y;
    }

    void KillSideVeloscity() {
        Vector2 forwardVelocity = transform.up * Vector2.Dot(carRigidbody2D.velocity, transform.up);
        Vector2 rightVelocity = transform.right * Vector2.Dot(carRigidbody2D.velocity, transform.right);

        carRigidbody2D.velocity = forwardVelocity + rightVelocity * driftFactor;

    }
}
