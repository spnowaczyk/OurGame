using System;
using UnityEngine;

public class FloatingVertical : MonoBehaviour
{
    private Transform _transform;
    private Vector3 tempPos;

    [SerializeField] private float yPosCenter;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = _transform.position;
        tempPos.y = (float)Math.Sin(Time.time) + yPosCenter;
        _transform.SetPositionAndRotation(tempPos, _transform.rotation);
    }
}
