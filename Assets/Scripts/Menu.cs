using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Button button1;
    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(taskonclick);
    }

    void taskonclick()
    {
        Application.LoadLevel("Game");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
