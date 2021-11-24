using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMouseInput : MonoBehaviour
{
    public Transform CubeGenerator;
    public GameObject prefab;
    public Transform DestroyPoint;


    // Start is called before the first frame update
    void OnMouseDown()
    {
        Vector3 pos = CubeGenerator.position;
        Instantiate(prefab, pos, Quaternion.identity);
        Instantiate(prefab, pos, Quaternion.identity);
       
        Destroy(gameObject);

    }

    private void FixedUpdate()
    {
       if (gameObject.transform.position.y < DestroyPoint.position.y)
       {
           Destroy(gameObject);
       }
    }

    void Awake()
    {
       // Debug.Log("Awake");
       CubeGenerator.GetComponent<CubeGenerator>().cubesTotal += 1;
       CubeGenerator.GetComponent<CubeGenerator>().cubesInGame += 1;
    }
    private void OnDestroy()
    {
       CubeGenerator.GetComponent<CubeGenerator>().cubesInGame -= 1;
    }

}
