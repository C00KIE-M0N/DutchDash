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
        rb.AddForce(transform.forward * 15 * TempoRegulator.Instance.GetTempoMod() * Time.deltaTime);
    }

    private void Update()
    {
        if (TempoRegulator.Instance.GetChunkCount() % 10 == 0)
        {
            rb.AddForce(transform.forward * 15 * TempoRegulator.Instance.GetTempoMod() * Time.deltaTime);
        }

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