using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public void Click()
    {

        Debug.Log("Click");
        Destroy(gameObject);
    }


}