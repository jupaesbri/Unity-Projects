using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorEscenas : MonoBehaviour {


    public Button boton;
	// Use this for initialization
	void Start () {
        boton.GetComponent<Button>().Select();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SaltarEscena(string es)
    {
        SceneManager.LoadScene(es);
    }
}
