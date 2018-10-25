using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Conteoregresivo : MonoBehaviour {

    public Text contador;
    public float cont;


	// Use this for initialization
	void Start () {
        cont = 4f;

        StartCoroutine("Descontar");
    }
	
	// Update is called once per frame
	void Update () {

    }

    IEnumerator Descontar()
    {
        Time.timeScale = 0f;
        float i = Time.realtimeSinceStartup + 1;
        float pausetime = Time.realtimeSinceStartup + 5f;
        while(Time.realtimeSinceStartup <= pausetime)
        {
            if(Time.realtimeSinceStartup >= i)
            {
                cont--;
                i++;
                contador.text = cont.ToString();
                

                if(cont == 0)
                {
                    contador.text = "GO!";
                }

                yield return 0;
            }
        }

        Time.timeScale = 1;
        contador.enabled = false;
    }
}
