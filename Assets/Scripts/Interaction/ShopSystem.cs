using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopSystem : MonoBehaviour
{
    [SerializeField] public GameObject shop;
    public GameObject player;
    [SerializeField] public NewPlayer playerStats;
    public string item;
    public int cost;
    public Text notice;
    // Start is called before the first frame update

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerStats = player.GetComponent<NewPlayer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetButtonDown("Submit")) {
            playerStats.frozen = true;
            shop.SetActive(true);
            Cursor.visible = true;
        } 
    }

    public void Close()
    {
        shop.SetActive(false);
        Cursor.visible = false;
        playerStats.frozen = false;
    }

    public void Buy(string name, int cost)
    {
        switch (name)
        {
            case "atk":
                if (NewPlayer.Instance.coins < cost)
                {
                    notice.text = "Insufficent Amount";
                    notice.color = Color.red;
                    break;
                }
                else
                {
                    NewPlayer.Instance.coins -= cost;
                    break;
                }
            case "def":
                if (NewPlayer.Instance.coins < cost)
                {
                    notice.text = "Insufficent Amount";
                    notice.color = Color.red;
                    break;
                }
                else
                {
                    NewPlayer.Instance.coins -= cost;
                    break;
                }
        }
    }
}
