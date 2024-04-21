namespace OurGame
{
    using UnityEngine;
    public class controlerWSAD : MonoBehaviour
    {
        [SerializeField] private float snakeSpeed;
        
        private Rigidbody _rigidbody;
        void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        
        void Update()
        {
            var inputVector = Vector3.zero;

            if (Input.GetKey(KeyCode.W))
                inputVector.z += 1f;
            if (Input.GetKey(KeyCode.S))
                inputVector.z -= 1f;
            if (Input.GetKey(KeyCode.A))
                inputVector.x -= 1f;
            if (Input.GetKey(KeyCode.D))
                inputVector.x += 1f;

            inputVector = inputVector.normalized;

            transform.position += inputVector * Time.deltaTime * snakeSpeed;
        }
    }
}
