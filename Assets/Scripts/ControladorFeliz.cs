using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControladorFeliz : MonoBehaviour {

    //public AudioSource audioFelicidades, audioClic;
    public ContadorPuntaje puntaje;
    //public Text textpuntaje;
    public ControladorBandera bandera;
    //public ContadorAlimentos ali;

    // Use this for initialization
    void Start () {

        bandera = FindObjectOfType<ControladorBandera>();
        puntaje = FindObjectOfType<ContadorPuntaje>();
        //audioFelicidades.Play();
        //textpuntaje.text = "" + puntaje.puntaje + " ptos";

        //ali = FindObjectOfType<ContadorAlimentos>();


    }

    // Update is called once per frame
    void Update () {
		
	}

    public void IrMenu()
    {
        bandera.niv1 = false;
        bandera.niv2 = false;
        bandera.niv3 = false;
        //audioClic.Play();
        //puntaje.puntaje = 0;
        StartCoroutine(Transicion("Menuinicio"));
    }

    public void IrGracias()
    {
        bandera.niv1 = false;
        bandera.niv2 = false;
        bandera.niv3 = false;
        //audioClic.Play();
        puntaje.puntaje = 0;
        StartCoroutine(Transicion("Gracias"));
    }

    IEnumerator Transicion(string scene)
    {
        // transicion.SetTrigger("end");
        yield return new WaitForSeconds(0.2f);

        SceneManager.LoadScene(scene);

    }

}
