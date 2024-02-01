using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class AreaA : MonoBehaviour
{
    SpriteRenderer sr;
    //public Color c;
   
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sr.color = Color.cyan;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sr.color = Color.red;
    }
}
