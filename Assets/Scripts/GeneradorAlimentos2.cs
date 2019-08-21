using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneradorAlimentos2 : MonoBehaviour {


    [SerializeField]
    public GameObject[] frutas;
    public GameObject[] frutas2;
    public GameObject[] frutas3;
    public ControladorTiempo tiempo;
    public bool bandera, regulador, constructor, energetico;
    public int numTemp, numero;

    private BoxCollider2D col;
    float x1, x2;

    void Awake()
    {
        col = GetComponent<BoxCollider2D>();
        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;

    }
    void Start()
    {
        tiempo = FindObjectOfType<ControladorTiempo>();
        StartCoroutine(GenerarAlimentos(1f));
        regulador = true;
    }

    IEnumerator GenerarAlimentos(float time)
    {
        yield return new WaitForSecondsRealtime(time);

        Vector3 temp = transform.position;
        
        temp.x = Random.Range(x1, x2);

        if (regulador == false && constructor == false && energetico == false)
        {
            Instantiate(frutas2[Random.Range(0, frutas2.Length)], temp, Quaternion.identity);
            print(numTemp);
            numero = numTemp;
            regulador = true;
            constructor = false;
            energetico = false;
        } else if (regulador == true && constructor == false && energetico == false)
        {
            Instantiate(frutas3[Random.Range(0, frutas3.Length)], temp, Quaternion.identity);
            regulador = false;
            constructor = true;
            energetico = false;
        }else if (regulador == false && constructor == true && energetico == false)
        {
            Instantiate(frutas[Random.Range(0, frutas.Length)], temp, Quaternion.identity);
            regulador = false;
            constructor = false;
            energetico = false;
        }

        /*while (numTemp != numero)
        {

            numTemp = Random.Range(0, 3);
            print(numTemp);

        }  ;
        
        if (numTemp == 1)
        {
            Instantiate(frutas[Random.Range(0, frutas.Length)], temp, Quaternion.identity);
            print(numTemp);
            numero = numTemp;
        }
        if (numTemp == 0)
        {
            Instantiate(frutas2[Random.Range(0, frutas2.Length)], temp, Quaternion.identity);
            numero = numTemp;
        }
        if (numTemp == 2)
        {
            Instantiate(frutas3[Random.Range(0, frutas3.Length)], temp, Quaternion.identity);

        }*/



        if (SceneManager.GetSceneByName("Tutorial").isLoaded)
        {
            StartCoroutine(GenerarAlimentos(3f));

        }
        if (SceneManager.GetSceneByName("Juego").isLoaded)
        {
            StartCoroutine(GenerarAlimentos(3f));

        }
        if (SceneManager.GetSceneByName("Juego2").isLoaded)
        {
            StartCoroutine(GenerarAlimentos(3f));

        }


    }
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        if (tiempo.tiempo <= 12)
        {
            bandera = true;
        }
    }
	
}