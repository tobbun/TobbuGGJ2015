using UnityEngine;
using System.Collections;

public class RandomNPCGen : MonoBehaviour {

	static int STR;
	static int DEX;
	static int CON;
	static int INT;
	static int WIS;
	static int CHA;




	public static void output(){
		
		stats();
	}
	public static int sumThreeDice(){
		int die1, die2, die3;
		int sum;
		die1 = (Random.Range (1, 7));
		die2 = (Random.Range (1, 7));
		die3 = (Random.Range (1, 7));
		
		sum = die1 + die2 + die3;
		
		return sum;
	}
	public static void stats(){
		for (int i = 0; i < 6; i++){
			setAttribute(i, sumThreeDice());
		}
		
	}
	public static void setAttribute(int stat, int value){
		if (stat == 0){
			STR = value;
			System.Console.Write("STR: "+ STR);
		} else if (stat == 1){ 
			DEX = value;
			System.Console.Write("DEX: "+ DEX);
		} else if (stat == 2){
			CON = value;
			System.Console.Write("CON: "+ CON);
		} else if (stat == 3){
			INT = value;
			System.Console.Write("INT: "+ INT);
		} else if (stat == 4){
			WIS = value;
			System.Console.Write("WIS: "+ WIS);
		} else if (stat == 5){
			CHA = value;
			System.Console.Write("CHA: "+ CHA);
		}
	}


}
