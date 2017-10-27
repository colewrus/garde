using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM3D : MonoBehaviour {

    public static GM3D instance = null;

    public Material hoverMat;
    public Material defaultMat;

    public float timerLength; //how long will it accept 

    Vector3 mousedownStart;
    Vector3 mouseupEnd;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        if (instance != this)
            Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("test");
            mousedownStart = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0))
        {
            mouseupEnd = Input.mousePosition;
            Debug.Log(Vector3.Distance(mousedownStart, mouseupEnd));
        }
	}

}
