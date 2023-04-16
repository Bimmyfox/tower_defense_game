using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject unit;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            // Debug.Log($"Hit {other.gameObject.name}");
            SpawnUnit();
        }
    }

    void SpawnUnit()
    {
        Instantiate(unit, transform.position, transform.rotation);
    }
}
