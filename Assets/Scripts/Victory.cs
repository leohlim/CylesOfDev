using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
    private Text canvasText = null;
    public GameObject VictoryCanvas;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entered");
        canvasText = VictoryCanvas.GetComponentInChildren<Text>(); ;
        VictoryCanvas.SetActive(true);   
        StartCoroutine("Wait");
            
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
