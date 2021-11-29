using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private float thrust = 20;
    [SerializeField] private float journyTime;
    [SerializeField] private int LaneNumber;
    private Rigidbody m_RigidBody;

    int layerMask = 1 << 8;

    public bool GroundHit;

    public Transform[] Lanes;

    private void Start()
    {
        m_RigidBody = GetComponent<Rigidbody>();
        LaneNumber = 2;
    }

    private void OnCollisionEnter()
    {
        GroundHit = true;
    }

    //lane 0 is 2 in de array
    //dus
    //-2 = 0
    //-1 = 1
    // 0 = 2
    // 1 = 3
    // 2 = 4

    private void Update()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * hit.distance, Color.yellow);

        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * 1, Color.white);
            Debug.Log("Did not Hit");
            PlayerMovement();
        }

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hit.distance, Color.yellow);

        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * 1, Color.white);
            Debug.Log("Did not Hit");
            PlayerMovement();
        }

        if (Input.GetKeyDown(KeyCode.Space) && GroundHit)
        {
            m_RigidBody.AddForce(transform.up * thrust);
            GroundHit = false;
        }
    }

    public void UpdatePlayer()
    {
        Player.position = Lanes[LaneNumber].position;
    }

    public void PlayerMovement()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (LaneNumber < Lanes.Length)
            {
                LaneNumber += 1;
                UpdatePlayer();
            }
        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (LaneNumber > 0)
            {
                LaneNumber -= 1;
                UpdatePlayer();
            }
        }
       
    }
}