using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*This script stores every dialogue conversation in a public Dictionary.*/

public class Dialogue : MonoBehaviour
{

    public Dictionary<string, string[]> dialogue = new Dictionary<string, string[]>();

    void Start()
    {
        //Door
        dialogue.Add("LockedDoorA", new string[] {
            "A large door...",
            "Looks like it has a key hole!"
        });


        dialogue.Add("LockedDoorB", new string[] {
            "Key used!"
        });

        //NPC
        dialogue.Add("CharacterA", new string[] {
            "Hi there!",
            "I'm an NPC! This conversation is called 'npcA'...",
            "If you go and find me 80 coins, my dialogue will move on to 'npcB'!",
            "Feel free to edit my dialogue in the 'Dialogue.cs' file!",
            "To keep it simple, you can also ask me one, and only one, question...",
            "...Like you just did! And I'll just move on to the next sentence.",
            "I'll answer that question, but it won't change much about the game!",
            "You can always tweak the 'DialogueBox.cs' script to add more functionality!"
        });

        dialogue.Add("CharacterAChoice1", new string[] {
            "",
            "",
            "Let me go find some coins!",
        });

        dialogue.Add("CharacterAChoice2", new string[] {
            "",
            "",
            "What else can you do?"
        });

        dialogue.Add("CharacterB", new string[] {
            "Hey! You found 80 coins! That means 'npcB' is now being used inside 'Dialogue.cs'!",
            "After my dialogue completes, I'll take 80 coins, or however many you specify in the inspector...",
            "And I'll also give you a new ability!",
            "In this case, how about a generic DOWNWARD SMASH? Simply attack while pressing down in mid-air!"
        });

        dialogue.Add("NightclubDoorA", new string[]
        {
            "Shit!",
            "I don't have my ID card...",
            "Seems Like I can't enter the Studio Yet..."
        });

        dialogue.Add("oldtv", new string[] { 
            "Anchor Male: ...And Now On Nightly News",
            "One More City Falls Under the Control of the Dark Youtubers",
            "Anchor Female: These Are Very Dark Times I tell You Winston...",
            "Dear Survivors, Please Don't Fall under their Mind Control...",
            "*T.V Static*",
            "...",
            "The Transmission Ended"
        });

        dialogue.Add("ClosedShopA", new string[]
        {
            "The Doors are closed",
            "Seems like the shopkeeper is not here...",
            "I'll check it later"
        });

        dialogue.Add("DoorDarkA", new string[]
        {
            "The Door Is Locked?...",
            "...No, it requires a payment...",
            "I should quickly collect the 15 coins it requires..."
        }) ;

        dialogue.Add("DoorDarkB", new string[]
        {
            "Note From Maker:",
            "Hello, Thanks For playing This Demo, ",
            "The Full version will be out after some tweaks"
        });
    }


}
