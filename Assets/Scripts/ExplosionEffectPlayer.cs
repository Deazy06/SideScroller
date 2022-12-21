using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffectPlayer : MonoBehaviour
{
    private Animator animation;
    public ParticleSystem particleEffect;
    public float noCollision = 3f;
    void Start()
    {
        animation = GetComponent<Animator>();
    }


    public void PlayerDie(healthBarDecrease healthBarDecrease) // Spelar upp Death Partikel och animation
    {
        particleEffect.transform.position = healthBarDecrease.transform.position;
        particleEffect.Play();
        animation.SetTrigger("PlayerDeath");

    }

}
