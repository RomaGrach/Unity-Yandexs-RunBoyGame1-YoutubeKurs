using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Runtime.InteropServices;

public class GameManager : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();
    [SerializeField] private GameObject _startMenu;
    [SerializeField] TextMeshProUGUI _LevelText;
    [SerializeField] GameObject _finishWindow;
    [SerializeField] CoinManager _coinManager;

    private void Start() {
        if ((SceneManager.GetActiveScene().buildIndex+1) % 3 == 0)
        {
            ShowAdv();
        }
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
