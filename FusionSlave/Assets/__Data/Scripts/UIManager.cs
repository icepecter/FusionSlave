using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Button _startBtn;

    private void Start()
    {
        //_text.gameObject.SetActive(false);
        //_startBtn.gameObject.SetActive(false);
    }

    public void SetText(string text)
    {
        _text.gameObject.SetActive(true);
        _text.text = text;
    } 

    public void BtnActive(bool active)
    { 
        _startBtn.gameObject.SetActive(active);
    }
}
