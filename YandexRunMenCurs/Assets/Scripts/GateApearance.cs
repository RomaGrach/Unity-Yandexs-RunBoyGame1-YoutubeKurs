using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public enum DeformationType {
    Width,
    Height
}
public class GateApearance : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] Image _topImage;
    [SerializeField] Image _glassImage;
    [SerializeField] Color _colorPositive;
    [SerializeField] Color _colorNegative;
    [SerializeField] private GameObject _expandLable;
    [SerializeField] private GameObject _shrinkLable;
    [SerializeField] private GameObject _upLable;
    [SerializeField] private GameObject _downLable;

    public void UpdateVisual(DeformationType _deformationType, int _value) {  // вызывается при изменении параметров
        string prefix = "";
        _text.text= _value.ToString();
        if(_value > 0){
            prefix = "+";
            SetColor(_colorPositive);
        }else if(_value==0){
            SetColor(Color.grey);
        }else{
            SetColor(_colorNegative);
        }
        _text.text= prefix + _value.ToString();

        _expandLable.SetActive(false);
        _shrinkLable.SetActive(false);
        _upLable.SetActive(false);
        _downLable.SetActive(false);

        if (_deformationType == DeformationType.Width){
            
            if (_value > 0){
                _expandLable.SetActive(true);
            }else{
                _shrinkLable.SetActive(true);
            }

        }else if(_deformationType == DeformationType.Height){
            if (_value > 0){
                _upLable.SetActive(true);
            }else{
                _downLable.SetActive(true);
            }
        }
    }

    void SetColor(Color color){
        _topImage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, 0.5f);
    }

    
}
