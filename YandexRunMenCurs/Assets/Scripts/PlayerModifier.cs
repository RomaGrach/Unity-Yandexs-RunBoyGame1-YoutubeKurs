using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifier : MonoBehaviour
{
    [SerializeField] int _width;
    [SerializeField] int _height;
    float _widthMultiplayer = 0.0005f;
    float _heightMultiplayer = 0.01f;
    [SerializeField] Renderer _renderer;
    [SerializeField] Transform _topSpine;
    [SerializeField] Transform _bottomSpine;
    [SerializeField] Transform _colliderTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float offsetY = _height * _heightMultiplayer +0.17f;
        _topSpine.position = _bottomSpine.position + new Vector3(0,offsetY,0);
        _colliderTransform.localScale = new Vector3(1,1.84f + _height * _heightMultiplayer ,1);

        if (Input.GetKeyDown(KeyCode.W)){
            AddWidth(20);
        }
        if (Input.GetKeyDown(KeyCode.H)){
            AddHeight(20);
        }
    }

    public void AddWidth(int value) {
        _width += value;
        _renderer.material.SetFloat("_PushValue", _width * _widthMultiplayer);
    }
    public void AddHeight(int value) {
        _height += value;
    }
    
    
}
