using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeesMain : MonoBehaviour
{
    //variables to hold each bee class prefab
    public Bee queenBeePrefab;
    public Bee workerBeePrefab;
    public Bee droneBeePrefab;

    //variable array to hold text boxes for each bee
    public Text[] beeText = new Text[30];

    //variable list to hold the bee objects
    public List<Bee> bees = new List<Bee>();

    // Start is called before the first frame update
    void Start()
    {
        //loop 10 times to instantiate 10 of each type of bee and add to the list
        for (int i = 0; i < 10; i++)
        {
            bees.Add(Instantiate(queenBeePrefab));
            bees.Add(Instantiate(workerBeePrefab));
            bees.Add(Instantiate(droneBeePrefab));
        }

        //update the text on-screen
        UpdateBeeText();
    }

    //called every frame
    private void Update()
    {
        //updates the text on-screen in real-time
        UpdateBeeText();
    }

    //method loops through all text boxes and updates health and alive status
    private void UpdateBeeText()
    {
        for (int i = 0; i < beeText.Length; i++)
        {
            string alive = "";

            if (bees[i].dead)
            {
                alive = "Dead";
            }
            else
            {
                alive = "Alive";
            }

            beeText[i].text = "Health = " + bees[i].Health + " " + alive;
        }
    }

    //method damages all bees by a random percentage of their current health
    private void DamageAllBees()
    {
        for (int i = 0; i < bees.Count; i++)
        {
            int damage = Random.Range(0,81);
            bees[i].Damage(damage);
        }
    }

    //method detects button click and calles DamageAllBees method
    public void ButtonClicked()
    {
        DamageAllBees();
    }
}
