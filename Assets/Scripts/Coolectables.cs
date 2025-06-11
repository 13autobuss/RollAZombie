using UnityEngine;
using System.Collections;

public class Coolectables : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    public GameObject[] zombies;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collect"))
        {
            gameManager.AddScore();
            gameManager.scoreText.text = "Score: " + gameManager.score;
            Destroy(other.gameObject);
        }
    }

//  private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Death"))
//         {
//             Destroy(gameObject);
//         }
//     }
    

}
