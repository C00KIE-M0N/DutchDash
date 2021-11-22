using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField]GameObject Player;

    [SerializeField] float xMin = -2, xMax = 2;
    [SerializeField] float journyTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            Player.transform.position += new Vector3(1, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Player.transform.position += new Vector3(-1, 0, 0);
        }

        Vector3 newpos = new Vector3(Mathf.Clamp(Player.transform.position.x, xMin, xMax), Player.transform.position.y, Player.transform.position.z);
        Player.transform.position = Vector3.Slerp(Player.transform.position, newpos, journyTime);
    }
}
