using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour
{
    public int columnPoolSize = 5;
    public GameObject columnPrefab;

    private GameObject[] columns;
    private Vector2 objectPoolPosition = new Vector2(-15f, -25f);


    // Start is called before the first frame update
    void Start()
    {
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i <columnpoolSize; i++)
        {
            columns[i] = (GameObject) Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity)
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
