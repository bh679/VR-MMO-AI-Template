using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BrennanHatton.Discord;
using UnityLibrary;

namespace BrennanHatton.Logging
{
	public class GPT3ToDiscord : MonoBehaviour
	{
		public ClassDiscordConnection discord;
		public GPT3 GPTAPI;
		
		int interactionLength;
		int promptLength;
		
		void Start()
		{
			GPTAPI.onExecute.AddListener(SendPrompt);
			GPTAPI.onResults.AddListener(SendResult);
		}
	    
		void SendPrompt(InteractionData interaction)
		{
			discord.SendMessage("```Prompt: "+interaction.requestData.prompt+"```", true);
		}
		
		void SendResult(InteractionData interaction)
		{
			discord.SendMessage("Result: "+interaction.generatedText+"", true);
		}
	}
}
