using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Map_Selection : MonoBehaviour
{
    // Start is called before the first frame update
    public void Map_1 ()
    {
        SceneManager.LoadScene(3);
         Debug.Log("Forest Map Selected");

    }

   public void Map_2 ()
    {
        SceneManager.LoadScene(4);
         Debug.Log("Space Map Selected");

    }

    public void Map_3 ()
    {
        SceneManager.LoadScene(5);
        Debug.Log("Town Map Selected");

    }
}
