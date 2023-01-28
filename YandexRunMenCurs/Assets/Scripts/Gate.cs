using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField]int _value;
    [SerializeField] DeformationType _deformationType; // вызов другого скрипта
    public GateApearance _gateApearance;
    private void OnValidate() {
        _gateApearance.UpdateVisual(_deformationType, _value);
    }
    
}
