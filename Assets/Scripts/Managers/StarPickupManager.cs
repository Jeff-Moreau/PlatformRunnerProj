using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarPickupManager : MonoBehaviour
{
    [SerializeField] private GameObject star;

    private List<GameObject> stars;
    public List<GameObject> GetStars => stars;

    private int amountOfStars;

    private void Start()
    {
        stars = new List<GameObject>();

        amountOfStars = 15;

        for (int i = 0; i < amountOfStars; i++)
        {
            stars.Add(Instantiate(star, transform));
            stars[i].SetActive(false);
        }
    }

    public GameObject GetStar()
    {
        for (int i = 0; i < amountOfStars; i++)
        {
            if (!stars[i].activeInHierarchy)
            {
                return stars[i];
            }
        }

        return null;
    }
}
