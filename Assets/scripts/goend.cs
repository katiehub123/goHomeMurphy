using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goend : MonoBehaviour
{

    IEnumerator WaitAndPrint()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(5);
        print("WaitAndPrint " + Time.time);
    }

    IEnumerator Start()
    {
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine
        yield return StartCoroutine("WaitAndPrint");
        print("Done " + Time.time);
    }
    
    public void changetheEnd(){
        SceneManager.LoadSceneAsync(5);
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Pop);
    }
    
}
