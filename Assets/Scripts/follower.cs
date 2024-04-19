namespace OurGame
{
    using System;
    using UnityEngine;

    public class follower : MonoBehaviour
    {
        [SerializeField] private GameObject objectToFollow;
        
        private int stepsBehind;
    
        // Start is called before the first frame update
        void Start()
        {
            this.stepsBehind = Math.Abs(((int)((this.transform.position.z - objectToFollow.transform.position.z)/0.02)));
        }

        // Update is called once per frame
        void Update()
        {
            this.transform.position = objectToFollow.GetComponent<BasicInput>().GetPosition(stepsBehind);
        }
    }
}