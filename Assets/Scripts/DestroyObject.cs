using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collider)
    {
        if (collider.transform.tag == "Player")
        {
            StartCoroutine(destroytime());
        }
    }
    IEnumerator destroytime()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
