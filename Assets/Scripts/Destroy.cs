using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(DestroySelf());
    }

    private IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }
}
