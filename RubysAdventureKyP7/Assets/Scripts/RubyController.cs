using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertcal = Input.GetAxis("Vertical");

        Vector2 position = transform.position;
        position.x = position.x  + 5.0f * horizontal * Time.deltaTime;
        position.y = position.y  + 5.0f * vertcal * Time.deltaTime;
        transform.position = position;
    }
}
