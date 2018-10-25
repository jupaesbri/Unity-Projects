using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorJuego : MonoBehaviour {

    public Text cronometro;
    public Text puntaje;

    bool bandera;
    int tiempo;
    public GameObject camion;


    public float nivelActual;

    bool hayBonus = true;
    public GameObject bonus;
    float puntos;

    public AudioSource audAgua;

    // Use this for initialization
    void Start() {
        tiempo = 31;
        cronometro.text = tiempo.ToString();
        bandera = false;
        nivelActual = 10;
        bonus.SetActive(false);
        puntos = 0;

    }

    // Update is called once per frame
    void Update() {
        nivelActual = camion.GetComponent<RectTransform>().sizeDelta.y;
        puntaje.text = ((nivelActual / 3)*6).ToString("#.#");
        puntos = (nivelActual / 3) * 6;


        if (!bandera && tiempo>0)
        {
            StartCoroutine(Descontar());
        }

        if(((Input.GetKey(KeyCode.Alpha1)) && tiempo>0 && camion.GetComponent<RectTransform>().sizeDelta.y<300)) 
        {
            camion.GetComponent<BajarAgua>().Bajar();
            audAgua.Play();
        }

        if(tiempo <= 10)
        {
            cronometro.color = new Color(255f,0f,0f);
        }

        if((tiempo<=10 && tiempo>=9) && hayBonus && System.Convert.ToDouble(puntaje.text)>= 350f)
        {
            //Debug.Log("BONUS");
            bonus.SetActive(true);
            cronometro.color = new Color(0f, 255f, 0f);
            hayBonus = false;
            tiempo = tiempo + 10;
        }

        if(tiempo<=0 || camion.GetComponent<RectTransform>().sizeDelta.y >= 300.1f)
        {
            PlayerPrefs.SetFloat("Score",puntos);
            SceneManager.LoadScene("Puntaje");
        }

	}

    IEnumerator Descontar()
    {
        bandera = true;
        tiempo--;
        cronometro.text = tiempo.ToString();
        yield return new WaitForSeconds(1f);
        bandera = false;
    }
}
