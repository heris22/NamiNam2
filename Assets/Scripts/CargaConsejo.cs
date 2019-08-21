using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

        GameObject.Find("ButtonSaltar").GetComponent<Button>().enabled = false;
        GameObject.Find("ButtonSaltar").GetComponent<Image>().enabled = false;
        yield return new WaitForSeconds(2f);
        GameObject.Find("ButtonSaltar").GetComponent<Button>().enabled = true;
        GameObject.Find("ButtonSaltar").GetComponent<Image>().enabled = true;


        yield return new WaitForSecondsRealtime(16f);
        SceneManager.LoadScene("Tutorial");
    }
}
