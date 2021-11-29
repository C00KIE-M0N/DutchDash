using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField] GameObject Player;

    [SerializeField] float xMin = -2, xMax = 2;
    [SerializeField] float journyTime = 1f;
    [SerializeField] float thrust = 20;

    Rigidbody m_RigidBody;

    public bool GroundHit;

    void Start()
    {
        m_RigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter()
    {
        GroundHit = true;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            Player.transform.position += new Vector3(0, 0, -2);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Player.transform.position += new Vector3(0, 0, 2);
        }

        if (Input.GetKeyDown(KeyCode.Space) && GroundHit)
        {
            m_RigidBody.AddForce(transform.up * thrust);
            GroundHit = false;
        }

        Vector3 newpos = new Vector3(Player.transform.position.x, Player.transform.position.y,Mathf.Clamp(Player.transform.position.z, xMin, xMax));
        Player.transform.position = Vector3.Slerp(Player.transform.position, newpos, journyTime);
    }
}