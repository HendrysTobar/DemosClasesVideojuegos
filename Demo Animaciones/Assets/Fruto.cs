using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruto : MonoBehaviour 
{
	#region Enums
	
	
    #endregion
	
    #region Atributos y Propiedades
	
	
    #endregion
	
    #region Eventos    
	
	
    #endregion
	
    #region Mensajes Unity
	
	void Start ()
    {
        Rigidbody rgb = GetComponent<Rigidbody>();
        rgb.AddForce(100 * Vector3.one);
        Destroy(this.gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	#endregion
	
    #region Métodos
	
	
    #endregion
    #region CoRutinas
	
	
	#endregion
}
