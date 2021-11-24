using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CubeGenerator : MonoBehaviour
{
    public int cubesTotal = -1;
    public int cubesInGame = -1;

    [SerializeField] private TMP_Text _totalText;
    [SerializeField] private TMP_Text _inGameText;
    [SerializeField] private Button _RestartButton;

    // Update is called once per frame
    void Update()
    {
        _totalText.text = cubesTotal.ToString();
        _inGameText.text = cubesInGame.ToString();
        if (cubesInGame == 0)
        {
            _RestartButton.enabled = true;
            string DebugText = "_RestartButton" + _RestartButton.enabled.ToString();
            Debug.Log(DebugText);
        }
    }

    public void onRestartClick()
    {
        SceneManager.LoadScene(0);
    }
}
