using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUp : MonoBehaviour
{
    public bool m_activeShield;
    public MeshRenderer Renderer;
    
    void Start()
    {
        m_activeShield = true;
        Renderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (m_activeShield)
            {
                m_activeShield = false;
                StartCoroutine(BlinkingEffect());
            }
        }
    }

    IEnumerator BlinkingEffect()
    {
        float timer = 3f;
        timer -= Time.deltaTime;

        while (timer >= 0)
        {
            Renderer.enabled = false;
            yield return new WaitForSeconds(0.2f);
            Renderer.enabled = true;
            yield return new WaitForSeconds(0.2f);
        }
        if (timer <= 0)
        {
            Renderer.enabled = true;
        }
    }
}
