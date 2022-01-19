using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject RadarPlane;

    // mission report panel

    public GameObject _Enemy1;
    public GameObject _Enemy2;
    public GameObject _Enemy3;
    public GameObject _Enemy4;
    public GameObject _Enemy5;
    public GameObject _Enemy6;


    public GameObject _MissionReportPanel;
    public GameObject MissionStartPanel;
    float height = Mathf.Infinity;
    RaycastHit hit;

    public int phases;


    //mission application
    private string _tag = "Enemy";



    float _distance;
    private void Start()
    {
        AplicationPhase();
        MissionStartPanel.SetActive(true);

    }
    private void Update()
    {
        if (Physics.Raycast(RadarPlane.transform.position, Vector3.down, out hit))
        {
            height = Vector3.Distance(hit.point, RadarPlane.transform.position);
            //Debug.Log(height);
        }
        if (height < 20) // Plane will destorey
        {
            MissionDone();
            //Instantiate(RadarPlane, new Vector3(500, 250, 1300), Quaternion.identity);
        }

        // Finish the mission by arriving last route point /// 
        // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!//
    }



    public void MissionStart()
    {


        _Enemy1.SetActive(true);
        _Enemy2.SetActive(true);
        _Enemy3.SetActive(true);
        _Enemy4.SetActive(true);
        _Enemy5.SetActive(true);
        _Enemy6.SetActive(true);

        MissionStartPanel.SetActive(false);
        RadarPlane.gameObject.SetActive(true);
        RadarPlane.transform.position = new Vector3(350, 250, 1365);
    }

    public void MissionDone()
    {
        RadarPlane.gameObject.SetActive(false);
        _MissionReportPanel.SetActive(true);
        MissionStartPanel.SetActive(false);

        _Enemy1.SetActive(false);
        _Enemy2.SetActive(false);
        _Enemy3.SetActive(false);
        _Enemy4.SetActive(false);
        _Enemy5.SetActive(false);
        _Enemy6.SetActive(false);

        /*GameObject[] EnemyObjectsList = GameObject.FindGameObjectsWithTag(_tag);
        foreach (GameObject tagged in EnemyObjectsList)
        {
            if (objectN != 3)
            {
                objectN = objectN + 1;
                tagged.SetActive(false);
            }
            else if (objectN == 3)
            {
                break;
            }

        }*/


    }

    public void AplicationPhase()
    {
        /*GameObject[] EnemyObjectsList = GameObject.FindGameObjectsWithTag(_tag);
        foreach (GameObject tagged in EnemyObjectsList)
        {


                //MeshRenderer PLS = tagged.GetComponent<MeshRenderer>();
                //PLS.enabled = false;
                if (objectN != 3)
                {
                    objectN = objectN + 1;
                    //tagged.SetActive(false);
                }
                else if (objectN == 3)
                {
                    break;
                ;
            }


            /*MeshRenderer PLS = tagged.GetComponent<MeshRenderer>();
            PLS.enabled = false;
        }*/
        _Enemy1.SetActive(false);
        _Enemy2.SetActive(false);
        _Enemy3.SetActive(false);
        _Enemy4.SetActive(false);
        _Enemy5.SetActive(false);
        _Enemy6.SetActive(false);
        MissionStartPanel.SetActive(true);
        RadarPlane.gameObject.SetActive(true);
        RadarPlane.transform.position = new Vector3(350, 250, 1365);
        Debug.Log("AplicationPhase");
        _MissionReportPanel.SetActive(false);

    }
}

