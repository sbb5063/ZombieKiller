using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossHairAnim : MonoBehaviour
{
    public GameObject CH;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GlobalAmmo.LoadedAmmo >= 1)
        {
           if(Input.GetMouseButtonDown(0))
           {
                StartCoroutine("WaitingAnim");
           }

        }
    }    

   IEnumerator WaitingAnim()
    {
        CH.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        CH.GetComponent<Animator>().enabled = false;
    }
}
