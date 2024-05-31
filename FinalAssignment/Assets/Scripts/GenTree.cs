using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenTree : MonoBehaviour
{
    public GameObject TreeTrunkPrefabs,TreeOffshoot,GenSakuraPrefab;
    public int GenCount;

    private Vector3 BeforePos;

    // Start is called before the first frame update
    void Start()
    {
        BeforePos = transform.position;

        for(int i = 0; i <UnityEngine.Random.Range(4,6); i++)
        {
            GameObject temp = Instantiate(TreeTrunkPrefabs);
            temp.transform.parent = transform;
            temp.transform.localScale = new Vector3((1 - i * 0.05f), 1.7f, (1 - i * 0.05f))*2.5f;
            temp.transform.position = new Vector3(BeforePos.x + UnityEngine.Random.Range(-0.01f,0.01f), BeforePos.y, BeforePos.z + UnityEngine.Random.Range(-0.01f, 0.01f));
            temp.transform.rotation = transform.rotation;
            BeforePos = temp.transform.GetChild(0).transform.position;
            if(GenCount > 1 && i % 3 != 0)
            {
                GameObject temp2 = Instantiate(GenSakuraPrefab);
                temp2.transform.SetParent(transform);
                temp2.transform.localPosition = Random.insideUnitSphere * 15;
                temp2.transform.localRotation = Random.rotation;
            }
        }

        if(GenCount < 3)
        {
            GameObject temp = Instantiate(TreeOffshoot);
            temp.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f)/(GenCount * 3);
            temp.transform.position = new Vector3(BeforePos.x + UnityEngine.Random.Range(-0.01f, 0.01f), BeforePos.y, BeforePos.z + UnityEngine.Random.Range(-0.01f, 0.01f));
            BeforePos = temp.transform.GetChild(0).transform.position;
            temp.transform.SetParent(transform);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
