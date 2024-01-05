using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject StartBtn;

    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(true); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        
        Menu.SetActive(false);
        Debug.Log(Menu);
    }
}
