using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashPlayer : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashMP3;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            crashEffect.Play();
            Debug.Log("Ui Da");
            GetComponent<AudioSource>().PlayOneShot(crashMP3);
            Invoke("ReloadScene", 1f);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
