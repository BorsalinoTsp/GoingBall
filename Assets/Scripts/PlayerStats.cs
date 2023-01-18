using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public static int Coin;
    [SerializeField] private TextMeshProUGUI coinText;
    
    private void Start()
    {
        Coin = PlayerPrefs.GetInt("Coin", 0);
    }
    private void Update()
    {
        coinText.text = Coin.ToString();
    }
}
