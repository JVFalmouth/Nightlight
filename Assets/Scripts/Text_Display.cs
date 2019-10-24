using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Display : MonoBehaviour
{
    public Text dialogue;
    private GameObject Window;
    public bool intro_playing;
    private string[] intro_dialogue = { "...", "Where...", "Where am I?" };
    private int currentline = 0;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        intro_playing = true;
        Player = GameObject.FindWithTag("Player");
        Window = GameObject.FindWithTag("dialogueWindow");
    }

    // Update is called once per frames
    void Update()
    {
        if (intro_playing)
        {
            dialogue.text = intro_dialogue[currentline];
            if (Input.GetMouseButtonDown(0))
            {
                currentline += 1;
                if (currentline == 3)
                {
                    intro_playing = false;
                    Window.SetActive(false);
                }

            }
        }
        else
        {
            if (Player.GetComponent<fear_script>().isTouchingLight == true)
            {
                Window.SetActive(true);
                dialogue.text = "Whew, that was tough";
                StartCoroutine(speak_time());
            }
            else
            {
                Window.SetActive(false);
            }
        }
    }
    IEnumerator speak_time()
    {
        yield return new WaitForSeconds(1);
        Window.SetActive(false);
    }
}
