using System;
using UnityEditor;
using UnityEngine;

namespace OurGame
{
    public class Chain : MonoBehaviour
    {
        [SerializeField] private GameObject objectToFollow;
        [SerializeField] private float distance = 2f;

        private new Rigidbody rigidbody;
        
        private void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            Vector3 vectorBetweenObjects = objectToFollow.transform.position - transform.position;
            float magnitude = vectorBetweenObjects.magnitude;
            if (magnitude > distance)
                transform.position += vectorBetweenObjects.normalized * (magnitude - distance);
        }

        private void OnDrawGizmos()
        {
            if (objectToFollow != null)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawLine(transform.position, objectToFollow.transform.position);
            }
        }
    }
}