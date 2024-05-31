using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SakuraPetelMove : MonoBehaviour
{
    public float speed,rotateSpeed;

    private void Start()
    {
        Destroy(gameObject,3f);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
        transform.Rotate(new Vector3(rotateSpeed * Time.deltaTime, rotateSpeed * Time.deltaTime, rotateSpeed * Time.deltaTime));
    }
}
