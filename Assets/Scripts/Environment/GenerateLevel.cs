using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] section;
    private int zPos = 45;
    public bool isCreatingSection = false;
    private int secNum;

    // Update is called once per frame
    void Update()
    {
        if(isCreatingSection == false){
            isCreatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection(){
        secNum = Random.Range(0,section.Length);
        Instantiate(section[secNum], new Vector3(0,0,zPos), transform.rotation);
        zPos += 45;
        yield return new WaitForSeconds(2);
        isCreatingSection = false;
    }
}
