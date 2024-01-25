using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    float accelaration;
    float steering;
    public float forwardspeed = 500;
    public float steeringspeed = 200;

    Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        accelaration = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rigidbody.AddTorque(steering * -steeringspeed * Time.deltaTime);
        Vector2 force = transform.up * accelaration * forwardspeed * Time.deltaTime;
        rigidbody.AddForce(force);
    }
}
