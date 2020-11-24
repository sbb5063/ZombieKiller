using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollow : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TheEnemy;
    float EnemySpeed;
    int AttackTrigger;
    float TargetDistance;
    float AllowedRange = 10f;
    RaycastHit Shot;

    int isAttacking;
    int PainSound;
    public GameObject ScreenFlash;
    public AudioSource Hurt1;
    public AudioSource Hurt2;
    public AudioSource Hurt3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
        {
          TargetDistance = Shot.distance;
          if(TargetDistance < AllowedRange)
           {
              EnemySpeed = 0.01f;
              if(AttackTrigger == 0)
               {
                  TheEnemy.GetComponent<Animation>().Play("Walking");
                  transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, EnemySpeed);
               }
            }
            else
            {
                EnemySpeed = 0f;
                TheEnemy.GetComponent<Animation>().Play("Idle");
            }
        }

        if(AttackTrigger == 1)
        {
            if(isAttacking == 0)
            {
               StartCoroutine(EnemyDamage());
            }
            EnemySpeed = 0f;
            TheEnemy.GetComponent<Animation>().Play("Attacking");
        }
    
    }

    void OnTriggerEnter()
    {
        AttackTrigger = 1;
    }

    void OnTriggerExit()
    {
        AttackTrigger = 0;
    }

    IEnumerator EnemyDamage()
    {
        isAttacking = 1;
        PainSound = Random.Range(1, 4);
        yield return new WaitForSeconds(0.9f);
        ScreenFlash.SetActive(true);
        GlobalHealth.PlayerHealth--;
        if(PainSound == 1)
        {
            Hurt1.Play();
        }

        if(PainSound == 2)
        {
            Hurt2.Play();
        }

        if(PainSound == 3)
        {
            Hurt3.Play();
        }
        yield return new WaitForSeconds(0.07f);
        ScreenFlash.SetActive(false);
        yield return new WaitForSeconds(1);
        isAttacking = 0;

    }

   
}
