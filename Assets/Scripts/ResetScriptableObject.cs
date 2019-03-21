using UnityEngine;

public class ResetScriptableObject : MonoBehaviour
{
    public DataContainer dataContainer;

	void Start ()
    {
        dataContainer.score = 0;
	}
}
