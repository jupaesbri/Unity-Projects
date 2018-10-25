using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parall : MonoBehaviour {

    public float velocidad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<RawImage>().uvRect = new Rect(Time.time * velocidad,0f,1f,1f);
	}
}
