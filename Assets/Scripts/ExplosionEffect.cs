using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    private Animator animation;
    public ParticleSystem particleEffect;
    public float noCollision = 3f;
    void Start()
    {
        animation = GetComponent<Animator>();
    }


    
    public void EnemyDie(humanSuffering enemy) // Spelar upp Death Partikel och animation
    {
        particleEffect.transform.position = enemy.transform.position;
        particleEffect.Play();

        gameObject.layer = LayerMask.NameToLayer("Ignore Collisions");
        Invoke(nameof(TurnOnCollisions), noCollision);

        animation.SetTrigger("Death");

    }

    private void TurnOnCollisions()
    {
        gameObject.layer = LayerMask.NameToLayer("Player");
    }

}
