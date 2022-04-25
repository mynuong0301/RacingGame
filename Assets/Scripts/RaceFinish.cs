using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class RaceFinish : MonoBehaviour
{
	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewModes;
	public GameObject LevelMusic;
	public GameObject CompleteTrig;
	public AudioSource FinishMusic;
	public GameObject LapManager;
	public GameObject FinishPanel;
	public GameObject posDisplayInGame;
	public GameObject posDisplay;
	public GameObject rewardDisplay;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			LapManager.GetComponent<LapTimeManager>().enabled = false;
			this.GetComponent<BoxCollider>().enabled = false;
			MyCar.SetActive(false);
			CompleteTrig.SetActive(false);
			CarController.m_Topspeed = 0.0f;
			//MyCar.GetComponent<CarController>().MaxSpeed = 0.0f;
			MyCar.GetComponent<CarController>().enabled = false;
			MyCar.GetComponent<CarUserControl>().enabled = false;
			MyCar.SetActive(true);
			FinishCam.SetActive(true);
			LevelMusic.SetActive(false);
			ViewModes.SetActive(false);
			FinishMusic.Play();
			FinishPanel.SetActive(true);
			posDisplayInGame.SetActive(false);

			posDisplay.GetComponent<Text>().text = posDisplayInGame.GetComponent<Text>().text;
			if (posDisplay.GetComponent<Text>().text == "1st Place!")
			{
				GlobalCash.ChangeCash(100);
				rewardDisplay.GetComponent<Text>().text = "$100";
			}
			else
			{
				GlobalCash.ChangeCash(50);
				rewardDisplay.GetComponent<Text>().text = "$50";
			}
			Debug.Log(GlobalCash.totalCash);
		}
	}

	
	public void Exit() //Back to main menu
    {
		SceneManager.LoadScene(0);
    }
}
