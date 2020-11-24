using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmo : MonoBehaviour
{
   
    public static int CurrentAmmo;
    public int InternalAmmo;
    public Text AmmoText;

    public static int LoadedAmmo;
    public int InternalLoaded;
    public Text LoadedText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InternalAmmo = CurrentAmmo;
        AmmoText.text = " " + InternalAmmo;

        InternalLoaded = LoadedAmmo;
        LoadedText.text = " " + InternalLoaded;
    }
}
