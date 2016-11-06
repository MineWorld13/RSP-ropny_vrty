using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public Texture pozadiMainMenu;
	public bool uvod = false;
	public bool hrathru = true;
	public bool nastaveni = true;
	public bool konec = true;
	void OnGUI()
	{
		//Zobrazení našeho background
		GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height),pozadiMainMenu);
		//Tlačítka
		if (!uvod) {
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .075f), "Hrát hru")) {
				print ("Zmáčknul jste tlačítko hrát hru");
				hrathru = false;
				uvod = true;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .39f, Screen.width * .15f, Screen.height * .075f), "Nastavení")) {
				print ("Zmáčknul jste tlačítko pro nastavení");
				nastaveni = false;
				uvod = true;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .49f, Screen.width * .15f, Screen.height * .075f), "Autoři")) {
				print ("Zmáčknul jste tlačítko pro infromaci o autorech");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Ukončit hru")) {
				Application.Quit();
			}
		}

		if (!hrathru) {
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .075f), "Založit novou mapu")) {
				print ("Zmáčknul jste tlačítko hrát hru");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .39f, Screen.width * .15f, Screen.height * .075f), "Vybrat mapu")) {
				print ("Zmáčknul jste tlačítko pro nastavení");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .49f, Screen.width * .15f, Screen.height * .075f), "Nahrát")) {
				print ("Zmáčknul jste tlačítko pro infromaci o autorech");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Zpět")) {
				hrathru = true;
				uvod = false;
			}
		
		}
		if (!nastaveni) {
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .075f), "Grafika")) {
				print ("Zmáčknul jste tlačítko hrát hru");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .39f, Screen.width * .15f, Screen.height * .075f), "Zvuk")) {
				print ("Zmáčknul jste tlačítko pro nastavení");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .49f, Screen.width * .15f, Screen.height * .075f), "Obtížnost hry")) {
				print ("Zmáčknul jste tlačítko pro infromaci o autorech");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Zpět")) {
				nastaveni = true;
				uvod = false;
			}
		}
	}
}
