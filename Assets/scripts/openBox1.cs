using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class openBox1 : MonoBehaviour, IDropHandler
{
  public Image box1;
  public GameObject box;
  public GameObject map1;
  public void OnDrop(PointerEventData eventData){
    Debug.Log("OnDrop");
    if (eventData.pointerDrag !=null){
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        Debug.Log("openBox1");
        map1.SetActive(true);
        box.SetActive(false);
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Pop);

    }
  }
}
