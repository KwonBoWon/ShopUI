using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Buy : MonoBehaviour
{
    
    public void BuyItem()
    {
        Debug.Log(this.name);
        GameObject _parent = transform.parent.gameObject;

        GameObject _icon = _parent.transform.Find("Image").gameObject;
        GameObject _price = transform.Find("priceText").gameObject;
        TextMeshPro _priceText = _price.GetComponent<TextMeshPro>();

        ShopUI.moneyText.text = (int.Parse(ShopUI.moneyText.text) - int.Parse(_priceText.text)).ToString();

        _parent.SetActive(false);

    }
    public void BuyNotePad()
    {
        GameObject _parent = GameObject.Find("NotePad(Clone)");

        GameObject _icon = _parent.transform.Find("Image").gameObject;
        ShopUI.AddImage(_icon);

        GameObject _buy = _parent.transform.Find("buy").gameObject;
        GameObject _price = _buy.transform.Find("priceText").gameObject;
        TextMeshProUGUI _priceText = _price.GetComponent<TextMeshProUGUI>();

        ShopUI.moneyText.text = (int.Parse(ShopUI.moneyText.text) - int.Parse(_priceText.text)).ToString();

        Transform[] children = _parent.GetComponentsInChildren<Transform>();

        foreach (Transform child in children)
        {

            if (child.name == _parent.name)
            {
                continue;
            }
            //Debug.Log(child);
            child.gameObject.SetActive(false);
        }
    }
    public void BuyWand()
    {
        GameObject _parent = GameObject.Find("Wand(Clone)");

        GameObject _icon = _parent.transform.Find("Image").gameObject;
        ShopUI.AddImage(_icon);

        GameObject _buy = _parent.transform.Find("buy").gameObject;
        GameObject _price = _buy.transform.Find("priceText").gameObject;
        TextMeshProUGUI _priceText = _price.GetComponent<TextMeshProUGUI>();

        ShopUI.moneyText.text = (int.Parse(ShopUI.moneyText.text) - int.Parse(_priceText.text)).ToString();

        Transform[] children = _parent.GetComponentsInChildren<Transform>();

        foreach (Transform child in children)
        {

            if (child.name == _parent.name)
            {
                continue;
            }
            //Debug.Log(child);
            child.gameObject.SetActive(false);
        }
    }
    public void BuyRoseKnife()
    {
        GameObject _parent = GameObject.Find("RoseKnife(Clone)");

        GameObject _icon = _parent.transform.Find("Image").gameObject;
        ShopUI.AddImage(_icon);

        GameObject _buy = _parent.transform.Find("buy").gameObject;
        GameObject _price = _buy.transform.Find("priceText").gameObject;
        TextMeshProUGUI _priceText = _price.GetComponent<TextMeshProUGUI>();

        ShopUI.moneyText.text = (int.Parse(ShopUI.moneyText.text) - int.Parse(_priceText.text)).ToString();

        Transform[] children = _parent.GetComponentsInChildren<Transform>();

        foreach (Transform child in children)
        {

            if (child.name == _parent.name)
            {
                continue;
            }
            //Debug.Log(child);
            child.gameObject.SetActive(false);
        }
    }
    public void BuyShootingStar()
    {
        GameObject _parent = GameObject.Find("ShootingStar(Clone)");

        GameObject _icon = _parent.transform.Find("Image").gameObject;
        ShopUI.AddImage(_icon);

        GameObject _buy = _parent.transform.Find("buy").gameObject;
        GameObject _price = _buy.transform.Find("priceText").gameObject;
        TextMeshProUGUI _priceText = _price.GetComponent<TextMeshProUGUI>();

        ShopUI.moneyText.text = (int.Parse(ShopUI.moneyText.text) - int.Parse(_priceText.text)).ToString();

        Transform[] children = _parent.GetComponentsInChildren<Transform>();

        foreach (Transform child in children)
        {

            if (child.name == _parent.name)
            {
                continue;
            }
            //Debug.Log(child);
            child.gameObject.SetActive(false);
        }
    }
    public void BuyWrench()
    {
        GameObject _parent = GameObject.Find("Wrench(Clone)");

        GameObject _icon = _parent.transform.Find("Image").gameObject;
        ShopUI.AddImage(_icon);

        GameObject _buy = _parent.transform.Find("buy").gameObject;
        GameObject _price = _buy.transform.Find("priceText").gameObject;
        TextMeshProUGUI _priceText = _price.GetComponent<TextMeshProUGUI>();

        ShopUI.moneyText.text = (int.Parse(ShopUI.moneyText.text) - int.Parse(_priceText.text)).ToString();

        Transform[] children = _parent.GetComponentsInChildren<Transform>();

        foreach (Transform child in children)
        {

            if (child.name == _parent.name)
            {
                continue;
            }
            //Debug.Log(child);
            child.gameObject.SetActive(false);
        }
    }

}