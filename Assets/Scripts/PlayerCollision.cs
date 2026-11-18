using UnityEngine;

public class PlayerCollision : MonoBehaviour

{
    [SerializeField] private MovementController movementControllerScript;
    void OnCollisonEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.CompareTag("Obstacle"))
        { 
            Debug.Log("On a touché" + collisionInfo.collider.name);
            movementControllerScript.enabled = false;
        }
    }
}
