using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorGameOver : MonoBehaviour {

    public ContadorPuntaje puntaje;
    public Text textpuntaje;
    public Animator transicion;
    public AudioSource audioPerdistes, audioClic;
    public ControladorBandera bandera;
    //public Registro registro;

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
        audioClic.Play();
        puntaje.puntaje = 0;
        StartCoroutine(Transicion(bandera.tempNombre));
    }

    // Use this for initialization
    void Start () {

        //registro = FindObjectOfType<Registro>();
        //registro.pierden++;
        bandera = FindObjectOfType<ControladorBandera>();
        puntaje = FindObjectOfType<ContadorPuntaje>();
        textpuntaje.text = "" + puntaje.puntaje + " ptos";
        audioPerdistes.Play();

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
    }

}
