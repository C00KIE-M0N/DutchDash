using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public GameObject panel;
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            panel.gameObject.SetActive(true);


        }
    }

   
}