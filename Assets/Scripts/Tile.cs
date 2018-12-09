using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    [SerializeField] private GameObject crystalBlue01;

    private GameObject currentGameObject;

    private void Start()
    {
        InvokeRepeating("Spawn", Random.Range(1, 40), Random.Range(1, 10));
    }

    private void Spawn()
    {
        if(currentGameObject == null)
        {
            currentGameObject = Instantiate(crystalBlue01, transform.position, Quaternion.identity);
        }
    }
}
