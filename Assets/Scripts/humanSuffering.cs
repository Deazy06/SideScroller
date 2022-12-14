using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanSuffering : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) // död när rör spelar'n -Fille Dille Karamell
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

}

