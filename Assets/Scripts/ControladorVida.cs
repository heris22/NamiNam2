using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorVida : MonoBehaviour {

    public GameObject vida1, vida2, vida3;
    public int contVidas;
    public ControladorBandera bandera;
    public ControladorJuego juego;

    // Use this for initialization
    void Start () {
        bandera = FindObjectOfType<ControladorBandera>();
        if (SceneManager.GetSceneByName("Tutorial").isLoaded || SceneManager.GetSceneByName("Juego").isLoaded || SceneManager.GetSceneByName("Juego2").isLoaded)
        {
            Instantiate(vida1, GameObject.Find("Canvas").transform);
            Instantiate(vida2, GameObject.Find("Canvas").transform);
            Instantiate(vida3, GameObject.Find("Canvas").transform);
        }

        contVidas = 3;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RestarVidas()
    {
       

        if (contVidas == 3)
        {
            GameObject.Find("corazones(Clone)").SetActive(false);
            contVidas--;
        }

        else if (contVidas == 2)
        {
            GameObject.Find("corazones2(Clone)").SetActive(false);
            contVidas--;
        }
        else if (contVidas == 1)
        {
            GameObject.Find("corazones3(Clone)").SetActive(false);
            contVidas--;
            StartCoroutine(Transicion());
        }


    }

    IEnumerator Transicion()
    {
        juego = FindObjectOfType<ControladorJuego>();
        // juego.transicion.SetTrigger("end");
        yield return new WaitForSeconds(0.2f);
        juego.GameOver();
    }
}
