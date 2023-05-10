using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    public GameObject[] characterPrefab;
    public int index = 0;

    private string characterTag = "Character";

    void Start() {
        ChangeObject();
    }

    public void ChangeToNext() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            if (index < characterPrefab.Length - 1) {
                index++;
            } else {
                index = 0;
            }

            ChangeObject();
        }
    }

    private void ChangeObject() {
        GameObject newObject = Instantiate(characterPrefab[index], transform.position, transform.rotation);
        GameObject child = GameObject.FindGameObjectWithTag(characterTag);
        if (child != null) {
            Destroy(child);
        }

        newObject.transform.SetParent(transform);
    }
}
