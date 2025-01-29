using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using System.Collections.Generic;


public class NPC : MonoBehaviour
{
    public string npcName;
    public string menuLine;
    private string[] npcDialogue;
    public string playerDialogue;

    public GameObject [] options;
    public int choiceIndex;
    public string[] responses;

    public GameObject dialoguePanel, optionPanel, button1, button2, button3;

    public Button optionButton1;
    public Button optionButton2;
    public Button optionButton3;
    public TextMeshProUGUI optionText1;
    public TextMeshProUGUI optionText2;
    public TextMeshProUGUI optionText3;


    private bool isDialogueActive;

    public TextMeshProUGUI menuText;
    public TextMeshProUGUI npcname;
    public TextMeshProUGUI npcdialogue;
    


    void Start()
    {
        dialoguePanel.SetActive(false);
    }

    

    void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            npcname.text = npcName;
            menuText.text = menuLine;


            npcdialogue.text = npcDialogue[0];

            isDialogueActive = true;
            dialoguePanel.SetActive(true);
            optionPanel.SetActive(true);

            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);



        }
       
    }



    void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            npcname.text = "";
            menuText.text = "";
            isDialogueActive = false;
            npcdialogue.text = "";
            dialoguePanel.SetActive(false);
            optionPanel.SetActive(false);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
        }
    }


    void Update()
    {
        if (isDialogueActive)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (npcDialogue.Length > 1)
                {
                    npcdialogue.text = npcDialogue[1];
                }
                else if (npcDialogue.Length > 2)
                {
                    npcdialogue.text = npcDialogue[2];
                }
                else if (npcDialogue.Length > 3)
                {
                    npcdialogue.text = npcDialogue[3];
                }

            }
        }
    }

    
}
