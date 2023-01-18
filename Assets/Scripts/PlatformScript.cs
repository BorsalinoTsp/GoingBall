using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    Animator pAnim;

    private void Start()
    {
        pAnim = GetComponent<Animator>();
    }

    private void OnCollisionEnter(Collision collider)
    {
        if (collider.transform.tag == "Player")
        {
            pAnim.SetTrigger("PlatformDown");
        }
    }
}
