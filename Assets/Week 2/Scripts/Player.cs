using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float speed = 5f;
    //Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //direction.x = Input.GetAxis("Horizontal");
        //direction.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        //rigidbody.AddForce(direction * force * Time.deltaTime);
        Vector2 force = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))*speed*Time.deltaTime;
        rigidbody.AddForce(force);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Player hit something");
    }
}
