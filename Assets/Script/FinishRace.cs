using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishRace : MonoBehaviour
{

    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            finishEffect.Play();
            Debug.Log("Finish");
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", 1f);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
