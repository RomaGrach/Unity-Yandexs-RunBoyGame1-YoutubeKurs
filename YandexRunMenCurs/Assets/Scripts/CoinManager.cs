using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _NumberOfCoinsInLevel;
    
    public void AddOne(){
        _NumberOfCoinsInLevel += 1;
    }
}
