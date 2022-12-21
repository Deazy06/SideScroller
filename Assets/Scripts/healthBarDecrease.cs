using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarDecrease : MonoBehaviour
{
    [SerializeField]
    public Slider timerSlider;
    public float health;
    [SerializeField]
    GameObject player;

    bool stopTimer;

    // Start is called before the first frame update
    void Start()
    {
        
        bool stopTimer = false;
        timerSlider.maxValue = health;
        timerSlider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        float time = health - Time.time;

        if (time < 0)
        {
            stopTimer = true;

            FindObjectOfType<ExplosionEffectPlayer>().PlayerDie(this);

            Destroy(player, 1.5f);

        }

        if (stopTimer == false)
        {
            timerSlider.value = time;
        }
    }

    public void healthRise(humanSuffering humanSuffering)
    {
        this.health += 3;
    }
}
