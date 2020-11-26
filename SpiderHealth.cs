using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderHealth : MonoBehaviour
{
   int EnemyHelth = 10;
    public GameObject TheSpider;
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
            this.GetComponent<SpiderFollow>().enabled = false;
            TheSpider.GetComponent<Animation>().Play("die");
            objectivecomplete.SetActive(true);
            yield return new WaitForSeconds(3);
            EnemyHelth = 1;
        }  
    }
}
