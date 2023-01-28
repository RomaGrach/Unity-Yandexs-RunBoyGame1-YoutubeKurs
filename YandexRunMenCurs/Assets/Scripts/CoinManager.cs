using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _NumberOfCoinsInLevel;
    [SerializeField] TextMeshProUGUI _text;
    
    public void AddOne(){
        _NumberOfCoinsInLevel += 1;
        _text.text = _NumberOfCoinsInLevel.ToString();
    }
}
