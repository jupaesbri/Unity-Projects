using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour {

    public Text puntaje;
    public Text litros;
    float puntos;
	// Use this for initialization
	void Start () {
        puntaje.text = PlayerPrefs.GetFloat("Score", 1f).ToString();
        litros.text = ((System.Convert.ToDouble(puntaje.text)) * 1.67f).ToString("#.#");
        PlayerPrefs.DeleteAll();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
