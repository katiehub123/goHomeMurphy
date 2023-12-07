using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotoPearl : MonoBehaviour
{
    public void changetoPearl(){
        SceneManager.LoadSceneAsync(3);
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Pop);
    }
    
}
