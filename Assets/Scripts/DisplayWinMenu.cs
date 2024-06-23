using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayWinMenu : MonoBehaviour {

	public Text WinText;

	// Use this for initialization
	void Start () {
        WinText.color = new Color(0, 0, 0, 0);
    }
	
	// Update is called once per frame
	void Update () {
    }

	void OnTriggerEnter(Collider other)
	{
        WinText.color = new Color(1, 0, 0, 1);
    }
}
