using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humanSuffering : MonoBehaviour
{

    [SerializeField]
    healthBarDecrease health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) // d?d n?r r?r spelar'n -Fille Dille Karamell
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject,2.5f);

            FindObjectOfType<healthBarDecrease>().healthRise(this);


            FindObjectOfType<ExplosionEffect>().EnemyDie(this); // Skickar signal till ExplosionEffect
        }
    }

}

