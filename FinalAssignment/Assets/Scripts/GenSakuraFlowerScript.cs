using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GenSakuraFlowerScript : MonoBehaviour
{
    public GameObject SakuraFlowerPrefab, SakuraPetalPrefabs;

    float checkTime;
    float temp;
    // Start is called before the first frame update
    void Start()
    {
        temp = UnityEngine.Random.Range(0f, 20f);
        checkTime = temp;
        for (int i = 0; i <20; i++)
        {
            spawn(SakuraFlowerPrefab,false);
        }
    }

    private void Update()
    {
        checkTime -= Time.deltaTime;
        
        if(checkTime <= 0)
        {
            spawn(SakuraPetalPrefabs);
            checkTime = temp + 20;
        }
    }

    void spawn(GameObject target, bool isPetal = true)
    {
        GameObject temp = Instantiate(target);
        temp.transform.SetParent(transform);
        temp.transform.localPosition = Random.insideUnitSphere * 1;
        temp.transform.localRotation = Random.rotation;
        if(isPetal)
        {
            temp.transform.localScale = new Vector3(UnityEngine.Random.Range(1f, 2.5f), UnityEngine.Random.Range(1f, 2.5f), UnityEngine.Random.Range(1f, 2.5f))*0.7f;
        }
        else
        temp.transform.localScale = new Vector3(UnityEngine.Random.Range(1f, 2.5f), UnityEngine.Random.Range(1f, 2.5f), UnityEngine.Random.Range(1f, 2.5f));
    }


}
