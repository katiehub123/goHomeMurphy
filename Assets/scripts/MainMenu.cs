using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync(1);
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Talk);
    }
    public void QuitGame(){
        Application.Quit();
    }
}
