using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorAnim : MonoBehaviour
{

    public Text PressButton;
    float TheDistance = PlayerCast.DistanceFromTarget;
    public GameObject TheDoor;
    public GameObject objectivecomplete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCast.DistanceFromTarget;
        
    }

    void OnMouseOver()
    {
        if(TheDistance <= 2)
        {
            PressButton.text = "Press Button";
        }

        if(Input.GetButtonDown("Action"))
        {
            if(TheDistance <= 2)
            {
                StartCoroutine("OpenDoor");
                objectivecomplete.SetActive(true);
            }
        }
    }

    void OnMouseExit()
    {
        PressButton.text = "";
    }    

    IEnumerator OpenDoor()
    {
        TheDoor.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1f);
        TheDoor.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(5f);
        TheDoor.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1f);
        TheDoor.GetComponent<Animator>().enabled = false;

    }
}
