using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            PlayerStats.Coin += 1;
            SoundManager.instance.coinSource.PlayOneShot(SoundManager.instance.coinSound);
            Destroy(gameObject);
        }
    }
}
