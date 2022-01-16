using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    public AudioSource audio;
    public GameObject panel;
    public AudioClip deathclip;
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            audio.clip = deathclip;
            Time.timeScale = 0f;
            panel.gameObject.SetActive(true);


        }
    }

   
}