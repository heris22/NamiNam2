using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPunto : MonoBehaviour {

    [SerializeField] public Text puntajeText;
    [SerializeField] public Text puntosfloatR, puntosfloatC, puntosfloatE, huecofloatR, huecofloatC, huecofloatE;
    public ContadorPuntaje contP;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        contP = FindObjectOfType<ContadorPuntaje>();
        puntajeText.text = contP.puntaje + " pts";
    }

    public void IncrementarPuntaje(string tag)
    {

        if (tag == "manzana" || tag == "platano" || tag == "mandarina" || tag == "uvas" || tag == "mango" || tag == "tomate" || tag == "zanahoria" || tag == "pepino" || tag == "brocoli" || tag == "frutilla")
        {
            contP.puntaje += 5f;
            huecofloatR.text = "+5";
        }

        if (tag == "queso" || tag == "leche" || tag == "huevo")
        {
            contP.puntaje += 5f;
            huecofloatC.text = "+5";
        }

        if (tag == "maduro" || tag == "sanduche" || tag == "tortillaverde" || tag == "aguacate")
        {
            contP.puntaje += 5f;
            huecofloatE.text = "+5";
        }

    }

    public void IncrementarMaleta()
    {
        contP.puntaje += 30f;
        puntosfloatR.text = "+10";
        puntosfloatC.text = "+10";
        puntosfloatE.text = "+10";
    }
}
