using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusSpawner : MonoBehaviour 
{
    #region Enums


    #endregion

    #region Atributos y Propiedades
    public GameObject virusPrefab;
    
	
    #endregion
	
    #region Eventos    
	
	
    #endregion
	
    #region Mensajes Unity
	
	void Start ()
    {
        StartCoroutine(EngendrarViruses());
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
    #endregion

    #region Métodos
    public void SpawnVirus()
    {
        Instantiate(virusPrefab, this.transform.position,virusPrefab.transform.rotation);
    }



    #endregion
    #region CoRutinas

    public IEnumerator EngendrarViruses()
    {
        //Por siempre
        while (true)
        {
            //Instanciar un nuevo Virus, cada 2 segundos por ejemplo
            SpawnVirus();
            yield return new WaitForSeconds(2.0f);
        }
    }
    
    #endregion
}
