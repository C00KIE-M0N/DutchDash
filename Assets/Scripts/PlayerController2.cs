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
}