using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuEvent : MonoBehaviour
{
    public void Start()
    {
    }
    // Start is called before the first frame update
    public void LoadLeVel(int index){

        SceneManager.LoadScene(index);
    }
}
