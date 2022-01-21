using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using Models;
using Proyecto26;
using UnityEngine.Networking;

public class TurnOn : MonoBehaviour
{
  
	private RequestHelper currentRequest;

    private void LogMessage(string title, string message) {
#if UNITY_EDITOR
		Debug.Log(message);
#else
		Debug.Log(message);
#endif
	}

    public void TurnLightOn() {
           /// post code here


		currentRequest = new RequestHelper {
			Uri =  "http://10.0.0.188:8888/relays/3",
			
			Body = new Post {
				state = true,
				
			},
			EnableDebug = true
		};
		RestClient.Post<Post>(currentRequest)
		.Then(res => {

			// And later we can clear the default query string params for all requests
			RestClient.ClearDefaultParams();

			this.LogMessage("Success", JsonUtility.ToJson(res, true));
		})
		.Catch(err => this.LogMessage("Error", err.Message));



        
    }


}
