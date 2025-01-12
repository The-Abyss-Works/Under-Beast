using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] public GameObject loader;
    public void Yes(string name)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(name);
    }

    public void No()
    {
        Time.timeScale = 1f;
        loader.SetActive(false);
    }
}
