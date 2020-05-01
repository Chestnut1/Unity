using System.Collections;
using System.Collections.Generic;
using UnityEngine;  //unity library

public class spawner : MonoBehaviour
{
    [SerializeField]    //ispactor can see this
    GameObject cubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("sono spawnato>> " + gameObject.name, gameObject);    //linked to associated game object
        Instantiate(cubePrefab);
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))   //0 = left clicke released
        {
            Instantiate(cubePrefab, new Vector3(Random.Range(-5,5), Random.Range(-5, 5), Random.Range(-5, 5)), cubePrefab.transform.rotation);
        }
    }
}
