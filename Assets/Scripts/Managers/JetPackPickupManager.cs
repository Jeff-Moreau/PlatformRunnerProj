using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPackPickupManager : MonoBehaviour
{
    [SerializeField] private GameObject jetPack;

    private List<GameObject> jetPacks;
    public List<GameObject> GetJetPacks => jetPacks;

    private int amountOfJetPacks;

    private void Start()
    {
        jetPacks = new List<GameObject>();

        amountOfJetPacks = 2;

        for (int i = 0; i < amountOfJetPacks; i++)
        {
            jetPacks.Add(Instantiate(jetPack, transform));
            jetPacks[i].SetActive(false);
        }
    }

    public GameObject GetJetPack()
    {
        for (int i = 0; i < amountOfJetPacks; i++)
        {
            if (!jetPacks[i].activeInHierarchy)
            {
                return jetPacks[i];
            }
        }

        return null;
    }
}
