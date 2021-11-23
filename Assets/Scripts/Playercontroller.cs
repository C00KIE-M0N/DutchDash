using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField]GameObject Player;

    [SerializeField] float xMin = -2, xMax = 2;
    [SerializeField] float journyTime = 1f;
    [SerializeField] float thrust = 20;

    Rigidbody m_RigidBody;

    public bool GroundHit;

    // Start is called before the first frame update
    void Start()
    {
        m_RigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionStay()
    {
        GroundHit = true;
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.D))
        {
            Player.transform.position += new Vector3(1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            Player.transform.position += new Vector3(-1, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space) && GroundHit)
        {
            
            m_RigidBody.AddForce(transform.up * thrust);
            GroundHit = false;
        }



        Vector3 newpos = new Vector3(Mathf.Clamp(Player.transform.position.x, xMin, xMax), Player.transform.position.y, Player.transform.position.z);
        Player.transform.position = Vector3.Slerp(Player.transform.position, newpos, journyTime);
    }
}
