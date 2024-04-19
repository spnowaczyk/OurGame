using UnityEngine;

public class Chain : MonoBehaviour
{
    [SerializeField] private GameObject objectToFollow;
    
    private Vector3 objectToFollowPosition;
    private Rigidbody _rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        objectToFollowPosition = objectToFollow.GetComponent<Transform>().position;

        if ((objectToFollowPosition - transform.position).magnitude > 2f)
        {
            _rigidbody.AddForce((objectToFollowPosition - transform.position) * Time.deltaTime * 600f);
        }
        _rigidbody.velocity = _rigidbody.velocity - _rigidbody.velocity * 0.9f * Time.deltaTime;
    }
}
