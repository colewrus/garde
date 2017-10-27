using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeZone : MonoBehaviour {

   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = GM3D.instance.hoverMat;
    }


    private void OnMouseOver()
    {       
        
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = GM3D.instance.defaultMat;
    }
}
