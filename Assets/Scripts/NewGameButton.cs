using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameButton : MonoBehaviour
{
    [SerializeField] private SceneController controller;

    private void OnMouseDown()
    {

        controller.EndGame();
    }
}
