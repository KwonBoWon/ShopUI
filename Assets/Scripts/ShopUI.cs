using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShopUI : MonoBehaviour
{
    public List<GameObject> merchandises = new List<GameObject>();
    public GameObject money;
    public GameObject merchandiseLayout;
    public GameObject inventoryLayout;
    public TextMeshPro moneyText;

    // Start is called before the first frame update
    void Start()
    {
        moneyText = money.GetComponent<TextMeshPro>();
        moneyText.text = "100000";
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Buy()
    {
        GameObject _parent = transform.parent.gameObject;
        GameObject _icon =  _parent.transform.Find("Image").gameObject;
        GameObject _price =  transform.Find("priceText").gameObject;
        TextMeshPro _priceText = _price.GetComponent<TextMeshPro>();

        moneyText.text = (int.Parse(moneyText.text) - int.Parse(_priceText.text)).ToString();

        _parent.SetActive(false);
        
    }

    void Generate()
    {
        Instantiate(merchandises[0]);
    }

    void Reroll()
    {
        Generate();
    }
}
