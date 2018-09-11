using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public GameObject attack;

    public float timer;

    void Start()
    {
        attack.SetActive(false);  
    }

    void Update()
    {
        timer += 1.0f * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.J))
        {
            attack.SetActive(true);
            if(timer >= 1)
            {
                GameObject.Destroy(attack);
            }
        }
    }
    
}
