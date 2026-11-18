using UnityEngine;

public class PascalCase : MonoBehaviour
{
   [SerializeField] private GameManager gamemanagerScript;
   void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.name);
        {
            if(collider.CompareTag("Player"))
            {
                Debug.Log("Le joueur a atteint la ligne d'arrivée!");
                gamemanagerScript.CompleteLevel();
            }
        }
    }
}
