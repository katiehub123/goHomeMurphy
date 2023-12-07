using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSystem : MonoBehaviour
{
    public GameObject objectToDrag;
    public GameObject objectDragtoPos;

    public float Dropdistance;

    public bool isLocked;

    Vector2 objectInitPos;

    // Start is called before the first frame update
    void Start()
    {
        objectInitPos = objectToDrag.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DragObject(){
        if(isLocked){
            objectToDrag.transform.position = Input.mousePosition;
        }
    }
    public void DropObject(){
        float Distance = Vector3.Distance(objectToDrag.transform.position, objectDragtoPos.transform.position);
        if(Distance < Dropdistance){
            isLocked = true;
            objectToDrag.transform.position = objectDragtoPos.transform.position;

            GameObject.Find("PointsHandler").GetComponent<finalMap>().AddPoints();
        }
        else{
            objectToDrag.transform.position = objectInitPos;
        }
    }
}
