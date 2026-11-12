using UnityEngine;

public class MOVEMENT_CONTROLLER : MonoBehaviour
{ 
    [SerializeField] private float speed = 10.2f;
    [SerializeField] private Rigidbody rbPlayer;
    [SerializeField] private Vector3 movement;

   
    void FixedUpdate ()
    {
        rbPlayer.AddForce(0.0f, 0.0f, speed);
        if (Input.)
        {

        }
        else()
        {
²           Vectore3 movement = direction.normalized;
            transform.position += movement * (Time.deltaTime * speed);
        }
    }
}
