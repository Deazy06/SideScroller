using UnityEngine;



public class PlayerMovement : MonoBehaviour
{
    public float Movementspeed = 5;
    public float JumpForce = 1;

    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * Movementspeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector3(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}