using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISkill : MonoBehaviour
{
    [SerializeField] private Image _skillImg;
    public void On()
    { 
        _skillImg.gameObject.SetActive(!_skillImg.gameObject.activeInHierarchy);
    }
}
