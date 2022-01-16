using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterEvent : MonoBehaviour
{
    [SerializeField] private float StartTimer = 10;
    [SerializeField] private float time;
    [SerializeField] private bool waveIncomming;

    public Transform[] Waves;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartTimer -= Time.deltaTime;
        if (StartTimer < 0)
        {
            StartEvent();
            StartTimer = time;
        }
        Debug.Log("timer = " + StartTimer);
    }

    void StartEvent()
    {

    }
}
