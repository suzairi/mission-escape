using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour 
{
    public DataContainer dataContainer;
    public Text textScore;
	
	void Update () 
	{
	    textScore.text = dataContainer.score.ToString();	
	}
}
