using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public void HoverSound()
    {
        audioSource.PlayOneShot(hoverSound);
    }
    public void ClickSound()
    {
        audioSource.PlayOneShot(clickSound);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GameMode");
    }

    public void QuitGame()
    {
        Application.Quit();
        
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Back()
    {
        SceneManager.LoadScene("MainMenu");
    }
    


}
