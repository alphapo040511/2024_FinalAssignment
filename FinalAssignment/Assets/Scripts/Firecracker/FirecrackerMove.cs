using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirecrackerMove : MonoBehaviour
{
    public GameObject Core;

    public float Timer;

    public float Force,Speed;

    private Rigidbody Rb,coreRb;

    private bool used;

    // Start is called before the first frame update
    void Start()
    {
        used = false;
        Rb = GetComponent<Rigidbody>();
        Rb.AddForce(Vector3.up * Force * 1000 * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;

        if(Timer <= 0 && !used)
        {
            used = true;
            for (int i = 0; i < 20; i++)
            {
                GameObject temp = Instantiate(Core, transform.position, Quaternion.identity);
                temp.transform.LookAt(Random.insideUnitSphere * 50);
                temp.GetComponent<Rigidbody>().AddForce(temp.transform.up * Speed * 100 * Time.deltaTime);
                Destroy(temp, 1.5f);
            }

            for (int i = 0; i < 20; i++)
            {
                GameObject temp = Instantiate(Core, transform.position, Quaternion.identity);
                temp.transform.LookAt(Random.insideUnitSphere * 100);
                temp.GetComponent<Rigidbody>().AddForce(temp.transform.up * Speed * 200 * Time.deltaTime);
                Destroy(temp, 1.5f);
            }

            Destroy(gameObject);
        }
       
    }
}
