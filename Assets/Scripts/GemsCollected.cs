using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemsCollected : MonoBehaviour
{
    [SerializeField] private int _currentItems;
    [SerializeField] private TMP_Text _itemText;
    [SerializeField] private GameObject _gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        _itemText.text = "" + _currentItems;
    }

    public void ShowGameOverScreen() {
        _gameOverScreen.SetActive(true);
    }

    public void CollectItem(Collider2D other){
        GameObject sphere = other.gameObject;
        Destroy(sphere);
        _currentItems++;
        _itemText.text = "" + _currentItems;
    }
}
