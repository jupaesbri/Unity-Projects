using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonPersonaje : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EscogerPersonaje(string personaje)
    {
        PlayerPrefs.SetString("Personaje", personaje);
        SceneManager.LoadScene("EscenaJuego");
    }
}
