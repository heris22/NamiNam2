using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAudio : MonoBehaviour {

    public AudioSource audioNamiFeliz, audioNamiTriste, audioClic, audioEstrella, audioSalud, audioHueco;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playNamiFeliz()
    {
        audioNamiFeliz.Play();
        audioSalud.Play();
    }

    public void playaudioEstrella()
    {
        audioNamiFeliz.Play();
        audioEstrella.Play();
    }

    public void playNamiTriste()
    {
        audioNamiTriste.Play();
    }

    public void playClic()
    {
        audioClic.Play();
    }

    public void playHueco()
    {
        audioHueco.Play();
    }

}
