using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorTiempo : MonoBehaviour {

    [SerializeField] public Text tiempoText;
    [SerializeField] public float tiempo = 0.0f;
    public ControladorJuego juego;
    public ControladorBandera bandera;
    
    public Color red;
    //public Animator animtiempo;
    public bool comenzar = false;

    void Start()
    {
        bandera = FindObjectOfType<ControladorBandera>();
        StartCoroutine(Esperar(2f));

        //animtiempo = tiempoText.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (comenzar == true)
        {

            if (tiempo <= 0)
            {
                tiempo = 0f;
                tiempoText.text = "00:00";
                StartCoroutine(Transicion());
            }
            else
            {

                // print(tiempo);
                // tiempo = Mathf.Round(tiempo);
                if (Convert.ToInt32(tiempo) <= 5f && Convert.ToInt32(tiempo) >= 0f)
                {
                    //animtiempo.SetTrigger("tiempolimite");
                    // print(Convert.ToInt32(tiempo));
                    tiempoText.color = red;

                }

                tiempo -= Time.deltaTime;
                // tiempo = tiempo-1f;
                if (Convert.ToInt32(tiempo) > 9)
                {
                    tiempoText.text = "00:" + tiempo.ToString("0");
                }
                else
                {
                    tiempoText.text = "00:0" + tiempo.ToString("0");
                }


            }
        }



    }

    IEnumerator Esperar(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        comenzar = true;
    }

    

    

    IEnumerator Transicion()
    {
        
        if (SceneManager.GetSceneByName("Tutorial").isLoaded)
        {
            bandera.niv1 = true;
        }
        else if (SceneManager.GetSceneByName("Juego").isLoaded)
        {
            bandera.niv2 = true;
        }
        else if (SceneManager.GetSceneByName("Juego2").isLoaded)
        {
            bandera.niv3 = true;
        }

        juego = FindObjectOfType<ControladorJuego>();
        //ali = FindObjectOfType<ContadorAlimentos>();
        //juego.transicion.SetTrigger("end");
        yield return new WaitForSeconds(0.2f);

        if (bandera.niv2 == true && bandera.niv1 == true)
        {
            SceneManager.LoadScene("Felicitaciones2");
        }
        else
        {
            juego.Felicitaciones();
        }

       


    }
}
