using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ControladorPersonajes : MonoBehaviour {

    public GameObject per1;
    public GameObject per2;
    public GameObject per3;

    string mensaje;

    // Use this for initialization
    void Start () {
        per1.gameObject.SetActive(false);
        per2.SetActive(false);
        per3.SetActive(false);

        try
        {
            per1.GetComponent<MoverPersonaje>().enabled = false;
            per2.GetComponent<MoverPersonaje>().enabled = false;
            per3.GetComponent<MoverPersonaje>().enabled = false;
        }

        catch
        {
            //Debug.Log("Error");
        }
        

        //Debug.Log("TODOS BORRADOS");

        mensaje = PlayerPrefs.GetString("Personaje", " ");

        if(mensaje == "obrero")
        {
            per1.SetActive(true);
            try
            {
                per1.GetComponent<MoverPersonaje>().enabled = true;
            }

            catch
            {
                //Debug.Log("Error");
            }
        }

        if (mensaje == "tecnico")
        {
            per2.SetActive(true);
            try
            {
                per2.GetComponent<MoverPersonaje>().enabled = true;
            }

            catch
            {
                //Debug.Log("Error");
            }
        }

        if (mensaje == "mina")
        {
            per3.SetActive(true);
            try
            {
                per3.GetComponent<MoverPersonaje>().enabled = true;
            }

            catch
            {
                //Debug.Log("Error");
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
