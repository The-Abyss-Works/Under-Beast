using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopping : MonoBehaviour
{
    [SerializeField] public ShopSystem shopSystem;
    // Start is called before the first frame update
    public void BuyButton(string name)
    {
        shopSystem.BuySystem(name);
    }
}
