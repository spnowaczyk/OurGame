using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class follower : MonoBehaviour
{
    public GameObject objectToFollow;
    public int stepsBehind;
    
    // Start is called before the first frame update
    void Start()
    {
        this.stepsBehind = Math.Abs(((int)((this.transform.position.z - objectToFollow.transform.position.z)/0.02)));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = objectToFollow.GetComponent<BasicInput>().positions[stepsBehind];
        this.transform.position = position;

    }
}
