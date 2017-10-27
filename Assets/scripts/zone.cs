using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class zone : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
           
	}	


 
    public void BladeEnter()
    {
        gameObject.GetComponent<Image>().color = new Color(0.8f, 0.2f, 0.1f, GM.instance.zoneOpacity);
        GM.instance.zone = gameObject;
    }

    public void BladeExit()
    {
        gameObject.GetComponent<Image>().color = new Color(1, 1, 1, GM.instance.zoneOpacity);
    }

    public void Attack() //this is only when the pointer is down
    {

    }
}
