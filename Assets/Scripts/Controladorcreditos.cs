using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controladorcreditos : MonoBehaviour {

    public AudioSource audioClicr;


    public void IrEscenaInicio ()
    {
        audioClicr.Play();
        StartCoroutine(Transicion("Menuinicio"));
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    IEnumerator Transicion(string scene)
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(scene);
    }
}