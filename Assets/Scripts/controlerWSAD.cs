using UnityEngine;

public class controlerWSAD : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float thrust;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var inputVector = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            inputVector.z += 10f;
        if (Input.GetKey(KeyCode.S))
            inputVector.z -= 10f;
        if (Input.GetKey(KeyCode.A))
            inputVector.x -= 10f;
        if (Input.GetKey(KeyCode.D))
            inputVector.x += 10f;

        inputVector = inputVector.normalized;

        thrust = inputVector.x + inputVector.y + inputVector.z;
        
        _rigidbody.AddForce(inputVector);
        _rigidbody.velocity = _rigidbody.velocity - _rigidbody.velocity * 0.9f * Time.deltaTime;
    }
}
