using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] List<GameObject> checkPoints;
    [SerializeField] Vector3 vectorPoint;
    [SerializeField] float dead;
    [SerializeField] int ballHealth = 3;
    [SerializeField] int numOfHearths;
    [SerializeField] GameObject gameoverPanel;
    [SerializeField] Image[] hearts;
    [SerializeField] Sprite fullHearth;
    [SerializeField] Sprite emptyHearth;

    void Start()
    {
        gameoverPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }
    void Update()
    {

        if(ballHealth > numOfHearths)
        {
            ballHealth = numOfHearths;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < ballHealth) 
            {
            hearts[i].sprite = fullHearth;
            } else
            {
                hearts[i].sprite = emptyHearth;
            }

            if (i < numOfHearths)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }
                
        }

        if (player.transform.position.y < -dead)
        {
            player.transform.position = vectorPoint;
            ballHealth -= 1;
        }

        if (ballHealth == 0)
        {
            gameoverPanel.SetActive(true);
            Time.timeScale = 0f;
        }

        if (ballHealth >= 3)
        {
            ballHealth = 3;
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "CheckPoint")
        {
            vectorPoint = player.transform.position;
            ballHealth += 1;
            Destroy(collision.gameObject);
        }
    }
}
