using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Button button2;
    // Start is called before the first frame update
    void Start()
    {
        button2.onClick.AddListener(taskonclick);
    }

    void taskonclick()
    {
        Application.LoadLevel("Menu");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
