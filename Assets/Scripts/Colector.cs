using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colector : MonoBehaviour {
    //public ControladorTiempo tiempo;
    //public ControladorVidas vidas;
    public int temp;

    private void OnTriggerEnter2D(Collider2D target)
    {
        /*
        if (target.tag == "saludable")
        {
            tiempo = FindObjectOfType<ControladorTiempo>();
            tiempo.restarTiempo(5);
            Destroy(target.gameObject);
        }

        if (target.tag == "chatarra")
        {
            tiempo = FindObjectOfType<ControladorTiempo>();
            tiempo.restarTiempo(2);
            Destroy(target.gameObject);
        }*/
        //print(gameObject);
        
        /*
        if (target.gameObject.tag != "chatarra")
        {
            temp++;
            if (temp == 2)
            {
            
                vidas = FindObjectOfType<ControladorVidas>();
                vidas.RestarVidas();
                temp = 0;
            }
        }*/
      
        Destroy(target.gameObject);

    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
