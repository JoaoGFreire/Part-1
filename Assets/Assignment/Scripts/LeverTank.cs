using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverTank : MonoBehaviour
{
    public GameObject Tank;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Tank.activeInHierarchy == true)
        {
            Tank.SetActive(false);
        }
        else 
        {
            Tank.SetActive(true);
        }
    }
}
