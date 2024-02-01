using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverShot : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform spawn;
    public GameObject Tank;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Tank.activeInHierarchy == true)
        {
            Instantiate(BulletPrefab, spawn.position, spawn.rotation);
        }
    }
}
