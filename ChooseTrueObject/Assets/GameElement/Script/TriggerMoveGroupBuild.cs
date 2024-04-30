using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerMoveGroupBuild : MonoBehaviour
{
    public GameObject panel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SetCube")
        {
            GameObject go = other.transform.parent.gameObject;
            go.transform.position = new Vector3(go.transform.position.x, go.transform.position.y, go.transform.position.z + 39.9f);
        }
        else if(other.tag=="Enemy")
        {
            Time.timeScale = 0;
            panel.SetActive(true); 
        }
    }
   public void Restart()
    {
        SceneManager.LoadScene("GameScreen");
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
