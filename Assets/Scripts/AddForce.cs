using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed;

    private void Start()
    {
    }

    private void Update()
    {
        rb.AddForce(transform.forward * speed * 2 * Time.deltaTime / 4);

        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }

    //private void OnTriggerEnter(Collider Other)
    //{
    //    if (Other.CompareTag("Player"))
    //    {
    //        rb.AddForce(transform.forward * speed * Time.deltaTime);
    //    }
    //}
}