
using UnityEngine;

public class MovementController : MonoBehaviour
{
    [SerializeField] private float speed = 10.2f;
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private Vector3 movement;

    void Update()
    {
        movement = Vector3.zero;

        if (Input.GetKey(KeyCode.Z))
        {
            
            movement.z += 1;
        }

        if (Input.GetKey(KeyCode.S))
        {
            movement.z -= 1;
        }

        if (Input.GetKey(KeyCode.Q))
        {
            movement.x -= 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            movement.x += 1;
        }
    }

    void FixedUpdate()
    {
        Vector3 direction = movement.normalized;

        Vector3 newPosition = rbPlayer.position
            + direction * speed * Time.fixedDeltaTime;

        rbPlayer.MovePosition(newPosition);
    }
}
