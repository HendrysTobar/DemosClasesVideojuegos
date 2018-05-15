using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour 
{
    #region Enums


    #endregion

    #region Atributos y Propiedades
    public GameObject bala;
    public Transform punta;
	
    #endregion
	
    #region Eventos    
	
	
    #endregion
	
    #region Mensajes Unity
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    #endregion

    public void Disparar()
    {
        Animator anim = GetComponent<Animator>();
        
        anim.Play("Disparar");
    }

    #region Métodos
    public void Boom()
    {
        Instantiate(bala, punta.position,bala.transform.rotation);
    }
	
    #endregion
    #region CoRutinas
	
	
	#endregion
}
