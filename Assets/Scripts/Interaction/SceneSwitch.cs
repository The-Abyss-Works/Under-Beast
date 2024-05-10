using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    [SerializeField] public GameObject loader;
    public void Yes(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void No()
    {
        loader.SetActive(false);
    }
}
