using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    [SerializeField] float scaleMin;
    [SerializeField] float scaleMax;
    [SerializeField] float scaleTime;

    bool isGrowing=true;
    void Start()
    {
        transform.localScale= new Vector3 (scaleMin,scaleMin,scaleMin);
        StartCoroutine(growPlant());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator growPlant()
    {
        if (isGrowing)
        {
            while (transform.localScale.y < scaleMax) {
                transform.localScale += new Vector3(scaleTime, scaleTime, scaleTime);
                yield return new WaitForSeconds(0.1f);

            }
            yield return null;

        }
        else
        {
            yield return null;
        }

    }
}
