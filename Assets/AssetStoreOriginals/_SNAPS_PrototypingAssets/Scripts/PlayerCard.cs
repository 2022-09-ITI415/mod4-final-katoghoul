using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCard:MonoBehaviour {

private int count;
public Text countText;
public Text winText;

    // Start is called before the first frame update
void Start()
    {
        count=0;
		SetCountText();
		winText.text = "";
    }

    // Update is called once per frame
void FixedUpdate()
    {}
   
void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag("Prefab"))
		{
			other.gameObject.SetActive(false);

			count = count + 1;

			SetCountText ();
		}
	}
void SetCountText(){
		countText.text = "Count: " + count.ToString();

		if (count >= 6) 
		{
                 winText.text= "Mission Complete!";

	}}}
            
        

