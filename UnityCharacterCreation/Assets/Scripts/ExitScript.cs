using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public void OnQuiteButtonPressed() {
        Application.Unload();
    }
}
