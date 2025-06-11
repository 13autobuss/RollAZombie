using UnityEngine;
using System.Collections;

public class fightingforlife : MonoBehaviour
{
     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Death"))
        {
            GameManager.gameManagerStatic.zombieCount -= 1;
            this.gameObject.SetActive(false);
        }
    }
}
