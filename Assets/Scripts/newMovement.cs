using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newMovement : MonoBehaviour
{
    Vector3 mousePosition;
    public float moveSpeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);

    public bool victory;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        victory = false;
    }

    private void Update() //Tar reda p� mouseposition och s�nt -Filip
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
    }

    private void FixedUpdate() //R�r gubben -Filip
    {
        rb.MovePosition(position);
    }

    private void OnCollisionEnter2D(Collision2D collision) //G�r s� att man kan vinna av att r�ra ett objekt med taggen m�l
    {
        if (collision.gameObject.tag == "Goal")
        {
            victory = true;
        } 
    }

}
