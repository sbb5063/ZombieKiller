using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GlobalHealth : MonoBehaviour
{
    public static int PlayerHealth = 10;
    public int InternalHealth;
    public Text HealthText;
    void Start()
    {
        
    }

    void Update()
    {
        InternalHealth = PlayerHealth;
        HealthText.text = "Health : " + InternalHealth;
        if(PlayerHealth == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
