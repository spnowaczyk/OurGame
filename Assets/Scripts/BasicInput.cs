namespace OurGame
{
    using System.Collections.Generic;
    using UnityEngine;

    public class BasicInput : MonoBehaviour
    {
        [SerializeField] private float speed = 2.0f;
        [SerializeField] private List<Vector3> positions;

        public Vector3 GetPosition(int index)
        {
            return positions[index];
        }
    
        // Start is called before the first frame upddate
        private void Start()
        {
            for (float i = 10; i > 0; i -= 0.02f)
            {
                positions.Insert(0, new Vector3(transform.position.x, transform.position.y, transform.position.x - i));
            }
        }

        private void AddPositionOnWSAD(Vector3 inputVector)
        {
            this.transform.position += inputVector * speed * Time.deltaTime;
            positions.Insert(0, this.transform.position);
        }

        // Update is called once per frame
        private void Update()
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

            AddPositionOnWSAD(inputVector);
        }
    }
}

