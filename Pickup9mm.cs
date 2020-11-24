using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup9mm : MonoBehaviour
{
    float TheDistance = PlayerCast.DistanceFromTarget;
    public Text PressButton;
    public GameObject GunName;
    public GameObject RealGun;
    public GameObject FakeGun;
    public AudioSource PickUpAudio;
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
            PressButton.text = "Take 9mm Pistol";
        }

        if(Input.GetButtonDown("Action"))
        {
            if(TheDistance <= 2)
            {
                TakeNineMM();
                objectivecomplete.SetActive(true);
               
            }
        }
    }

    void OnMouseExit()
    {
        PressButton.text = "";
    }    

    void  TakeNineMM()
    {
        PickUpAudio.Play();
        transform.position = new Vector3(0, -1000 , 0);
        FakeGun.SetActive(false);
        RealGun.SetActive(true);
        GunName.SetActive(true);
    }
}
