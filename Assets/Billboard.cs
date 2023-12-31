using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    [SerializeField]
    private Transform upVectorTransform;
    
    private void Update()
    {
        transform.LookAt(transform.position - (Camera.main.transform.position - transform.position).normalized, upVectorTransform.up);
    }
}
