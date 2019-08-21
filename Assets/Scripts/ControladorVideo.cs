using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class ControladorVideo : MonoBehaviour {

    public AudioSource audioClic;
    public VideoPlayer video;

    // Use this for initialization
    void Start () {
        StartCoroutine(cargarEscena());
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IrMenu()
    {
        audioClic.Play();
        StartCoroutine(Transicion("Menuinicio"));

    }

    public void Playvideo()
    {
        audioClic.Play();
        video.Stop();
        video.Play();
        StartCoroutine(cargarEscena());

    }

    IEnumerator Transicion(string scene)
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene(scene);

    }


    IEnumerator cargarEscena()
    {
        video.Prepare();
        GameObject.Find("ButtonHome").GetComponent<Button>().enabled = false;
        GameObject.Find("ButtonHome").GetComponent<Image>().enabled = false;

        GameObject.Find("ButtonRepetir").GetComponent<Button>().enabled = false;
        GameObject.Find("ButtonRepetir").GetComponent<Image>().enabled = false;

        yield return new WaitForSecondsRealtime(26f);
        GameObject.Find("ButtonHome").GetComponent<Button>().enabled = true;
        GameObject.Find("ButtonHome").GetComponent<Image>().enabled = true;

        GameObject.Find("ButtonRepetir").GetComponent<Button>().enabled = true;
        GameObject.Find("ButtonRepetir").GetComponent<Image>().enabled = true;
    }

}
