using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public GameObject Socket;
    private GameObject tower;

    public void PlaceTower(string TowerName)
    {
        //switch(gameObject.name)
        //{
        //    case "MagicDebuff":
        //        {
        //            tower = (GameObject)Resources.Load("Towers/" + MagicTowerName);
        //            break;
        //        }
        //    case "DebuffTower":
        //        {
        //            tower = (GameObject)Resources.Load("Towers/" + DebuffTowerName);
        //            break;
        //        }
        //    case "MeleeTower":
        //        {
        //            tower = (GameObject)Resources.Load("Towers/" + MeleeTowerName);
        //            break;
        //        }
        //    case "BallistaTower":
        //        {
        //            tower = (GameObject)Resources.Load("Towers/" + BallistaTowerName);
        //            break;
        //        }
        //}


        tower = (GameObject)Instantiate(Resources.Load("Towers/" + TowerName));

        tower.transform.position = Socket.transform.position;
        tower.transform.rotation = Socket.transform.rotation;
        tower.transform.parent = Socket.transform;
    }
}
