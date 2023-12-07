using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ItemDrop : MonoBehaviour, IDropHandler
{
  public void OnDrop(PointerEventData eventData){
    Debug.Log("OnDrop");
    if (eventData.pointerDrag !=null){
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        SceneManager.LoadSceneAsync(2);
        sfxManager.sfxInstance.Audio.PlayOneShot(sfxManager.sfxInstance.Pop);
    }
  }
}
