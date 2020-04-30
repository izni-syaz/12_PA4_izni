using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCubeScene : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("coroutine");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator coroutine()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("CubeScene");
    }
}
