using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    [SerializeField]GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
