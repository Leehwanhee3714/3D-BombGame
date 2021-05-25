using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour
{
    public Transform target;
    private Rigidbody rjg;
    public float speed = 20f;

    void Start()
    {
        rjg = GetComponent<Rigidbody>();
        target = GameObject.FindWithTag("Player").transform;
    }
    void Update()
    {
        if (Vector3.Distance(target.position, transform.position) < 10f)
        {
            Vector3 trans = target.position - transform.position;
            rjg.AddForce(trans * speed * Time.deltaTime);
        }
    }
}
