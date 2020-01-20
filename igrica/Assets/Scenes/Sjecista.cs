using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sjecista : MonoBehaviour {
	
	public GameObject plane1;
	public GameObject plane2;
	public GameObject plane3;
	public GameObject plane4;
	public GameObject plane5;
	public GameObject plane6;
	public GameObject plane7;
	public GameObject plane8;
	
	float x1,x2,y1,y2,x3,x4,y3,y4,x5,x6,y5,y6,x7,x8,y7,y8;
	float k1,k2;
	int broj1,broj2,broj3,broj4;
	
	// Use this for initialization
	void Start () {
		float Num1 = Random.Range(1.0f, 5.0f);
		broj1 = (int) Num1;
		
		float Num2 = Random.Range(1.0f, 5.0f);
		broj2 = (int) Num2;
		
		float Num3 = Random.Range(1.0f, 5.0f);
		broj3 = (int) Num3;
		
		float Num4 = Random.Range(1.0f, 5.0f);
		broj4 = (int) Num4;
		
		
		// I. KVADRANT
		if (broj1 == 1){
			// sjeciste1.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
			do{
				x1 = Random.Range(5.0f, 20.0f);
				y1 = Random.Range(5.0f, 9.0f);
				x2 = Random.Range(5.0f, 20.0f);
				y2 = Random.Range(5.0f, 9.0f);
				
				k1 = (y1-0)/(x1-0);
				k2 = (y2-0)/(x2-0);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		else if (broj1 == 2){
			// sjeciste1.transform.position = new Vector3(20.0f, 0.0f, 0.0f);
			do{
				x1 = Random.Range(0.0f, 15.0f);
				y1 = Random.Range(5.0f, 9.0f);
				x2 = Random.Range(0.0f, 15.0f);
				y2 = Random.Range(5.0f, 9.0f);
				
				k1 = (y1-0)/(x1-20);
				k2 = (y2-0)/(x2-20);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		else if (broj1 == 3){
			// sjeciste1.transform.position = new Vector3(20.0f, 9.0f, 0.0f);
			do{
				x1 = Random.Range(0.0f, 15.0f);
				y1 = Random.Range(0.0f, 5.0f);
				x2 = Random.Range(0.0f, 15.0f);
				y2 = Random.Range(0.0f, 5.0f);
				
				k1 = (y1-9)/(x1-20);
				k2 = (y2-9)/(x2-20);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		else {
			// sjeciste1.transform.position = new Vector3(0.0f, 9.0f, 0.0f);
			do{
				x1 = Random.Range(5.0f, 20.0f);
				y1 = Random.Range(0.0f, 5.0f);
				x2 = Random.Range(5.0f, 20.0f);
				y2 = Random.Range(0.0f, 5.0f);
				
				k1 = (y1-9)/(x1-0);
				k2 = (y2-9)/(x2-0);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		
		
		// II. KVADRANT
		if (broj2 == 1){
			//sjeciste2.transform.position = new Vector3(-20.0f, 0.0f, 0.0f);
			do{
				x3 = Random.Range(-15.0f, 0.0f);
				y3 = Random.Range(5.0f, 9.0f);
				x4 = Random.Range(-15.0f, 0.0f);
				y4 = Random.Range(5.0f, 9.0f);
				
				k1 = (y3-0)/(x3+20);
				k2 = (y4-0)/(x4+20);
			}while(Mathf.Abs(k1-k2)<0.4);			
		}
		else if (broj2 == 2){
			// sjeciste2.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
			do{
				x3 = Random.Range(-20.0f, -5.0f);
				y3 = Random.Range(5.0f, 9.0f);
				x4 = Random.Range(-20.0f, -5.0f);
				y4 = Random.Range(5.0f, 9.0f);
				
				k1 = (y3-0)/(x3-0);
				k2 = (y4-0)/(x4-0);
			}while(Mathf.Abs(k1-k2)<0.4);	
		}
		else if (broj2 == 3){
			// sjeciste2.transform.position = new Vector3(0.0f, 9.0f, 0.0f);
			do{
				x3 = Random.Range(-20.0f, -5.0f);
				y3 = Random.Range(0.0f, 5.0f);
				x4 = Random.Range(-20.0f, -5.0f);
				y4 = Random.Range(0.0f, 5.0f);
				
				k1 = (y3-9)/(x3-0);
				k2 = (y4-9)/(x4-0);
			}while(Mathf.Abs(k1-k2)<0.4);	
		}
		else {
			// sjeciste2.transform.position = new Vector3(-20.0f, 9.0f, 0.0f);
			do{
				x3 = Random.Range(-15.0f, 0.0f);
				y3 = Random.Range(0.0f, 5.0f);
				x4 = Random.Range(-15.0f, 0.0f);
				y4 = Random.Range(0.0f, 5.0f);
				
				k1 = (y3-9)/(x3+20);
				k2 = (y4-9)/(x4+20);
			}while(Mathf.Abs(k1-k2)<0.4);	
		}
		
		
		// III. KVADRANT
		if (broj3 == 1){
			// sjeciste3.transform.position = new Vector3(-20.0f, -9.0f, 0.0f);
			do{
				x5 = Random.Range(-15.0f, 0.0f);
				y5 = Random.Range(-5.0f, 0.0f);
				x6 = Random.Range(-15.0f, 0.0f);
				y6 = Random.Range(-5.0f, 0.0f);
				
				k1 = (y5+9)/(x5+20);
				k2 = (y6+9)/(x6+20);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		else if (broj3 == 2){
			// sjeciste3.transform.position = new Vector3(0.0f, -9.0f, 0.0f);
			do{
				x5 = Random.Range(-20.0f, -5.0f);
				y5 = Random.Range(-5.0f, 0.0f);
				x6 = Random.Range(-20.0f, -5.0f);
				y6 = Random.Range(-5.0f, 0.0f);
				
				k1 = (y5+9)/(x5-0);
				k2 = (y6+9)/(x6-0);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		else if (broj3 == 3){
			// sjeciste3.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
			do{
				x5 = Random.Range(-20.0f, -5.0f);
				y5 = Random.Range(-5.0f, -9.0f);
				x6 = Random.Range(-20.0f, -5.0f);
				y6 = Random.Range(-5.0f, -9.0f);
				
				k1 = (y5-0)/(x5-0);
				k2 = (y6-0)/(x6-0);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		else {
			// sjeciste3.transform.position = new Vector3(-20.0f, 0.0f, 0.0f);
			do{
				x5 = Random.Range(-15.0f, 0.0f);
				y5 = Random.Range(-5.0f, -9.0f);
				x6 = Random.Range(-15.0f, 0.0f);
				y6 = Random.Range(-5.0f, -9.0f);
				
				k1 = (y5-0)/(x5+20);
				k2 = (y6-0)/(x6+20);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		
		
		// IV. KVADRANT
		if (broj4 == 1){
			// sjeciste4.transform.position = new Vector3(0.0f, -9.0f, 0.0f);
			do{
				x7 = Random.Range(5.0f, 20.0f);
				y7 = Random.Range(-5.0f, 0.0f);
				x8 = Random.Range(5.0f, 20.0f);
				y8 = Random.Range(-5.0f, 0.0f);
				
				k1 = (y7+9)/(x7-0);
				k2 = (y8+9)/(x8-0);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		else if (broj4 == 2){
			// sjeciste4.transform.position = new Vector3(20.0f, -9.0f, 0.0f);
			do{
				x7 = Random.Range(0.0f, 15.0f);
				y7 = Random.Range(-5.0f, 0.0f);
				x8 = Random.Range(0.0f, 15.0f);
				y8 = Random.Range(-5.0f, 0.0f);
				
				k1 = (y7+9)/(x7-20);
				k2 = (y8+9)/(x8-20);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		else if (broj4 == 3){
			// sjeciste4.transform.position = new Vector3(20.0f, 0.0f, 0.0f);
			do{
				x7 = Random.Range(0.0f, 15.0f);
				y7 = Random.Range(-9.0f, -5.0f);
				x8 = Random.Range(0.0f, 15.0f);
				y8 = Random.Range(-9.0f, -5.0f);
				
				k1 = (y7-0)/(x7-20);
				k2 = (y8-0)/(x8-20);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
		else {
			// sjeciste4.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
			do{
				x7 = Random.Range(5.0f, 20.0f);
				y7 = Random.Range(-9.0f, -5.0f);
				x8 = Random.Range(5.0f, 20.0f);
				y8 = Random.Range(-9.0f, -5.0f);
				
				k1 = (y7-0)/(x7-0);
				k2 = (y8-0)/(x8-0);
			}while(Mathf.Abs(k1-k2)<0.4);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (broj1 == 1){
			Debug.DrawLine(Vector3.zero, new Vector3(x1, y1, 0), Color.yellow);
			Debug.DrawLine(Vector3.zero, new Vector3(x2, y2, 0), Color.yellow);
		}
		else if (broj1 == 2){
			Debug.DrawLine(new Vector3(20, 0, 0), new Vector3(x1, y1, 0), Color.yellow);
			Debug.DrawLine(new Vector3(20, 0, 0), new Vector3(x2, y2, 0), Color.yellow);
		}
		else if (broj1 == 3){
			Debug.DrawLine(new Vector3(20, 9, 0), new Vector3(x1, y1, 0), Color.yellow);
			Debug.DrawLine(new Vector3(20, 9, 0), new Vector3(x2, y2, 0), Color.yellow);
		}
		else {
			Debug.DrawLine(new Vector3(0, 9, 0), new Vector3(x1, y1, 0), Color.yellow);
			Debug.DrawLine(new Vector3(0, 9, 0), new Vector3(x2, y2, 0), Color.yellow);
		}
		
		if (broj2 == 1){
			Debug.DrawLine(new Vector3(-20, 0, 0), new Vector3(x3, y3, 0), Color.red);
			Debug.DrawLine(new Vector3(-20, 0, 0), new Vector3(x4, y4, 0), Color.red);
		}
		else if (broj2 == 2){
			Debug.DrawLine(Vector3.zero, new Vector3(x3, y3, 0), Color.red);
			Debug.DrawLine(Vector3.zero, new Vector3(x4, y4, 0), Color.red);
		}
		else if (broj2 == 3){
			Debug.DrawLine(new Vector3(0, 9, 0), new Vector3(x3, y3, 0), Color.red);
			Debug.DrawLine(new Vector3(0, 9, 0), new Vector3(x4, y4, 0), Color.red);
		}
		else {
			Debug.DrawLine(new Vector3(-20, 9, 0), new Vector3(x3, y3, 0), Color.red);
			Debug.DrawLine(new Vector3(-20, 9, 0), new Vector3(x4, y4, 0), Color.red);
		}
		
		if (broj3 == 1){
			Debug.DrawLine(new Vector3(-20, -9, 0), new Vector3(x5, y5, 0), Color.green);
			Debug.DrawLine(new Vector3(-20, -9, 0), new Vector3(x6, y6, 0), Color.green);
		}
		else if (broj3 == 2){
			Debug.DrawLine(new Vector3(0, -9, 0), new Vector3(x5, y5, 0), Color.green);
			Debug.DrawLine(new Vector3(0, -9, 0), new Vector3(x6, y6, 0), Color.green);
		}
		else if (broj3 == 3){
			Debug.DrawLine(Vector3.zero, new Vector3(x5, y5, 0), Color.green);
			Debug.DrawLine(Vector3.zero, new Vector3(x6, y6, 0), Color.green);
		}
		else {
			Debug.DrawLine(new Vector3(-20, 0, 0), new Vector3(x5, y5, 0), Color.green);
			Debug.DrawLine(new Vector3(-20, 0, 0), new Vector3(x6, y6, 0), Color.green);
		}
		
		if (broj4 == 1){
			Debug.DrawLine(new Vector3(0, -9, 0), new Vector3(x7, y7, 0), Color.blue);
			Debug.DrawLine(new Vector3(0, -9, 0), new Vector3(x8, y8, 0), Color.blue);
		}
		else if (broj4 == 2){
			Debug.DrawLine(new Vector3(20, -9, 0), new Vector3(x7, y7, 0), Color.blue);
			Debug.DrawLine(new Vector3(20, -9, 0), new Vector3(x8, y8, 0), Color.blue);
		}
		else if (broj4 == 3){
			Debug.DrawLine(new Vector3(20, 0, 0), new Vector3(x7, y7, 0), Color.blue);
			Debug.DrawLine(new Vector3(20, 0, 0), new Vector3(x8, y8, 0), Color.blue);
		}
		else {
			Debug.DrawLine(Vector3.zero, new Vector3(x7, y7, 0), Color.blue);
			Debug.DrawLine(Vector3.zero, new Vector3(x8, y8, 0), Color.blue);
		}
	}
}
