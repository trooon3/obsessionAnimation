using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorDotHomework : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
  
    private void Update()
    {
        transform.Rotate(new Vector3(0, _rotateSpeed * Time.deltaTime, 0));
    }
}
