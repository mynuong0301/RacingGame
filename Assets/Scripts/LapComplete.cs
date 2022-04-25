using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{

	public GameObject FinishTrig;
	public GameObject PointTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject CompleteText;

	public GameObject LapCounter;
	public int LapsDone;

	//public float RawTime;

	public GameObject RaceFinish;
	public int LapsRequirement = 1;

    private void Start()
    {
		LapsDone = 0;
		PlayerPrefs.SetInt("MinSave", 2);
		PlayerPrefs.SetInt("SecSave", 23);
		PlayerPrefs.SetFloat("MilliSave", 5);
	}

    void Update()
    {
        if (LapsDone == LapsRequirement)
        {
			RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter()
	{
		if (LapsDone < LapsRequirement)
			LapsDone += 1;
		//RawTime = PlayerPrefs.GetFloat("RawTime");

		int MinCount = PlayerPrefs.GetInt("MinSave");
		int SecCount = PlayerPrefs.GetInt("SecSave");
		float MilliCount = PlayerPrefs.GetFloat("MilliSave");

		bool isBest = true;

		if (LapTimeManager.MinuteCount > MinCount)
		{
			isBest = false;
		}
		else
			if (LapTimeManager.MinuteCount == MinCount)
			if (LapTimeManager.SecondCount > SecCount)
				isBest = false;
			else
				if (LapTimeManager.SecondCount == SecCount)
				if (LapTimeManager.MilliCount > MilliCount)
					isBest = false;

		if (isBest && SelectionButtonOptions.RaceMode == 2)
        {
			if (LapTimeManager.SecondCount <= 9)
			{
				SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
			}
			else
			{
				SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
			}

			if (LapTimeManager.MinuteCount <= 9)
			{
				MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
			}
			else
			{
				MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
			}

			MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount;

			//Save best time
			PlayerPrefs.SetInt("MinSave", LapTimeManager.MinuteCount);
			PlayerPrefs.SetInt("SecSave", LapTimeManager.SecondCount);
			PlayerPrefs.SetFloat("MilliSave", LapTimeManager.MilliCount);
		}
		//PlayerPrefs.SetFloat("RawTime", LapTimeManager.RawTime);

		CompleteText.SetActive(true);

		LapTimeManager.MinuteCount = 0;
		LapTimeManager.SecondCount = 0;
		LapTimeManager.MilliCount = 0;
		//LapTimeManager.RawTime = 0;

		LapCounter.GetComponent<Text>().text = "" + LapsDone;
		PointTrig.SetActive(true);
		FinishTrig.SetActive(true);

	}

}