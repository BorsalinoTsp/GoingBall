using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScript : MonoBehaviour
{
    [SerializeField] GameObject tutorialText;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            tutorialText.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (collision.transform.tag == "Player")
        {
            tutorialText.SetActive(false);
        }
    }
}
