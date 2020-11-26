using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour
{
    int DamageAmount = 5;
    float TargetDistance;
    float AllowedRange = 15f;
    RaycastHit hit;
    public GameObject Bullet;
    public GameObject Blood;
    public GameObject GreenBlood;

    void Start()
    {
        DamageAmount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalAmmo.LoadedAmmo >= 1)
        {
         if(Input.GetMouseButtonDown(0))
         {
            RaycastHit Shot;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
            {
                TargetDistance = Shot.distance;
                if(TargetDistance < AllowedRange)
                {
                  
                  if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
                  {
                    if(hit.transform.tag == "Zombie")
                    {
                        Instantiate(Blood, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                    }
                    if(hit.collider.tag == "ZombieHead")
                    {
                        DamageAmount = 10;
                        Instantiate(Blood, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                    }
                    if(hit.transform.tag == "Spider")
                    {
                        Instantiate(GreenBlood, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                    }
                    if(hit.transform.tag == "Untagged")
                    {
                        Instantiate(Bullet, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                    }    
                  
                  }
                  Shot.transform.SendMessage("DeductPoint", DamageAmount, SendMessageOptions.DontRequireReceiver);
                  DamageAmount = 5;
                }
            
            }
         
         }

        
        }
   
    }   



}
