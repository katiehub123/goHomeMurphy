using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class enterCode : MonoBehaviour
{

public GameObject finalPiece;

    [SerializeField] TextMeshProUGUI codeText;
	string codeTextValue = "";

	// Update is called once per frame
	void Update () {
		codeText.text = codeTextValue;

		if (codeTextValue == "4789") {
			Debug.Log("you got it");
			finalPiece.SetActive(true);
		}

		if (codeTextValue.Length > 4)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

	
}
