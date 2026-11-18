using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] private Transform transformPlayer;
    [SerializeField] private TextMeshProUGUI scoreText;
    void Update()
    {
        scoreText.text ="Score: " + transformPlayer.position.z.ToString("0");
    }
}
