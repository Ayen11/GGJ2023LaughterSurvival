using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	[SerializeField] private GameObject pauseMenuCanvas;
	private Button _resumeButton;
	private Button _reloadButton;
	private Button _quitToMenu;
	private Button _quitToDesktop;
	private bool _isPaused;


	private void Start()
	{
		Time.timeScale = 1;
		pauseMenuCanvas.SetActive(false);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			TogglePause();
		}
	}

	public void TogglePause()
	{
		_isPaused = !_isPaused;
		if (_isPaused)
		{
			Time.timeScale = 0;
			pauseMenuCanvas.SetActive(true);
		}

		if (!_isPaused)
		{
			Time.timeScale = 1;
			pauseMenuCanvas.SetActive(false);
		}
	}

	public void LoadLevel(int idx)
	{
		SceneManager.LoadSceneAsync(idx);
	}

	public void Quit()
	{
		Application.Quit();
	}
}