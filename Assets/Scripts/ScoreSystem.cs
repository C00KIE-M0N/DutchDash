using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public float ScoreMod;

    [SerializeField] private float m_totalScore;

    private Vector3 m_oldPosisition;
    private float m_totalDistance;

    private void Start()
    {
        m_oldPosisition = transform.position;
    }

    private void Update()
    {
        CalculateDistance();
    }

    private void CalculateDistance()
    {
        Vector3 _distancevector = transform.position - m_oldPosisition;
        float _distancetravelledthisframe = _distancevector.magnitude;

        m_totalDistance += _distancetravelledthisframe;
        m_oldPosisition = transform.position;

        m_totalScore = m_totalDistance * ScoreMod;
    }
}