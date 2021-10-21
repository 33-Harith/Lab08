using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObjectA;
    public GameObject SpawnObjectB;
    public GameObject SpawnObjectC;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjectsA", 1, 1);
        InvokeRepeating("SpawnObjectsB", 2, 2);
        InvokeRepeating("SpawnObjectsC", 3, 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObjectsA()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObjectA, transform.position, transform.rotation);
    }
    void SpawnObjectsB()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObjectB, transform.position, transform.rotation);
    }
    void SpawnObjectsC()
    {
        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObjectC, transform.position, transform.rotation);
    }
}
