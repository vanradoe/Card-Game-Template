using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

//public TextMeshProUGUI turnText;

public class Table : MonoBehaviour
{
    GameManager gm;
    public bool card_played;

    void Start()
    {
        gm = FindAnyObjectByType<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        print(collision.gameObject.GetComponent<Card>().data.card_name + " card detected"); 
        //when card is detected, played = true, can no longer drag cards until ai hand plays
        if (collision.gameObject.CompareTag("Card"))
        {
            collision.gameObject.GetComponent<DraggableUI>().can_be_dragged = false;
            gm.Player_Turn(collision.gameObject.GetComponent<Card>());
            //turnText.text = "turn: " + 
        }
    }

}