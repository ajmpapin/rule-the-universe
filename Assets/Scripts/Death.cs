using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    public GameObject deathMenu;

    void OnDestroy() {
        deathMenu.SetActive(true);
    }
}
