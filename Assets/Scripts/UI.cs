using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject StartPanel;

    private void Start()
    {
        Time.timeScale = 0f;
        StartPanel.SetActive(true);
    }

    public void StartButton()
    {
        StartPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
