using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class openSafe : MonoBehaviour
{
    
    public GameObject safeFullScreen;
    public GameObject Character;
    public GameObject Grid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void openSafeFullScreen(){
        if(safeFullScreen.activeInHierarchy == true){
            safeFullScreen.SetActive(false);
        }else{
            safeFullScreen.SetActive(true);
            sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Pop);
        }
        
    }
    
    
}
