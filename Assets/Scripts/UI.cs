using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject StartPanel;

    private void Start()
    {
        StartPanel.SetActive(true);
    }

    public void StartButton()
    {
        StartPanel.SetActive(false);
    }
}
