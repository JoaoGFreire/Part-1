using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject missilePrefab;
    public Transform spawn_point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger from: " + collision.gameObject);
        Instantiate(missilePrefab, spawn_point.position, spawn_point.rotation);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Trigger from: " + collision.gameObject);
        Instantiate(missilePrefab, spawn_point.position, spawn_point.rotation);
    }
}
