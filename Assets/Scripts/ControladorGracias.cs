using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorGracias : MonoBehaviour {

    public AudioSource audioFelicidades, audioClic;
    public ContadorPuntaje puntaje;
    public ControladorBandera bandera;
    //public ContadorAlimentos alimentos;

    // Use this for initialization
    void Start () {
        puntaje = FindObjectOfType<ContadorPuntaje>();
        bandera = FindObjectOfType<ControladorBandera>();
        //alimentos = FindObjectOfType<ContadorAlimentos>();
        puntaje.puntaje = 0;

        bandera.niv1 = false;
        bandera.niv2 = false;
        bandera.niv3 = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IrMenu()
    {

        //audioClic.Play();
        StartCoroutine(Transicion("Menuinicio"));
    }

    IEnumerator Transicion(string scene)
    {
        // transicion.SetTrigger("end");
        yield return new WaitForSeconds(0.2f);

        SceneManager.LoadScene(scene);
    }

}
