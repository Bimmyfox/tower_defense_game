using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private float speed = 3.0f;

    private GameObject enemy;
    private Rigidbody unitRigidbody;

    void Start()
    {
        unitRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.tag == "PlayerTower")
        {
            enemy = GameObject.FindWithTag("EnemyTower");
        } else {
            enemy = GameObject.FindWithTag("PlayerTower");
        }

        unitRigidbody.AddForce((enemy.transform.position - transform.position) * speed * Time.fixedDeltaTime);
    }
}
