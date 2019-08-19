using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ControladorMaleta : MonoBehaviour {

    [SerializeField] private GameObject[] azulRegulador;
    [SerializeField] private GameObject[] rojoConstructor;
    [SerializeField] private GameObject[] amarilloEnergetico;
    public ControladorPunto puntaje;
    public bool reguladorBandera, constructorBandera, energeticoBandera;
    public string tempRegulador, tempConstructor, tempEnergetico;
    public List<string> tempAlimentos;
    public Animator anim, anim2, animRe, animCo, animE;
    public GameObject poptextRe, poptextCo, poptextE;
    public new ControladorAudio audio;
    public GameObject estrellaeffect, estrellaeffect2;
    public bool conejo;

    // Use this for initialization
    void Start () {
        audio = FindObjectOfType<ControladorAudio>();
        
    }

    public void efectoEstrella()
    {
        Instantiate(estrellaeffect, GameObject.Find("Canvas").transform);//Instanciar en el lugar de la destruccion
    }

    public void efectoEstrella2()
    {
        Instantiate(estrellaeffect2, GameObject.Find("Canvas").transform);//Instanciar en el lugar de la destruccion
    }

    // Update is called once per frame
    void Update () {

        if (reguladorBandera == true && constructorBandera == true && energeticoBandera == true) {

            destruirAlimentos();
            poptextRe = GameObject.Find("poptextR");
            poptextCo = GameObject.Find("poptextC");
            poptextE = GameObject.Find("poptextE");

            animRe = poptextRe.GetComponent<Animator>();
            animRe.SetTrigger("puntos");

            animCo = poptextCo.GetComponent<Animator>();
            animCo.SetTrigger("puntosC");

            animE = poptextE.GetComponent<Animator>();
            animE.SetTrigger("puntosE");



            puntaje = FindObjectOfType<ControladorPunto>();
            puntaje.IncrementarMaleta();
            audio.playNamiFeliz();

            if (conejo == false)
            {
                anim = GameObject.FindGameObjectWithTag("naminino").GetComponent<Animator>();
                anim.SetTrigger("comer");
                
                efectoEstrella();
                conejo = true;
            }
            else
            {
                anim2 = GameObject.FindGameObjectWithTag("naminina").GetComponent<Animator>();
                anim2.SetTrigger("comer2");
                
                efectoEstrella2();
                conejo = false;
            }
            

            destruirAlimentos();

            /*Destroy(GameObject.Find(tempRegulador + "(Clone)"));
            Destroy(GameObject.Find(tempEnergetico + "(Clone)"));
            Destroy(GameObject.Find(tempConstructor + "(Clone)"));
            
            reguladorBandera = false;
            constructorBandera = false;
            energeticoBandera = false;

            tempConstructor = "";
            tempRegulador = "";
            tempEnergetico = "";*/

        }
        

    }


    public void crearRegulador(string alimento) {

        

        if (alimento == "manzana" || alimento == "platano" || alimento == "mandarina" || alimento == "uvas" || alimento == "brocoli" || alimento == "zanahoria" || alimento == "frutilla")
        {
            
            if(reguladorBandera == false)
            {

                foreach (GameObject objFruta in azulRegulador)
                {
                    if (objFruta.name == alimento)
                    {
                        Instantiate(objFruta, GameObject.Find("Canvas").transform);
                        //tempAlimentos.Add(alimento);
                        
                        tempRegulador = alimento;
                        reguladorBandera = true;
                    }

                }
                
                //print("prueba2");
               
            }
            else
            {
                
                foreach (GameObject objFruta in azulRegulador)
                {   
                    if(objFruta.name == alimento)
                    {
                        if (tempRegulador== alimento)
                        {

                        }
                        else
                        {
                            print(objFruta.name + "");
                            Destroy(GameObject.Find(tempRegulador + "(Clone)"));
                            Instantiate(objFruta, GameObject.Find("Canvas").transform);
                            tempRegulador = alimento;

                        }
                        
                        // Instantiate(objFruta, GameObject.Find("Canvas").transform);




                        /*foreach(string alimentos in tempAlimentos)
                        {
                            if (alimentos == tempFruta)
                            {
                                alimentos.Replace(tempFruta,fruta);
                            }
                        }*/

                    }
                    
                    
                       
                    
                }
               // Destroy(GameObject.Find(tempRegulador + "(Clone)"));
               
                //print("prueba3");

            }

        }


    }


    public void crearConstructor(string alimentoC)
    {

        if (alimentoC == "leche" || alimentoC == "queso" || alimentoC == "huevo")
        {

            if (constructorBandera == false)
            {

                foreach (GameObject objConstructor in rojoConstructor)
                {
                    if (objConstructor.name == alimentoC)
                    {
                        Instantiate(objConstructor, GameObject.Find("Canvas").transform);
                        //tempAlimentos.Add(alimentoC);
                        
                        tempConstructor = alimentoC;
                        constructorBandera = true;
                    }

                }
                
                //print("prueba2");

            }
            else
            {
                
                   
                    
                //print("prueba3");
                foreach (GameObject objConstructor in rojoConstructor)
                {
                    if (objConstructor.name == alimentoC)
                    {

                        if (tempConstructor == alimentoC)
                        {

                        }
                        else
                        {
                            print(objConstructor.name + "");
                            Destroy(GameObject.Find(tempConstructor + "(Clone)"));
                            Instantiate(objConstructor, GameObject.Find("Canvas").transform);
                            tempConstructor = alimentoC;

                        }

                        //Instantiate(objConstructor, GameObject.Find("Canvas").transform);
                        //print("prueba"); 

                        /*foreach(string alimentos in tempAlimentos)
                        {
                            if (alimentos == tempFruta)
                            {
                                alimentos.Replace(tempFruta,fruta);
                            }
                        }*/

                    }
                   

                }
                //Destroy(GameObject.Find(tempConstructor + "(Clone)"));
                //tempConstructor = alimentoC;


            }

        }

    }


    public void crearEnergetico(string alimentoE)
    {

        if (alimentoE == "maduro" || alimentoE == "tortillaverde" || alimentoE == "sanduche" || alimentoE == "aguacate")
        {

            if (energeticoBandera == false)
            {

                foreach (GameObject objEnergetico in amarilloEnergetico)
                {
                    if (objEnergetico.name == alimentoE)
                    {
                        Instantiate(objEnergetico, GameObject.Find("Canvas").transform);
                        //tempAlimentos.Add(alimentoE);
                        
                        tempEnergetico = alimentoE;
                        energeticoBandera = true;
                    }

                }
                
                //print("prueba2");

            }
            else
            {


                foreach (GameObject objEnergetico in amarilloEnergetico)
                {
                    
                    //print("prueba3");
                    if (objEnergetico.name == alimentoE)
                    {
                        if (tempEnergetico == alimentoE)
                        {

                        }
                        else
                        {
                            print(objEnergetico.name + "");
                            Destroy(GameObject.Find(tempEnergetico + "(Clone)"));
                            Instantiate(objEnergetico, GameObject.Find("Canvas").transform);
                            tempEnergetico = alimentoE;

                        }


                        //Instantiate(objEnergetico, GameObject.Find("Canvas").transform);


                        /*foreach(string alimentos in tempAlimentos)
                        {
                            if (alimentos == tempFruta)
                            {
                                alimentos.Replace(tempFruta,fruta);
                            }
                        }*/

                    }

                }
                
                    //Destroy(GameObject.Find(tempEnergetico + "(Clone)"));
                    //tempEnergetico = alimentoE;
                

            }

        }

    }


    public void destruirAlimentos()
    {
        //yield return new WaitForSeconds(2f);
        //yield return new WaitForSecondsRealtime(2f);
        reguladorBandera = false;
        constructorBandera = false;
        energeticoBandera = false;

        Destroy(GameObject.Find(tempRegulador + "(Clone)"));
        Destroy(GameObject.Find(tempEnergetico + "(Clone)"));
        Destroy(GameObject.Find(tempConstructor + "(Clone)"));
        //efectoEstrella();
        tempConstructor = "";
        tempRegulador = "";
        tempEnergetico = "";
        


    }

    /*IEnumerator Esperar(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        //comenzar = true;
    }*/


}
