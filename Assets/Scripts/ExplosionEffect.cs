using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    public ParticleSystem particleEffect;
    void Start()
    {
       
    }


    
    public void EnemyDie(humanSuffering enemy)
    {
        particleEffect.transform.position = enemy.transform.position;
        particleEffect.Play();
    }
}
