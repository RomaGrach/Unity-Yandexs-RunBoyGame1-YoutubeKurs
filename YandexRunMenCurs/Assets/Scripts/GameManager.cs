using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _startMenu;
    [SerializeField] TextMeshProUGUI _LevelText;
    [SerializeField] GameObject _finishWindow;
    [SerializeField] CoinManager _coinManager;

    private void Start() {
        _LevelText.text = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    public void Play()
    {
        _startMenu.SetActive(false);
        FindObjectOfType<PlayerBehaviour>().Play();
#if UNITY_WEBGL
        Progress.Instance.Save();
#endif
    }

    public void ShowFinishWindow()
    {
        _finishWindow.SetActive(true);
    }

    public void NextLevel()
    {
        int next = SceneManager.GetActiveScene().buildIndex + 1;
        if (next < SceneManager.sceneCountInBuildSettings)
        {
            _coinManager.SaveToProgress();
            Progress.Instance.PlayerInfo.Level = SceneManager.GetActiveScene().buildIndex;
            Progress.Instance.Save();
            SceneManager.LoadScene(next);
        }
    }

}
