using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Victory : MonoBehaviour
{
     [SerializeField]
    private Text canvasText = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            {
                canvasText.text = "Cycle One Complete!";
                NextLevel();
            
            }
    }

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
