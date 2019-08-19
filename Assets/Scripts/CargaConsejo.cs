using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargaConsejo : MonoBehaviour {

    public ControladorBandera bandera;
    public AudioSource audioClic;

    // Use this for initialization
    void Start () {
        bandera = FindObjectOfType<ControladorBandera>();
        StartCoroutine(cargarEscena());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IrJugar()
    {
        audioClic.Play();
        SceneManager.LoadScene("Tutorial");
    }

    IEnumerator cargarEscena()
    {
        yield return new WaitForSecondsRealtime(16f);
        SceneManager.LoadScene("Tutorial");
    }
}
