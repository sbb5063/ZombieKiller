using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gunfire : MonoBehaviour
{
    Animation GunshootAnim;
    AudioSource GunShoot;
    public GameObject Flash;
    public GameObject realSMG;
    public GameObject gunlabel;
    void Start()
    {
        GunshootAnim = GetComponent<Animation>();
        GunShoot = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(GlobalAmmo.LoadedAmmo >= 1)
       {
            if(Input.GetMouseButtonDown(0))
            {
               GunShoot.Play();
               Flash.SetActive(true);
               Invoke("MuzzleOff", 0.1f);
               GunshootAnim.Play("Gunshoot");
               GlobalAmmo.LoadedAmmo --;
            }
       }

       if(realSMG.activeInHierarchy)
       {
           gunlabel.SetActive(false);
       }

    }

    void MuzzleOff()
    {
        Flash.SetActive(false);
    }   
}
 