using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goback : MonoBehaviour
{
    public void changeEnd(){
        SceneManager.LoadSceneAsync(4);
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Pop);
    }
    
}
