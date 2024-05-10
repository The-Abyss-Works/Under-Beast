using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] public GameObject loader;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"));
        {
            loader.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        loader.SetActive(false);
    }

}
