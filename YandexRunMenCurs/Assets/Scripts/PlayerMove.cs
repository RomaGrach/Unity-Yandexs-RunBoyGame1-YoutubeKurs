using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float _speed = 1.0f;
    private float _oldMousPositionX;
    private float _eulerY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            _oldMousPositionX = Input.mousePosition.x;
        }
        if (Input.GetMouseButton(0)){
            Vector3 newPosition =transform.position + transform.forward * _speed * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.5f, 2.5f);
            transform.position = newPosition;
            float deltax = Input.mousePosition.x - _oldMousPositionX;  // разница между позициями мыши по x
            _oldMousPositionX = Input.mousePosition.x;
            _eulerY += deltax;
            _eulerY = Mathf.Clamp(_eulerY, -70, 70);// ограничение максимального значения
            transform.eulerAngles = new Vector3(0,_eulerY, 0); // поворот
        }

        



        // Input.GetMouseButton(0) - нажатие левой кнопки мыши
        //  transform.forward - единичный вектор направленный по оси z нашего объекта
        //transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
