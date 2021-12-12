using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowerUp : MonoBehaviour
{
    public GameObject DeathPanel;

    private bool m_activeShield;
    public MeshRenderer Renderer;

    private bool m_invincible;
    
    void Start()
    {
        m_invincible = false;
        Renderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            if (m_activeShield)
            {
                m_activeShield = false;
                m_invincible = true;
                StartCoroutine(BlinkingEffect());
            }
            else if (!m_activeShield && !m_invincible)  
            {
                Time.timeScale = 0f;
                DeathPanel.SetActive(true);
            }
        }
        if (other.gameObject.CompareTag("Shield"))
        {
            m_activeShield = true;
        }
    }

    IEnumerator BlinkingEffect()
    {
        #region renderer
        Renderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = false;
        yield return new WaitForSeconds(0.2f);
        Renderer.enabled = true;
        yield return new WaitForSeconds(0.2f);
        #endregion

        m_invincible = false;
    }
}