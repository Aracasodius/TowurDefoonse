using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public GameObject Socket;
    private GameObject tower;

    [SerializeField] string MagicTowerName;
    [SerializeField] string BallistaTowerName;
    [SerializeField] string MeleeTowerName;
    [SerializeField] string DebuffTowerName;

    public void PlaceTower()
    {
        switch(gameObject.name)
        {
            case "MagicDebuff":
                {
                    tower = (GameObject)Resources.Load(MagicTowerName);
                    break;
                }
            case "DebuffTower":
                {
                    tower = (GameObject)Resources.Load(DebuffTowerName);
                    break;
                }
            case "MeleeTower":
                {
                    tower = (GameObject)Resources.Load(MeleeTowerName);
                    break;
                }
            case "BallistaTower":
                {
                    tower = (GameObject)Resources.Load(BallistaTowerName);
                    break;
                }
        }
        Instantiate(tower);

        tower.transform.position = Socket.transform.position;
        tower.transform.rotation = Socket.transform.rotation;
        tower.transform.parent = Socket.transform;
    }
}
