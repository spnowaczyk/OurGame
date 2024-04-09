using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class BasicInput : MonoBehaviour
{
    void addPositionOnWSAD()
    {
        this.transform.position = new Vector3(x, y, z);
        positions.Insert(0, this.transform.position);
    }
    
    private float x;
    private float y;
    private float z;

    public List<Vector3> positions;

    // Start is called before the first frame update
    void Start()
    {
    x = this.transform.position.x;
    y = this.transform.position.y;
    z = this.transform.position.z;

    for (float i = 10; i > 0; i -= 0.02f)
        {
            positions.Insert(0, new Vector3(transform.position.x, this.transform.position.y, x - i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            z += 0.02f;
            addPositionOnWSAD();
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= 0.02f;
            addPositionOnWSAD();
        }
        if (Input.GetKey(KeyCode.S))
        {
            z -= 0.02f;
            addPositionOnWSAD();
        }
        if (Input.GetKey(KeyCode.D))
        {
            x += 0.02f;
            addPositionOnWSAD();
        }
    }
}
