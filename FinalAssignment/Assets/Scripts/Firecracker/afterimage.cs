using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afterimage : MonoBehaviour
{
    public GameObject AfterimagePrefabs;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GenImage());
    }

    private IEnumerator GenImage()
    {
        float temp = Random.Range(0, 359);
        float checkTime = 0;
        GameObject after = Instantiate(AfterimagePrefabs);
        after.transform.position = transform.position;
        after.transform.localScale = new Vector3(temp, temp, temp) * 0.005f;
        after.transform.rotation = Quaternion.Euler(temp, temp, temp);
        Destroy(after, 1.5f);
        while(checkTime < 0.1f)
        {
            checkTime += Time.deltaTime;
            yield return null;
        }

        StartCoroutine(GenImage());
    }
}
