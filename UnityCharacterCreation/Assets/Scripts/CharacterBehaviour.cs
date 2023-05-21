using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterBehaviour : MonoBehaviour
{
    public GameObject[] characterPrefab;
    public GameObject maleOld;
    public GameObject maleYoung;
    public GameObject female;
    public GameObject zombi;
    public TMPro.TextMeshProUGUI nameLabel;
    public TMPro.TextMeshProUGUI ageLabel;

    private int index = 0;

    private string characterTag = "Character";
    private string infoTag = "Info";
    private int age = 0;
    private string characterName = "";

    void Start() {
       GameObject newObject = Instantiate(characterPrefab[index], transform.position, transform.rotation);
       ChangeObject(newObject);
    }

    public void ChangeToNext() {
        if (index < characterPrefab.Length - 1) {
            index++;
        } else {
            index = 0;
        }

        GameObject newObject = Instantiate(characterPrefab[index], transform.position, transform.rotation);
        ChangeObject(newObject);
    }

    public void SetAge(string age) {
        this.age = int.Parse(age);
        this.ageLabel.text = "Age: " + age;
    }

    public void SetGender(string gender) {
        GameObject selectedObject;
        if (gender == "Male") selectedObject = age > 18 ? maleOld : maleYoung;
        else if (gender == "Female") selectedObject = female;
        else selectedObject = zombi;

        GameObject newObject = Instantiate(selectedObject, transform.position, transform.rotation);
        ChangeObject(newObject);
    }

    public void SetName(string name) {
        this.characterName = name;
        this.nameLabel.text = "Name: " + name;
    }

    private void ChangeObject(GameObject newObject) {
        GameObject child = GameObject.FindGameObjectWithTag(characterTag);
        if (child != null) {
            Destroy(child);
        }

        newObject.transform.SetParent(transform);
    }
}
