using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorFelicidades : MonoBehaviour {

    public ContadorPuntaje puntaje;
    public Text textpuntaje;
    //public Animator transicion;
    //public AudioSource audioFelicidades, audioClic;
    //public Registro registro;
    public ControladorBandera bandera;

    public void IrMenu()
    {
        //audioClic.Play();
        puntaje.puntaje = 0;
        bandera.niv1 = false;
        bandera.niv2 = false;
        bandera.niv3 = false;
        StartCoroutine(Transicion("Menuinicio"));
    }

    public void IrEscenaJugar()
    {
        if (bandera.niv1 == true && bandera.niv2 == false)
        {
            StartCoroutine(Transicion("Juego"));
        }
        else if (bandera.niv2 == true && bandera.niv1 == true && bandera.niv3 == false)
        {
            StartCoroutine(Transicion("Juego2"));
        }
        else if (bandera.niv2 == true && bandera.niv1 == true && bandera.niv3 == true)
        {
            StartCoroutine(Transicion("Gracias"));
        }

        //audioClic.Play();
        puntaje.puntaje = 0;
        // StartCoroutine(Transicion(bandera.tempNombre));
    }



    // Use this for initialization
    void Start () {
        bandera = FindObjectOfType<ControladorBandera>();
        //registro = FindObjectOfType<Registro>();
        //registro.ganan++;
        puntaje = FindObjectOfType<ContadorPuntaje>();
        textpuntaje.text = "" + puntaje.puntaje + " ptos";
        //audioFelicidades.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    IEnumerator Transicion(string scene)
    {
        // transicion.SetTrigger("end");
        yield return new WaitForSeconds(0.2f);
        if (scene == bandera.tempNombre)
        {
            //registro.repiten++;
            SceneManager.LoadScene(bandera.tempNombre);
        }

        else if (scene == "Menuinicio")
        {
            SceneManager.LoadScene(scene);
        }
        else if (scene == "Niveles")
        {
            SceneManager.LoadScene(scene);
        }
        else if (scene == "Juego")
        {
            SceneManager.LoadScene(scene);
        }
        else if (scene == "Juego2")
        {
            SceneManager.LoadScene(scene);
        }
        else if (scene == "Tutorial")
        {
            SceneManager.LoadScene(scene);
        }
        else if (scene == "Felicitaciones2")
        {
            SceneManager.LoadScene(scene);
        }
        else if (scene == "Gracias")
        {
            SceneManager.LoadScene(scene);
        }
    }


}
