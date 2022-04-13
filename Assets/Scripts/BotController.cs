using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
	public GameObject TheMarker;
    public GameObject[] Marks;
	public int MarkTracker;

    // Update is called once per frame
    void Update()
    {
        if (MarkTracker >= 0 && MarkTracker < Marks.Length)
        {
			TheMarker.transform.position = Marks[MarkTracker].transform.position;

        }
    }

	IEnumerator OnTriggerEnter(Collider collision)
	{
		if (collision.gameObject.tag == "Car_Bot")
		{
			this.GetComponent<BoxCollider>().enabled = false;
			MarkTracker += 1;
			if (MarkTracker == Marks.Length)
			{
				MarkTracker = 0;
			}
			yield return new WaitForSeconds(1);
			this.GetComponent<BoxCollider>().enabled = true;
		}
	}
}
