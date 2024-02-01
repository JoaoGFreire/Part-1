using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Bulleyt : MonoBehaviour
{
    private Vector2 velocity;
    float Bspeed = 1000f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        velocity = new Vector2(5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(1 * Bspeed * Time.deltaTime, 0, 0);
    }
    private void FixedUpdate()
    {
        //Vector2 Force = new Vector2(1,0)*Bspeed*Time.deltaTime;
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        //rb.AddForce(Force);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
