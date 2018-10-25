using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverPersonaje : MonoBehaviour {

    public Image Posicion1;
    public Image Posicion2;
    public Image Posicion3;
    public Image Posicion4;

    public Text crono;

	// Use this for initialization
	void Start () {
        Posicion1.gameObject.SetActive(true);
        Posicion2.gameObject.SetActive(false);
        Posicion3.gameObject.SetActive(false);
        Posicion4.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Alpha1))
        {
            if (System.Convert.ToInt32(crono.text) < 11)
            {
                Posicion1.gameObject.SetActive(false);
                Posicion2.gameObject.SetActive(false);
                Posicion3.gameObject.SetActive(true);
                Posicion4.gameObject.SetActive(false);
            }
            else
            {
                Posicion1.gameObject.SetActive(true);
                Posicion2.gameObject.SetActive(false);
                Posicion3.gameObject.SetActive(false);
                Posicion4.gameObject.SetActive(false);
            }
        }

        if(Input.GetKey(KeyCode.Alpha2))
        {
            if(System.Convert.ToInt32(crono.text) < 11)
            {
                Posicion1.gameObject.SetActive(false);
                Posicion2.gameObject.SetActive(false);
                Posicion3.gameObject.SetActive(false);
                Posicion4.gameObject.SetActive(true);
            }
            else
            {
                Posicion1.gameObject.SetActive(false);
                Posicion2.gameObject.SetActive(true);
                Posicion3.gameObject.SetActive(false);
                Posicion4.gameObject.SetActive(false);
            }

        }
	}
}
