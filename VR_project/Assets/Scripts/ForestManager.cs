﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class ForestManager : MonoBehaviour {

    public GameObject con_left;
    public GameObject con_right;
    public GameObject b_left;
    public GameObject b_right;

    //public GameObject[] Scene;
    //public GameObject[] Moves;
    //public GameObject wolfStory;
    //public GameObject redStory;

    public int num=0;

    // Use this for initialization
    void Start () {
        //if (GameManager.Instance.Character == GameManager.PlayableCharacter.Red)
        //{
        //    redStory.SetActive(true);
        //    wolfStory.SetActive(false);
        //}

        //if (GameManager.Instance.Character == GameManager.PlayableCharacter.Wolf)
        //{
        //    wolfStory.SetActive(true);
        //    redStory.SetActive(false);
        //}
        Debug.Log(GameManager.Instance.getwhichHandGrap());
        if(GameManager.Instance.getwhichHandGrap() == 1)
        {
            b_left.SetActive(true);
            con_left.GetComponent<Grab_Object>().isGetBasket = true;
            con_left.GetComponent<LaserPointer>().enabled = false;
        }

        if (GameManager.Instance.getwhichHandGrap() == 2)
        {
            b_right.SetActive(true);
            con_right.GetComponent<Grab_Object>().isGetBasket = true;
            con_right.GetComponent<LaserPointer>().enabled = false;
        }

    }
	
	// Update is called once per frame
	void Update () {
        //switch(GameManager.Instance.Character)
        //{
        //    case GameManager.PlayableCharacter.Red: Red(); break;
        //    case GameManager.PlayableCharacter.Wolf: Wolf(); break;
        //}
    }

    //void Red()
    //{
    //    if (num == 0 && Moves[0].GetComponent<PlayableDirector>().state != PlayState.Playing)
    //    {
    //        Scene[0].SetActive(true);
    //        if (Scene[0].GetComponent<PlayableDirector>().state != PlayState.Playing)
    //        {
    //            num = 1;
    //        }
    //    }
    //    else if (num == 1)
    //    {
    //        Scene[2].SetActive(true);
    //        if (Scene[2].GetComponent<PlayableDirector>().state != PlayState.Playing)
    //        {
    //            num = 2;
    //        }
    //    }
    //    else if (num == 2)
    //    {
    //        Moves[1].SetActive(true);
    //        if (Moves[1].GetComponent<PlayableDirector>().state != PlayState.Playing)
    //        {
    //            num = 3;
    //        }
    //    }
    //    else if (num == 3)
    //    {
    //        Scene[4].SetActive(true);
    //        if (Scene[4].GetComponent<PlayableDirector>().state != PlayState.Playing)
    //        {
    //            num = 0;
    //            SceneManager.LoadScene("GrandmaHouse");
    //        }
    //    }
    //}

    //void Wolf()
    //{
    //    if (num == 0 && Scene[5].GetComponent<PlayableDirector>().state != PlayState.Playing)
    //    {
    //        Scene[6].SetActive(true);
    //        if (Scene[6].GetComponent<PlayableDirector>().state != PlayState.Playing)
    //        {
    //            num = 1;
    //        }
    //    }
    //    if(num==1)
    //    {
    //        Scene[7].SetActive(true);
    //        if (Scene[7].GetComponent<PlayableDirector>().state != PlayState.Playing)
    //        {
    //            num = 2;
    //        }
    //    }
    //    if(num==2)
    //    {
    //        Scene[8].SetActive(true);
    //        if (Scene[8].GetComponent<PlayableDirector>().state != PlayState.Playing)
    //        {
    //            num = 0;
    //            SceneManager.LoadScene("GrandmaHouse");
    //        }
    //    }
    //}
}
