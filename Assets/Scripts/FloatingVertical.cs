namespace OurGame
{
    using System;
    using UnityEngine;

    public class FloatingVertical : MonoBehaviour
    {
        [SerializeField] private float yPosCenter;
        private void Update()
        {
            var position = transform.position;
            position.y = (float)Math.Sin(Time.time) + yPosCenter;
            transform.position = position;
        }
    }
}