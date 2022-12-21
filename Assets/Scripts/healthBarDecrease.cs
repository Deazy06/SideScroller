using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBarDecrease : MonoBehaviour
{
    [SerializeField]
    float health = 30f;
    [SerializeField]
    Transform timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health += Time.deltaTime;
        
    }
}
