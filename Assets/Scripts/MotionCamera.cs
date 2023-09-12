using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionCamera : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    [SerializeField] private Transform _target;
    [SerializeField] private float _mouseSensitivity = 3f;
    
    private float rotationY;
    private float _angleToTarget = 30;
    private float _distanceFromTarget = 13;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxis("Mouse X") * _mouseSensitivity;
        rotationY += X;
        
        _mainCamera.transform.localEulerAngles = new Vector3 (_angleToTarget, rotationY, 0);
        transform.position = _target.position - transform.forward * _distanceFromTarget;

    }
}
