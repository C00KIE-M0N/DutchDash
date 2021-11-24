using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        rb.AddForce(transform.forward * speed * 2 * Time.deltaTime / 4);
    }

    //private void OnTriggerEnter(Collider Other)
    //{
    //    if (Other.CompareTag("Player"))
    //    {
    //        rb.AddForce(transform.forward * speed * Time.deltaTime);
    //    }
    //}
}