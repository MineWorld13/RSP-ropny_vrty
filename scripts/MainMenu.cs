using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public Texture pozadiMainMenu;
	public GUIStyle buttonback;
	public int menu = 0;
	public string seed;
	public bool pouzitSeed = false;
/*public void nactiScenu( string scena)
	{
		SceneManager.LoadScene (scena);
	}*/
	void OnGUI()
	{
		//Zobrazení našeho background
		GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height),pozadiMainMenu);
		//Tlačítka

		GUI.Box(new Rect(Screen.width * .09f, Screen.height * .29f, Screen.width * .17f, Screen.height * .385f), "");
		switch (menu) {
		case 0:
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .075f),"Hrát hru", buttonback)) {
				print ("Zmáčknul jste tlačítko hrát hru");
				menu = 1;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .39f, Screen.width * .15f, Screen.height * .075f), "Nastavení", buttonback)) {
				print ("Zmáčknul jste tlačítko pro nastavení");
				menu = 2;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .49f, Screen.width * .15f, Screen.height * .075f), "Autoři", buttonback)) {
				print ("Zmáčknul jste tlačítko pro infromaci o autorech");
				menu = 3;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Ukončit hru", buttonback)) {
				Application.Quit();
			}
			break;
		case 1:
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .075f), "Založit novou mapu", buttonback)) {
				print ("Zmáčknul jste tlačítko Založit novou mapu");
				menu = 11;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .39f, Screen.width * .15f, Screen.height * .075f), "Vybrat mapu", buttonback)) {
				print ("Zmáčknul jste tlačítko Vybrat mapu");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .49f, Screen.width * .15f, Screen.height * .075f), "Nahrát", buttonback)) {
				print ("Zmáčknul jste tlačítko Nahrát");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Zpět", buttonback)) {
				menu = 0;
			}
			break;

		case 11:
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .075f), "Vytvořit mapu a hrát", buttonback)) {
				print ("Vytvořit mapu a hrát");
				menu =  1;
			}
			pouzitSeed = GUI.Toggle (new Rect (Screen.width * .1f, Screen.height * .40f, Screen.width * .15f, Screen.height * .075f), pouzitSeed, "Použít seed");
			if (pouzitSeed) {
				GUI.Label (new Rect (Screen.width * .1f, Screen.height * .43f, Screen.width * .15f, Screen.height * .075f), "Zadejte náhodní pismena a čísla");
				seed = GUI.TextField (new Rect (Screen.width * .1f, Screen.height * .49f, Screen.width * .15f, Screen.height * .075f), seed, 100);
			}
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Zpět", buttonback)) {
				menu = 1;
			}
			break;
		case 2:
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .075f), "Grafika", buttonback)) {
				print ("Zmáčknul jste tlačítko nastavení grafiky");
				menu = 21;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .39f, Screen.width * .15f, Screen.height * .075f), "Zvuk", buttonback)) {
				print ("Zmáčknul jste tlačítko pro nastavení zvuku");
				menu = 22;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .49f, Screen.width * .15f, Screen.height * .075f), "Obtížnost hry", buttonback)) {
				print ("Zmáčknul jste tlačítko pro nastavení obtížnosti hry");
				menu = 23;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Zpět", buttonback)) {
				menu = 0;
			}
			break;
		case 21:
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .075f), "Grafika", buttonback)) {
				print ("Zmáčknul jste tlačítko nastavení grafiky");
				menu = 21;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .39f, Screen.width * .15f, Screen.height * .075f), "Zvuk", buttonback)) {
				print ("Zmáčknul jste tlačítko pro nastavení zvuku");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .49f, Screen.width * .15f, Screen.height * .075f), "Obtížnost hry", buttonback)) {
				print ("Zmáčknul jste tlačítko pro nastavení obtížnosti hry");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Zpět", buttonback)) {
				menu = 0;
			}


			GUI.Box(new Rect(Screen.width * .3f, Screen.height * .29f, Screen.width * .4f, Screen.height * .385f), "");
			GUI.Label (new Rect (Screen.width * .31f, Screen.height * .29f, Screen.width * .15f, Screen.height * .075f), "Nastavení grafiky");
			GUI.Label (new Rect (Screen.width * .31f, Screen.height * .32f, Screen.width * .15f, Screen.height * .075f), "Poměr stran");
				

			break;
		case 22:
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .075f), "Grafika", buttonback)) {
				print ("Zmáčknul jste tlačítko nastavení grafiky");
				menu = 21;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .39f, Screen.width * .15f, Screen.height * .075f), "Zvuk", buttonback)) {
				print ("Zmáčknul jste tlačítko pro nastavení zvuku");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .49f, Screen.width * .15f, Screen.height * .075f), "Obtížnost hry", buttonback)) {
				print ("Zmáčknul jste tlačítko pro nastavení obtížnosti hry");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Zpět", buttonback)) {
				menu = 0;
			}


			GUI.Box(new Rect(Screen.width * .3f, Screen.height * .29f, Screen.width * .4f, Screen.height * .385f), "");

			break;
		case 23:
			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .075f), "Grafika", buttonback)) {
				print ("Zmáčknul jste tlačítko nastavení grafiky");
				menu = 21;
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .39f, Screen.width * .15f, Screen.height * .075f), "Zvuk", buttonback)) {
				print ("Zmáčknul jste tlačítko pro nastavení zvuku");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .49f, Screen.width * .15f, Screen.height * .075f), "Obtížnost hry", buttonback)) {
				print ("Zmáčknul jste tlačítko pro nastavení obtížnosti hry");
			}

			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Zpět", buttonback)) {
				menu = 0;
			}


			GUI.Box(new Rect(Screen.width * .3f, Screen.height * .29f, Screen.width * .4f, Screen.height * .385f), "");

			break;
		case 3:
			GUI.Label (new Rect (Screen.width * .1f, Screen.height * .3f, Screen.width * .15f, Screen.height * .26f), "Vedoucí projektu:\n  František Humpa \nSCRUM master:\n  František Humpa \nProgramátor:\n  František Humpa\n  František Kubálek \nGrafik:\n  Petr Kostkuba");


			if (GUI.Button (new Rect (Screen.width * .1f, Screen.height * .59f, Screen.width * .15f, Screen.height * .075f), "Zpět", buttonback)) {
				menu = 0;
			}
			break;
		}
	}
}
