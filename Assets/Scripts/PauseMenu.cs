﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject pauseMenu;
    public static bool isPaused;

    // Start is called before the first frame update
    void Start() {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("Cancel")) {
            if (isPaused) {
                Debug.Log("pause balls by going downstairs");
                ResumeGame();
            } else {
                Debug.Log("pause balls by going upstairs");
                PauseGame();
            }
        }
    }

    public void PauseGame() {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void RestartGame() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level1");
    }

    public void GoToMainMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }
}
