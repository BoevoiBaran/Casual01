using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    [SerializeField] private GameObject particleEffect;

    public void Click()
    {

        Debug.Log("Click");
        Instantiate(particleEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


}