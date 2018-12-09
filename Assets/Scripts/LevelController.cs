using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField]private GameObject tile;

    [SerializeField] private int levelWidth = 3;
    [SerializeField] private int levelHeight = 5;

    private void Awake()
    {
        //ground = Resources.Load<GroundGreen>("GreenGround");
    }

    private void Start()
    {
        for (int i = -levelWidth; i < levelWidth; i++)
        {
            for (int j = -levelHeight; j < levelHeight; j++)
            {
                GameObject go = Instantiate(tile, new Vector2(i + 0.5f, j + 0.5f), Quaternion.identity) as GameObject;
            }
        }
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) Raycast();
    }


    private void Raycast()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if(hit)
        {
            Debug.Log(hit.collider.name);
        }
    }
}
