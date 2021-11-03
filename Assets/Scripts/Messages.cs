using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Messages : MonoBehaviour
{

    public static Dictionary<string, string> HOSTEL_WELCOME_MESSAGE = new Dictionary<string, string>(){ 
		{"RU", "Russian wellcome message here: Sim-Salabim!"},
		{"EN", "English message Here: Bla-Bla-Bla..."},
		{"AM", "Armenian saabsheni Stex: hinch ka chka?"}
	};



	//public static Dictionary<string, string> example = new Dictionary<string, string>(){
	//	{"UK", "London, Manchester, Birmingham"},
	//	{"USA", "Chicago, New York, Washington"},
	//	{"India", "Mumbai, New Delhi, Pune"}
	//};


}
