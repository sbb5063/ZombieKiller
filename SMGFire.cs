using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMGFire : MonoBehaviour
{
    public GameObject TheSMG;
    public GameObject MuzzleFlash;
    public AudioSource SMGSound;
    private int AmmoCount;
    private int firing;

    public GameObject CH;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AmmoCount = GlobalAmmo.LoadedAmmo;
       
       if(GlobalAmmo.LoadedAmmo >= 1)
       {
            if(Input.GetMouseButtonDown(0))
            {
              if(firing == 0)
               {
                 StartCoroutine("SMGFirre");
               }
            }
       }
    }

    IEnumerator SMGFirre()
    {
        firing = 1;
        CH.GetComponent<Animator>().enabled = true;
        GlobalAmmo.LoadedAmmo -= 1;
        SMGSound.Play();
        MuzzleFlash.SetActive(true);
        TheSMG.GetComponent<Animator>().enabled = true;
        
        yield return new WaitForSeconds(0.1f);
        
        MuzzleFlash.SetActive(false);
        TheSMG.GetComponent<Animator>().enabled = false;
        CH.GetComponent<Animator>().enabled = false;
        firing = 0;
    }
}
