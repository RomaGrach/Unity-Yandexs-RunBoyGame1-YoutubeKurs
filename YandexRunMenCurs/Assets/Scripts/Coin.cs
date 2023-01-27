using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 180f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,_rotationSpeed * Time.deltaTime,0);
    }
    private void OnTriggerEnter(Collider other) {
        FindObjectOfType<CoinManager>().AddOne();
        Destroy(gameObject);
    }
}
