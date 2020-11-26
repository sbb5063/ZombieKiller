using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunRelaod : MonoBehaviour
{
    public AudioSource RelaodSound;
    public GameObject CrossObject;
    public GameObject MechanicsObject;
    int ClipCount;
    int ReserveCount;
    int ReloadAvailable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ClipCount = GlobalAmmo.LoadedAmmo;
        ReserveCount = GlobalAmmo.CurrentAmmo;
        if(ReserveCount == 0)
        {
           ReloadAvailable = 0;
        }
        else
        {
            ReloadAvailable = 10 - ClipCount;
        }

        if(Input.GetButtonDown("Relaod"))
        {
            if(ReloadAvailable >= 1)
            {
                if(ReserveCount <= ReloadAvailable)
                {
                    GlobalAmmo.LoadedAmmo += ReserveCount; 
                    GlobalAmmo.CurrentAmmo -= ReserveCount;
                    ActionReload();
                }
                else
                {
                    GlobalAmmo.LoadedAmmo += ReloadAvailable; 
                    GlobalAmmo.CurrentAmmo -= ReloadAvailable;
                    ActionReload();
                }

            }    
        }

        Invoke("EnableScripts", 1.1f);
    }

    void ActionReload()
    {
        this.GetComponent<Gunfire>().enabled = false;
        CrossObject.SetActive (false);
        MechanicsObject.SetActive (false);
        RelaodSound.Play();
        GetComponent<Animation>().Play("HandGunRelaod");
    }

    void EnableScripts()
    {
        this.GetComponent<Gunfire>().enabled = true;
        CrossObject.SetActive (true);
        MechanicsObject.SetActive (true);
    }
}
