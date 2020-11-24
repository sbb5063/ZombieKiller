using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutScene01 : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject TheUI;
    public GameObject Cam01;
    public GameObject Cam02;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CutSceneBegin());
    }

    IEnumerator CutSceneBegin()
    {
        yield return new WaitForSeconds(4.5f);
        Cam02.SetActive(true);
        Cam01.SetActive(false);
        yield return new WaitForSeconds(4.5f);
        ThePlayer.SetActive(true);
        TheUI.SetActive(true);
    }
}
