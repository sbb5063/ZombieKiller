using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPIckup : MonoBehaviour
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
            GlobalAmmo.LoadedAmmo += 10;
            this.gameObject.SetActive(false);
        }
        else
        {
            GlobalAmmo.CurrentAmmo += 10;
            this.gameObject.SetActive(false);
        }
    }   
}
