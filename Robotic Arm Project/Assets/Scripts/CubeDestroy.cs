using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("coloredCube"))
        {
            StartCoroutine(DestroyCube());
        }
        IEnumerator DestroyCube()
        {
            yield return new WaitForSeconds(5);
            Destroy(other.gameObject);
        }
    }
}
