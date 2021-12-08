using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    private void Start()
    {
        //DeathPanel = FindObjectOfType<ReferenceTest>(true);
    }

    private void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            //DeathPanel.gameObject.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}