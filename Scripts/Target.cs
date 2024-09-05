using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[Serializable]

public class Target{
	public string Name;
	public GameObject PositionObject;

    public void Playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

