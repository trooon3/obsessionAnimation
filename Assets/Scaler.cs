using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.localScale = new Vector3(transform.localScale.x + _scaleSpeed * Time.deltaTime, transform.localScale.y + _scaleSpeed * Time.deltaTime, transform.localScale.z + _scaleSpeed * Time.deltaTime);
    }
}
