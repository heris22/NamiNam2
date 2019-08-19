using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TocarObjeto : MonoBehaviour
{
    [SerializeField] public ControladorTiempo tiempo;
    //public ControladorPuntaje puntaje;
    //public new ControladorAudio audio;
    public GameObject explosioneffect;
    //public Animator explosion;
    //public NamiControlador nami;
    public Animator anim, anim2;

    private float lastClickTime;
    public float catchTime = 0.25f;

    private void OnMouseDown()

    {
        if (Time.time - lastClickTime < catchTime)
        {
            //double click
            //print("Double click");
            if (gameObject.tag == "chatarra")
            {
                // print("Has obtenido una: " + gameObject.tag);
                tiempo = FindObjectOfType<ControladorTiempo>();
                //puntaje = FindObjectOfType<ControladorPuntaje>();
                //nami = FindObjectOfType<NamiControlador>();
                // tiempo.incrementarTiempo();
                //puntaje.IncrementarPuntaje("chatarra");

                anim = GameObject.Find("ÑamiFrames_0").GetComponent<Animator>();

                Instantiate(explosioneffect, transform.position, Quaternion.identity);//Instanciar en el lugar de la destruccion
                anim2 = GameObject.Find("poptext").GetComponent<Animator>();

                anim.SetTrigger("salto");
                //anim2.transform.position = nami.initialPosition;
                //audio.playaudioEstrella();
                anim2.SetTrigger("puntos");


                //mano = GameObject.Find("chatarra");
                //explosion = gameObject.GetComponent<Animator>();
                //explosion.SetTrigger("start");
                Destroy(gameObject);
            }

        }
        else
        {
            //normal click
        }
        lastClickTime = Time.time;
        //  print("1 click");

    }

    /* private void OnMouseDrag()
     {
         if (gameObject.tag == "Frutas")
         {
             print("Estas moviendo una: " + gameObject.tag);
         }
     }*/



    // Use this for initialization
    void Start()
    {
        //audio = FindObjectOfType<ControladorAudio>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
