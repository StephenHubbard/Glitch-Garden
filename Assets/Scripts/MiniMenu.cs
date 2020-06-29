using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MiniMenu : MonoBehaviour
{

    int currentSceneIndex;

    [SerializeField] GameObject audioOn;
    [SerializeField] GameObject audioOff;
    [SerializeField] GameObject gamePauseSymbol;
    [SerializeField] GameObject gamePlaySymbol;

    void Start() 
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void PauseGame() 
    {
        Time.timeScale = 0;
        gamePauseSymbol.SetActive(false);
        gamePlaySymbol.SetActive(true);

    }

    public void PlayGame() 
    {
        Time.timeScale = 1;
        gamePauseSymbol.SetActive(true);
        gamePlaySymbol.SetActive(false);
    }

    public void MuteAudio() 
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer) {
            musicPlayer.SetVolume(0f);
        }
        audioOn.SetActive(false);
        audioOff.SetActive(true);
        Debug.Log("hit");

        // PlayerPrefsController.SetMasterVolume(0f);
    }

    public void ResumeAudio()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if (musicPlayer) {
            musicPlayer.SetVolume(.5f);
        }
        audioOn.SetActive(true);
        audioOff.SetActive(false);
    }

    public void RestartLevel() 
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
}
