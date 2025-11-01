using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YYY : MonoBehaviour
{
   

    public GameObject Benzin;

    public float height;

    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {
       
        {
            Instantiate(Benzin, new Vector3(3, -3, 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }

    }
}
