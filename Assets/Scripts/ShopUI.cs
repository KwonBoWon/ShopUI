using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class ShopUI : MonoBehaviour
{
    public List<GameObject> merchandises = new List<GameObject>();
    public GameObject money;
    public GameObject merchandiseLayout;
    public GameObject inventoryLayout;
    public static TextMeshProUGUI moneyText;

    // Start is called before the first frame update
    void Start()
    {
        moneyText = money.GetComponent<TextMeshProUGUI>();
        Generate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void AddImage(GameObject image)
    {
        GameObject _parent = GameObject.Find("InventoryLayout");
        Debug.Log(_parent.name);
        var _new = Instantiate(image);

        _new.transform.SetParent(_parent.transform);
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
    

    void Delete()
    {
        Transform[] children = merchandiseLayout.GetComponentsInChildren<Transform>();
        
        foreach (Transform child in children)
        {
            
            if (child.name == merchandiseLayout.name)
            {
                continue;
            }
            //Debug.Log(child);
            Destroy(child.gameObject);
        }
    }
    void Generate()
    {
        Delete();

        List<GameObject> _items = merchandises.ToList();
        for (int i = 0; i < 4; i++)
        {
            int _rand = Random.Range(0, _items.Count);
            var _new =Instantiate(_items[_rand]);

            _new.transform.SetParent(merchandiseLayout.transform);
            GameObject _buy = _new.transform.Find("buy").gameObject;
            //_buy.GetComponent<Button>().onClick.AddListener(Buy);
            _items.RemoveAt(_rand);
        }
        
        
    }

    public void Reroll()
    {
        Generate();
    }
}
