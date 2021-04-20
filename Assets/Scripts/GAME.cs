using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GAME : MonoBehaviour
{
    public TMP_Text capto;
    public Canvas cv;

    private void Start()
    {
        cv.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            capto.text = dialogo();
            StartCoroutine(showDialog());
        }
    }

    private string dialogo()
    {
        List<string> textos = new List<string>();
        textos.Add("Hola guapo!");
        textos.Add("Ostras! Creo que me he equivocado de juego...");
        textos.Add("Pulsa cualquier tecla para empezar.");
        textos.Add("En ocasiones, veo pixels...");

        var po = Random.Range(0, 4);
        return textos[po];
    }

    private IEnumerator showDialog()
    {
        cv.enabled = true;
        yield return new WaitForSeconds(1f);
        cv.enabled = false;
    }
}
