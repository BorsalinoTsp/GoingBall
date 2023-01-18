using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelsScript : MonoBehaviour
{
    public static int tutorialLevel,level1,level2,level3,level4,level5,level6,level7,level8,bonusLevel;
    [SerializeField] private Button level1Button,level2Button,level3Button,level4Button,level5Button,level6Button,level7Button,level8Button,bonusLevelButton; 
    void Start()
    {
        tutorialLevel = PlayerPrefs.GetInt("tutorialLevel", 0);
        level1 = PlayerPrefs.GetInt("level1", 0);
        level2 = PlayerPrefs.GetInt("level2", 0);
        level3 = PlayerPrefs.GetInt("level3", 0);
        level4 = PlayerPrefs.GetInt("level4", 0);
        level5 = PlayerPrefs.GetInt("level5", 0);
        level6 = PlayerPrefs.GetInt("level6", 0);
        level7 = PlayerPrefs.GetInt("level7", 0);
        level8 = PlayerPrefs.GetInt("level8", 0);
        bonusLevel = PlayerPrefs.GetInt("bonusLevel", 0);
    }

    void Update()
    {
        if (tutorialLevel == 1)
        {
            level1Button.interactable = true;
        }
        if (level1 == 1)
        {
            level2Button.interactable = true;
        }
        if (level2 == 1)
        {
            level3Button.interactable = true;
        }
        if (level3 == 1)
        {
            level4Button.interactable = true;
        }
        if (level4 == 1)
        {
            level5Button.interactable = true;
        }
        if (level5 == 1)
        {
            level6Button.interactable = true;
        }
        if (level6 == 1)
        {
            level7Button.interactable = true;
        }
        if (level7 == 1)
        {
            level8Button.interactable = true;
        }
        if (level8 == 1)
        {
            bonusLevelButton.interactable = true;
        }


    }
}
