using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class openBox2 : MonoBehaviour, IDropHandler
{
  public Image box2;
  public GameObject box;
  public GameObject map2;
  public void OnDrop(PointerEventData eventData){
    Debug.Log("OnDrop");
    if (eventData.pointerDrag !=null){
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        Debug.Log("openBox2");
        map2.SetActive(true);
        box.SetActive(false);
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Pop);
    }
  }
}
