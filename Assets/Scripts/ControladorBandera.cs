using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorBandera : MonoBehaviour {

    public bool bandera = false;
    public string tempNombre;
    public bool niv1 = false;
    public bool niv2 = false;
    public bool niv3 = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Awake()
    {
        {
            DontDestroyOnLoad(this);

            if (FindObjectsOfType(GetType()).Length > 1)
            {
                Destroy(gameObject);
            }
        }
    }
}