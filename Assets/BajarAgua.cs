using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BajarAgua : MonoBehaviour {

    float tam;
    RectTransform rt;
    public float velocidad;

    // Use this for initialization
    void Start () {
        tam = GetComponent<RectTransform>().rect.height;
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void Bajar()
    {
        tam += velocidad;
        GetComponent<RectTransform>().sizeDelta = new Vector2(GetComponent<RectTransform>().rect.width, tam);
    }
}
