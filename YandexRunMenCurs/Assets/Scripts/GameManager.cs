using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;
    [SerializeField] TextMeshProUGUI _LevelText;
    private void Start() {
        _LevelText.text = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    public void Play()
    {
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehaviour>().Play();
    }
    
    
}
