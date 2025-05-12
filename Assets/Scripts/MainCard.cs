using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCard : MonoBehaviour
{
    [SerializeField] private SceneController controller;
    public GameObject Card_Back;
    public GameObject MarkerV;
    public GameObject Marker1;
    public GameObject Marker2;
    public GameObject Marker3;

    public int cardValue;
    public CardBack cb;
    Animator animator;
    int relevantFlips = 0;
    


    public void Start()
    {
        animator = cb.GetComponent<Animator>();
        this.MarkerV.SetActive(false);
        this.Marker1.SetActive(false);
        this.Marker2.SetActive(false);
        this.Marker3.SetActive(false);
    }

    public void Update()
    {
        if (animator.GetBool("GameOver")) 
        {
            controller.loseText.SetActive(false);
            controller.winText.SetActive(false);
            controller.EndGame();
            animator.SetBool("GameOver", false);
        }
    }

    public void OnMouseDown()
    {
        if (Card_Back.activeSelf && controller.activeGame) 
        {
            Card_Back.SetActive(false);
            if (this.cardValue == 1)
            {
                relevantFlips += 1;
                if (controller.Score == 0)
                {
                    controller.Score += 1;
                    controller.scoreLabel.text = "Coins Collected:\n " + controller.Score;
                }
            }
            else if (this.cardValue == 2 || this.cardValue == 3)
            {
                relevantFlips += 1;
                if (controller.Score == 0)
                {
                    controller.Score += this.cardValue;
                    controller.scoreLabel.text = "Coins Collected:\n " + controller.Score;
                }
                else
                {
                    controller.Score *= this.cardValue;
                    controller.scoreLabel.text = "Coins Collected:\n " + controller.Score;
                }
            }
            else
            {
                Debug.Log("YOU LOSE!");
                if (relevantFlips < controller.GameLevel) 
                {
                    controller.GameLevel = relevantFlips;
                    controller.LevelText.text = "Lv. " + controller.GameLevel;
                    if (controller.GameLevel <= 0) 
                    {
                        controller.GameLevel = 1;
                        controller.LevelText.text = "Lv. " + controller.GameLevel;
                    }
                }
                controller.loseText.SetActive(true);
                Card_Back.SetActive(true);
                cb.Flip();
                
            }
            
            //Debug.Log(this.cardValue);
            if (controller.Score == controller.total) 
            {
                Debug.Log("You Win!");
                if (controller.GameLevel != 8) 
                {
                    controller.GameLevel += 1;
                    controller.LevelText.text = "Lv. " + controller.GameLevel;
                }
                controller.winText.SetActive(true);
                //controller.EndGame();
                cb.Flip();
                controller.activeGame = false;
            }
        }
    }

     public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1))
        {
            //Debug.Log("Value is " + this.cardValue);

            //this.MarkerV.SetActive(!this.MarkerV.activeSelf);
            switch (controller.MarkerValue) 
            {
                case 0:
                    this.MarkerV.SetActive(!this.MarkerV.activeSelf);
                    break;
                case 1:
                    this.Marker1.SetActive(!this.Marker1.activeSelf);
                    break;
                case 2:
                    this.Marker2.SetActive(!this.Marker2.activeSelf);
                    break;
                case 3:
                    this.Marker3.SetActive(!this.Marker3.activeSelf);
                    break;
            }
            
        }
    }


    private int _id;
    public int id 
    {
        get { return _id; }
    }

    public void ChangeSprite(int id,Sprite image) 
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image; //gets sprite renderer and changes its sprite
    }
    
    public void UnReveal() 
    {
        Card_Back.SetActive(true);
    }

}
