using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XXX : MonoBehaviour
{

    public Mekik MekikScript;

    public GameObject Meteorlar;

    public float height;

    public float time;

    private void Start()
    {
        StartCoroutine(SpawnObject(time));
    }
    public IEnumerator SpawnObject(float time)
    {
        while (!MekikScript.isDead)
        {
            Instantiate(Meteorlar, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);
        }
        
    }
}
