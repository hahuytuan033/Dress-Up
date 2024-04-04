using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using FunctionTimer;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _startingSceneTransition;
    [SerializeField] private GameObject _endingSceneTransition;

    private void Start()
    {
        _startingSceneTransition.SetActive(true);
        FunctionTimer.Create(DisableStartingSceneTransition, 5f);
    }

    private void DisableStartingSceneTransition()
    {
         _startingSceneTransition.SetActive(false);
    }

    private void LoadNextLevel()
    {
        // Add your code here to load the next level
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _endingSceneTransition.SetActive(true);
            FunctionTimer.Create(LoadNextLevel, 1.5f);
            SceneManager.LoadScene("Game_1");
        }
    }
}
