using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateleft : MonoBehaviour
{
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Target.position, Vector3.down, 10 * Time.deltaTime);
    }
}
