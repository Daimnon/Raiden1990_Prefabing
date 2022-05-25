using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryPlayerController : MonoBehaviour
{
    [SerializeField] float _moveSpeed = 1f;

    void Update()
    {
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal > 0)
            transform.position += new Vector3(_moveSpeed * Time.deltaTime, 0f, 0f);
        
        if (horizontal < 0)
            transform.position += new Vector3(-_moveSpeed * Time.deltaTime, 0f, 0f);
        
        if (vertical > 0)
            transform.position += new Vector3(0f, _moveSpeed * Time.deltaTime, 0f);
        
        if (vertical < 0)
            transform.position += new Vector3(0f, -_moveSpeed * Time.deltaTime, 0f);
    }
}
