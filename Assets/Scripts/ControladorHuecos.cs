using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorHuecos : MonoBehaviour {

    public ControladorTiempo tiempo;
    public ControladorVida vidas;
    public ControladorPunto puntaje;
    public ControladorMaleta maleta;
    public GameObject naminimo;
    //public ContadorAlimentos contAli;
    [SerializeField] private Transform azulR, rojoC, amarilloE;
    [SerializeField] private Transform constructor;
    public Vector3 initialPosition;
    public Vector2 mousepostion;
    public float deltaX, deltaY;
    public static bool locked;
    public Animator animRegu, animConst, animEner, errorR, errorC, errorE;
    public float manzana;
    public GameObject huecotextR, huecotextC, huecotextE, errorRe, errorCons, errorEne;
    public new ControladorAudio audio;
    public ControladorBandera bandera;
    public GameObject explosioneffect;
    //public Animation anim;

    // Use this for initialization
    void Start()
    {
        bandera = FindObjectOfType<ControladorBandera>();
        audio = FindObjectOfType<ControladorAudio>();
        vidas = FindObjectOfType<ControladorVida>();


    }

    private void Awake()
    {

    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            initialPosition = gameObject.transform.position;
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;



        }
    }

    private void OnMouseDrag()
    {

        if (!locked)
        {

            if (SceneManager.GetSceneByName("Tutorial").isLoaded || SceneManager.GetSceneByName("Juego").isLoaded || SceneManager.GetSceneByName("Juego2").isLoaded)
            {
                mousepostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                transform.position = new Vector2(mousepostion.x - deltaX, mousepostion.y - deltaY);
            }

            
        }

    }
    


    public void efectoExplosion()
    {
        Instantiate(explosioneffect, transform.position, Quaternion.identity);//Instanciar en el lugar de la destruccion
    }

    

    void OnTriggerEnter2D(Collider2D col)
    {
        //ESCENA JUEGO
        //Para los agujeros
        if (col.gameObject.tag == "azulR")
        {
            puntaje = FindObjectOfType<ControladorPunto>();
            vidas = FindObjectOfType<ControladorVida>();
            maleta = FindObjectOfType <ControladorMaleta>();
            maleta.crearRegulador(gameObject.tag);

            
            if (gameObject.tag != "manzana" && gameObject.tag != "platano" && gameObject.tag != "brocoli" && gameObject.tag != "frutilla" && gameObject.tag != "mandarina" && gameObject.tag != "pepino" && gameObject.tag != "mango" && gameObject.tag != "tomate" && gameObject.tag != "uvas" && gameObject.tag != "zanahoria")
            {
                errorRe = GameObject.Find("errorR");

                errorR = errorRe.GetComponent<Animator>();
                errorR.SetTrigger("errorR");

                audio.playNamiTriste();
                if (SceneManager.GetSceneByName("Juego").isLoaded || SceneManager.GetSceneByName("Juego2").isLoaded)
                {
                    vidas.RestarVidas();
                }
            }

            if (gameObject.tag == "manzana" || gameObject.tag == "platano" || gameObject.tag == "brocoli" || gameObject.tag == "frutilla" || gameObject.tag == "mandarina" || gameObject.tag == "pepino" || gameObject.tag == "mango" || gameObject.tag == "tomate" || gameObject.tag == "uvas" || gameObject.tag == "zanahoria")
            {
                puntaje.IncrementarPuntaje(gameObject.tag);
                huecotextR = GameObject.Find("huecotextR");
                
                animRegu = huecotextR.GetComponent<Animator>();
                animRegu.SetTrigger("huecosR");

                audio.playHueco();
            }

            Destroy(gameObject);

        }


        if (col.gameObject.tag == "rojoC")
        {
            puntaje = FindObjectOfType<ControladorPunto>();
            vidas = FindObjectOfType<ControladorVida>();
            maleta = FindObjectOfType<ControladorMaleta>();
            maleta.crearConstructor(gameObject.tag);

            

            if (gameObject.tag != "queso" && gameObject.tag != "leche" && gameObject.tag != "huevo")
            {
                errorCons = GameObject.Find("errorC");

                errorC = errorCons.GetComponent<Animator>();
                errorC.SetTrigger("errorC");


                audio.playNamiTriste();
                if (SceneManager.GetSceneByName("Juego").isLoaded || SceneManager.GetSceneByName("Juego2").isLoaded)
                {
                    vidas.RestarVidas();
                }
            }

            if (gameObject.tag == "queso" || gameObject.tag == "leche" || gameObject.tag == "huevo")
            {
                puntaje.IncrementarPuntaje(gameObject.tag);
                huecotextC = GameObject.Find("huecotextC");

                animConst = huecotextC.GetComponent<Animator>();
                animConst.SetTrigger("huecosC");

                audio.playHueco();


            }

            Destroy(gameObject);

            //print("Animacion ");
        }
        if (col.gameObject.tag == "amarilloE")
        {
            puntaje = FindObjectOfType<ControladorPunto>();
            maleta = FindObjectOfType<ControladorMaleta>();
            maleta.crearEnergetico(gameObject.tag);


            if (gameObject.tag != "sanduche" && gameObject.tag != "maduro" && gameObject.tag != "tortillaverde" && gameObject.tag != "aguacate")
            {
                errorEne = GameObject.Find("errorE");

                errorE = errorEne.GetComponent<Animator>();
                errorE.SetTrigger("errorE");
                audio.playNamiTriste();
                if (SceneManager.GetSceneByName("Juego").isLoaded || SceneManager.GetSceneByName("Juego2").isLoaded)
                {
                    vidas.RestarVidas();
                }
            }

            if (gameObject.tag == "sanduche" || gameObject.tag == "maduro" || gameObject.tag == "tortillaverde" || gameObject.tag == "aguacate")
            {
                puntaje.IncrementarPuntaje(gameObject.tag);
                huecotextE = GameObject.Find("huecotextE");

                animEner = huecotextE.GetComponent<Animator>();
                animEner.SetTrigger("huecosE");

                audio.playHueco();
            }

            Destroy(gameObject);

            //print("Animacion ");
        }
        if (col.gameObject.tag == "colector")
        {
            //efectoExplosion();
            //audio.playDestruir();
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
