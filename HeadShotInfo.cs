using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadShotInfo : MonoBehaviour
{
    float TheDistance = PlayerCast.DistanceFromTarget;
    public Text InfoText;

    void Update()
    {
        TheDistance = PlayerCast.DistanceFromTarget;
    }
  
  
  void OnMouseOver()
   {
       if(TheDistance <= 2)
       {
          StartCoroutine(Headshotinfo());
       }
   }

   IEnumerator Headshotinfo()
   {
       InfoText.text = "Shooting The Enemies In Head \n Kills Them Imediately";
       yield return new WaitForSeconds(5f);
       InfoText.text = "";
       Destroy(gameObject);
   }
}
