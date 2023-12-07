using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalMap : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject myMaps;
    public GameObject globeFullscreen;
    public GameObject dialogueBox;
    public GameObject character;
    // Start is called before the first frame update
    void Start()
    {
        pointsToWin = myMaps.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints >= pointsToWin){
            transform.GetChild(0).gameObject.SetActive(true);
            globeFullscreen.SetActive(false);
            dialogueBox.SetActive(true);
            character.SetActive(true);
        }
    }

    public void AddPoints(){
        currentPoints++;

    }
}
