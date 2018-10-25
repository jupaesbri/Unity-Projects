using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoverFlecha : MonoBehaviour {

    public Button[] personajes;
    public int puntero;
    bool bandera;
    public GameObject controladorBotones;
    public AudioSource aud;


    // Use this for initialization
    void Start () {
        puntero = 0;
        bandera = false;
        this.GetComponent<RectTransform>().position = personajes[puntero].GetComponent<RectTransform>().position + new Vector3(0f,-4f);
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.D) && !bandera)
        {
            //puntero = (puntero + 1) % personajes.Length;
            puntero = Mathf.Abs(puntero + personajes.Length + 1) % personajes.Length;
            this.GetComponent<RectTransform>().position = personajes[puntero].GetComponent<RectTransform>().position + new Vector3(0f, -4f);
            aud.Play();
            StartCoroutine(Esperar());
        }

        if (Input.GetKey(KeyCode.A) && !bandera)
        {
            //puntero = (Mathf.Abs(puntero - 1) % personajes.Length);
            puntero = Mathf.Abs(puntero + personajes.Length - 1) % personajes.Length;
            this.GetComponent<RectTransform>().position = personajes[puntero].GetComponent<RectTransform>().position + new Vector3(0f, -4f);
            aud.Play();
            StartCoroutine(Esperar());
        }

        personajes[puntero].GetComponent<Button>().Select();

        /*if(Input.GetKey(KeyCode.KeypadEnter))
        {
            //btn2.onClick.AddListener(delegate {TaskWithParameters("Hello"); });
            personajes[puntero].GetComponent<Button>().onClick.AddListener(delegate { controladorBotones.GetComponent<BotonPersonaje>().EscogerPersonaje(nombres[puntero]); });
        }*/
        
    }

    IEnumerator Esperar()
    {
        bandera = true;
        yield return new WaitForSeconds(0.15f);
        bandera = false;
    }
}
