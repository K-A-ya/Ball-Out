using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nxt : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame ()
    {
        SceneManager.LoadScene(2);
         Debug.Log("Select 1 out of 3 map theme choices");
//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
