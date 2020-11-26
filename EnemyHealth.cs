using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    int EnemyHelth = 10;
    public GameObject TheZombie;
    public GameObject objectivecomplete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void DeductPoint(int DamageAmount)
    {
        EnemyHelth -= DamageAmount;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(EndZombie());
    }

    IEnumerator EndZombie()
    {
        if(EnemyHelth <= 0)
        {
            this.GetComponent<ZombieFollow>().enabled = false;
            TheZombie.GetComponent<Animation>().Play("Dying");
            objectivecomplete.SetActive(true);
            yield return new WaitForSeconds(3);
            Destroy(gameObject);
        }  
    }
}
