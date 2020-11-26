using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMGAmmoPickUp : MonoBehaviour
{
    public AudioSource Ammopick;
    
    
    void Start()
    {
        
    }
       

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        Ammopick.Play();
        if(GlobalAmmo.LoadedAmmo == 0)
        {
            GlobalAmmo.LoadedAmmo += 30;
            this.gameObject.SetActive(false);
        }
        else
        {
            GlobalAmmo.CurrentAmmo += 30;
            this.gameObject.SetActive(false);
        }    
    }   
}
