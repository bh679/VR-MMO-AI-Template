using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace BrennanHatton.Logging
{
	public class LogToText : MonoBehaviour
	{
		public TMP_Text text;
		
	    // Start is called before the first frame update
	    void Start()
	    {
	        
	    }
		int length = 0;
	    // Update is called once per frame
	    void Update()
		{
			if(length != ActionLogger.Instance.actions.Count)
			{
				text.text = ActionLogger.Instance.output;
				length = ActionLogger.Instance.actions.Count;
			}
	    }
	}
}