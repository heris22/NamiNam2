using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorJuego : MonoBehaviour {

    //public ContadorAlimentos alimentos;
    public ContadorPuntaje contP;
    //public Animator ani, transicion;
    //public GameObject img, mano;
    //public new ControladorAudio audio;
    //public Registro registro;
    public ControladorBandera bandera;


    public void IrMenu(string nombre)
    {
        //SceneManager.LoadScene(nombre);
        //registro.abandonan++;
        //audio = FindObjectOfType<ControladorAudio>();
        //audio.playClic();
        contP.puntaje = 0;
        bandera.niv1 = false;
        bandera.niv2 = false;
        bandera.niv3 = false;
        
        StartCoroutine(Transicion());
        
    }


    public void GameOver()
    {
        SceneManager.LoadScene("Gameover");
        // print("Has perdido");
    }

    public void Felicitaciones()
    {
        SceneManager.LoadScene("Felicitaciones");
        //  print("Cambiando a Escena Lonchera");
    }

    IEnumerator Transicion()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Menuinicio");
    }

    // Use this for initialization
    void Start () {
        bandera = FindObjectOfType<ControladorBandera>();
        //registro = FindObjectOfType<Registro>();
        //alimentos = FindObjectOfType<ContadorAlimentos>();
        contP = FindObjectOfType<ContadorPuntaje>();

        if (SceneManager.GetSceneByName("Tutorial").isLoaded)
        {
            bandera.tempNombre = "Tutorial";
        }
        else if (SceneManager.GetSceneByName("Juego").isLoaded)
        {
            bandera.tempNombre = "Juego";
        }
        else if (SceneManager.GetSceneByName("Juego2").isLoaded)
        {
            bandera.tempNombre = "Juego2";
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator WaitAndDoSomething()
    {
        yield return new WaitForSeconds(1f);
        // do something

    }
}
