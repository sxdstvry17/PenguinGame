using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BlockofVictory : MonoBehaviour
{
    public Timer Timer;
    public GameObject victoryPanel;
    public Controller Controller;
    public LevelManager LevelManager;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Block")
        {
            other.gameObject.transform.position = Vector3.MoveTowards(new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z), new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), 1);
            Renderer blockRenderer = other.gameObject.transform.GetChild(0).GetComponent<Renderer>();
            Animator blockAnimator = other.gameObject.transform.GetChild(0).GetComponent<Animator>();
            Material blockMaterial = blockRenderer.material;
            blockMaterial.SetColor("_EmissionColor", Color.black);
            blockAnimator.Play("Melting");
            Controller.SetCanMove(false);
            Timer.PauseTimer();
            LevelManager.PlayVictoryMusic();
            StartCoroutine(ActivatePanelAfterDelay(3f));
        }
    }
    private IEnumerator ActivatePanelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        if (victoryPanel != null)
        {
            victoryPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
