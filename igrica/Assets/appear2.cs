using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class appear2 : MonoBehaviour
{
    bool showWindow = false;
    public int selGridInt = 0;
    public string[] selStrings = new string[] { " 1", " 2", " 3", " 4" };

    public Rect windowRect = new Rect(100, 800, 2000, 1500);
    public string stringToEdit = "Hello World";
    public int testNumber;
    public int userClicked = 0;
    public int numOfTests = 4;
    private int correctAnswer = 1;
    public int rate = 0;
    static int counter_case = 10;  //Number of simulation tests
    int numOfSeconds = 2; //How long is simulation going

    public GameObject plane1;
    public GameObject plane2;
    public GameObject plane3;
    public GameObject plane4;
    public GameObject plane5;
    public GameObject plane6;
    public GameObject plane7;
    public GameObject plane8;

    float x1, x2, y1, y2, x3, x4, y3, y4, x5, x6, y5, y6, x7, x8, y7, y8;
    float k1, k2;
    int broj1, broj2, broj3, broj4;

    int counter = 0;
    bool moving = true;
    float Vx1, Vx2, Vy1, Vy2, speed1, speed2, step1, step2;
    float Vx3, Vx4, Vy3, Vy4, speed3, speed4, step3, step4;
    float Vx5, Vx6, Vy5, Vy6, speed5, speed6, step5, step6;
    float Vx7, Vx8, Vy7, Vy8, speed7, speed8, step7, step8;


    private void Start()
    {

        float Num1 = Random.Range(1.0f, 5.0f);
        broj1 = (int)Num1;

        float Num2 = Random.Range(1.0f, 5.0f);
        broj2 = (int)Num2;

        float Num3 = Random.Range(1.0f, 5.0f);
        broj3 = (int)Num3;

        float Num4 = Random.Range(1.0f, 5.0f);
        broj4 = (int)Num4;


        // I. KVADRANT
        if (broj1 == 1)
        {
            // sjeciste1.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            do
            {
                x1 = Random.Range(5.0f, 20.0f);
                y1 = Random.Range(5.0f, 9.0f);
                x2 = Random.Range(5.0f, 20.0f);
                y2 = Random.Range(5.0f, 9.0f);

                k1 = (y1 - 0) / (x1 - 0);
                k2 = (y2 - 0) / (x2 - 0);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx1 = (0 - x1) / 3;
            Vx2 = (0 - x2) / 3;
            Vy1 = (0 - y1) / 3;
            Vy2 = (0 - y2) / 3;
            speed1 = Mathf.Sqrt(Vx1 * Vx1 + Vy1 * Vy1);
            speed2 = Mathf.Sqrt(Vx2 * Vx2 + Vy2 * Vy2);
        }
        else if (broj1 == 2)
        {
            // sjeciste1.transform.position = new Vector3(20.0f, 0.0f, 0.0f);
            do
            {
                x1 = Random.Range(0.0f, 15.0f);
                y1 = Random.Range(5.0f, 9.0f);
                x2 = Random.Range(0.0f, 15.0f);
                y2 = Random.Range(5.0f, 9.0f);

                k1 = (y1 - 0) / (x1 - 20);
                k2 = (y2 - 0) / (x2 - 20);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx1 = (20 - x1) / 3;
            Vx2 = (20 - x2) / 3;
            Vy1 = (0 - y1) / 3;
            Vy2 = (0 - y2) / 3;
            speed1 = Mathf.Sqrt(Vx1 * Vx1 + Vy1 * Vy1);
            speed2 = Mathf.Sqrt(Vx2 * Vx2 + Vy2 * Vy2);
        }
        else if (broj1 == 3)
        {
            // sjeciste1.transform.position = new Vector3(20.0f, 9.0f, 0.0f);
            do
            {
                x1 = Random.Range(0.0f, 15.0f);
                y1 = Random.Range(0.0f, 5.0f);
                x2 = Random.Range(0.0f, 15.0f);
                y2 = Random.Range(0.0f, 5.0f);

                k1 = (y1 - 9) / (x1 - 20);
                k2 = (y2 - 9) / (x2 - 20);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx1 = (20 - x1) / 3;
            Vx2 = (20 - x2) / 3;
            Vy1 = (9 - y1) / 3;
            Vy2 = (9 - y2) / 3;
            speed1 = Mathf.Sqrt(Vx1 * Vx1 + Vy1 * Vy1);
            speed2 = Mathf.Sqrt(Vx2 * Vx2 + Vy2 * Vy2);
        }
        else
        {
            // sjeciste1.transform.position = new Vector3(0.0f, 9.0f, 0.0f);
            do
            {
                x1 = Random.Range(5.0f, 20.0f);
                y1 = Random.Range(0.0f, 5.0f);
                x2 = Random.Range(5.0f, 20.0f);
                y2 = Random.Range(0.0f, 5.0f);

                k1 = (y1 - 9) / (x1 - 0);
                k2 = (y2 - 9) / (x2 - 0);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx1 = (0 - x1) / 3;
            Vx2 = (0 - x2) / 3;
            Vy1 = (9 - y1) / 3;
            Vy2 = (9 - y2) / 3;
            speed1 = Mathf.Sqrt(Vx1 * Vx1 + Vy1 * Vy1);
            speed2 = Mathf.Sqrt(Vx2 * Vx2 + Vy2 * Vy2);
        }


        // II. KVADRANT
        if (broj2 == 1)
        {
            //sjeciste2.transform.position = new Vector3(-20.0f, 0.0f, 0.0f);
            do
            {
                x3 = Random.Range(-15.0f, 0.0f);
                y3 = Random.Range(5.0f, 9.0f);
                x4 = Random.Range(-15.0f, 0.0f);
                y4 = Random.Range(5.0f, 9.0f);

                k1 = (y3 - 0) / (x3 + 20);
                k2 = (y4 - 0) / (x4 + 20);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx3 = (-20 - x3) / 3;
            Vx4 = (-20 - x4) / 3;
            Vy3 = (0 - y3) / 3;
            Vy4 = (0 - y4) / 3;
            speed3 = Mathf.Sqrt(Vx3 * Vx3 + Vy3 * Vy3);
            speed4 = Mathf.Sqrt(Vx4 * Vx4 + Vy4 * Vy4);
        }
        else if (broj2 == 2)
        {
            // sjeciste2.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            do
            {
                x3 = Random.Range(-20.0f, -5.0f);
                y3 = Random.Range(5.0f, 9.0f);
                x4 = Random.Range(-20.0f, -5.0f);
                y4 = Random.Range(5.0f, 9.0f);

                k1 = (y3 - 0) / (x3 - 0);
                k2 = (y4 - 0) / (x4 - 0);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx3 = (0 - x3) / 3;
            Vx4 = (0 - x4) / 3;
            Vy3 = (0 - y3) / 3;
            Vy4 = (0 - y4) / 3;
            speed3 = Mathf.Sqrt(Vx3 * Vx3 + Vy3 * Vy3);
            speed4 = Mathf.Sqrt(Vx4 * Vx4 + Vy4 * Vy4);
        }
        else if (broj2 == 3)
        {
            // sjeciste2.transform.position = new Vector3(0.0f, 9.0f, 0.0f);
            do
            {
                x3 = Random.Range(-20.0f, -5.0f);
                y3 = Random.Range(0.0f, 5.0f);
                x4 = Random.Range(-20.0f, -5.0f);
                y4 = Random.Range(0.0f, 5.0f);

                k1 = (y3 - 9) / (x3 - 0);
                k2 = (y4 - 9) / (x4 - 0);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx3 = (0 - x3) / 3;
            Vx4 = (0 - x4) / 3;
            Vy3 = (9 - y3) / 3;
            Vy4 = (9 - y4) / 3;
            speed3 = Mathf.Sqrt(Vx3 * Vx3 + Vy3 * Vy3);
            speed4 = Mathf.Sqrt(Vx4 * Vx4 + Vy4 * Vy4);
        }
        else
        {
            // sjeciste2.transform.position = new Vector3(-20.0f, 9.0f, 0.0f);
            do
            {
                x3 = Random.Range(-15.0f, 0.0f);
                y3 = Random.Range(0.0f, 5.0f);
                x4 = Random.Range(-15.0f, 0.0f);
                y4 = Random.Range(0.0f, 5.0f);

                k1 = (y3 - 9) / (x3 + 20);
                k2 = (y4 - 9) / (x4 + 20);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx3 = (-20 - x3) / 3;
            Vx4 = (-20 - x4) / 3;
            Vy3 = (9 - y3) / 3;
            Vy4 = (9 - y4) / 3;
            speed3 = Mathf.Sqrt(Vx3 * Vx3 + Vy3 * Vy3);
            speed4 = Mathf.Sqrt(Vx4 * Vx4 + Vy4 * Vy4);
        }


        // III. KVADRANT
        if (broj3 == 1)
        {
            // sjeciste3.transform.position = new Vector3(-20.0f, -9.0f, 0.0f);
            do
            {
                x5 = Random.Range(-15.0f, 0.0f);
                y5 = Random.Range(-5.0f, 0.0f);
                x6 = Random.Range(-15.0f, 0.0f);
                y6 = Random.Range(-5.0f, 0.0f);

                k1 = (y5 + 9) / (x5 + 20);
                k2 = (y6 + 9) / (x6 + 20);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx5 = (-20 - x5) / 3;
            Vx6 = (-20 - x6) / 3;
            Vy5 = (-9 - y5) / 3;
            Vy6 = (-9 - y6) / 3;
            speed5 = Mathf.Sqrt(Vx5 * Vx5 + Vy5 * Vy5);
            speed6 = Mathf.Sqrt(Vx6 * Vx6 + Vy6 * Vy6);
        }
        else if (broj3 == 2)
        {
            // sjeciste3.transform.position = new Vector3(0.0f, -9.0f, 0.0f);
            do
            {
                x5 = Random.Range(-20.0f, -5.0f);
                y5 = Random.Range(-5.0f, 0.0f);
                x6 = Random.Range(-20.0f, -5.0f);
                y6 = Random.Range(-5.0f, 0.0f);

                k1 = (y5 + 9) / (x5 - 0);
                k2 = (y6 + 9) / (x6 - 0);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx5 = (0 - x5) / 3;
            Vx6 = (0 - x6) / 3;
            Vy5 = (-9 - y5) / 3;
            Vy6 = (-9 - y6) / 3;
            speed5 = Mathf.Sqrt(Vx5 * Vx5 + Vy5 * Vy5);
            speed6 = Mathf.Sqrt(Vx6 * Vx6 + Vy6 * Vy6);
        }
        else if (broj3 == 3)
        {
            // sjeciste3.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            do
            {
                x5 = Random.Range(-20.0f, -5.0f);
                y5 = Random.Range(-5.0f, -9.0f);
                x6 = Random.Range(-20.0f, -5.0f);
                y6 = Random.Range(-5.0f, -9.0f);

                k1 = (y5 - 0) / (x5 - 0);
                k2 = (y6 - 0) / (x6 - 0);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx5 = (0 - x5) / 3;
            Vx6 = (0 - x6) / 3;
            Vy5 = (0 - y5) / 3;
            Vy6 = (0 - y6) / 3;
            speed5 = Mathf.Sqrt(Vx5 * Vx5 + Vy5 * Vy5);
            speed6 = Mathf.Sqrt(Vx6 * Vx6 + Vy6 * Vy6);
        }
        else
        {
            // sjeciste3.transform.position = new Vector3(-20.0f, 0.0f, 0.0f);
            do
            {
                x5 = Random.Range(-15.0f, 0.0f);
                y5 = Random.Range(-5.0f, -9.0f);
                x6 = Random.Range(-15.0f, 0.0f);
                y6 = Random.Range(-5.0f, -9.0f);

                k1 = (y5 - 0) / (x5 + 20);
                k2 = (y6 - 0) / (x6 + 20);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx5 = (-20 - x5) / 3;
            Vx6 = (-20 - x6) / 3;
            Vy5 = (0 - y5) / 3;
            Vy6 = (0 - y6) / 3;
            speed5 = Mathf.Sqrt(Vx5 * Vx5 + Vy5 * Vy5);
            speed6 = Mathf.Sqrt(Vx6 * Vx6 + Vy6 * Vy6);
        }


        // IV. KVADRANT
        if (broj4 == 1)
        {
            // sjeciste4.transform.position = new Vector3(0.0f, -9.0f, 0.0f);
            do
            {
                x7 = Random.Range(5.0f, 20.0f);
                y7 = Random.Range(-5.0f, 0.0f);
                x8 = Random.Range(5.0f, 20.0f);
                y8 = Random.Range(-5.0f, 0.0f);

                k1 = (y7 + 9) / (x7 - 0);
                k2 = (y8 + 9) / (x8 - 0);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx7 = (0 - x7) / 3;
            Vx8 = (0 - x8) / 3;
            Vy7 = (-9 - y7) / 3;
            Vy8 = (-9 - y8) / 3;
            speed7 = Mathf.Sqrt(Vx7 * Vx7 + Vy7 * Vy7);
            speed8 = Mathf.Sqrt(Vx8 * Vx8 + Vy8 * Vy8);
        }
        else if (broj4 == 2)
        {
            // sjeciste4.transform.position = new Vector3(20.0f, -9.0f, 0.0f);
            do
            {
                x7 = Random.Range(0.0f, 15.0f);
                y7 = Random.Range(-5.0f, 0.0f);
                x8 = Random.Range(0.0f, 15.0f);
                y8 = Random.Range(-5.0f, 0.0f);

                k1 = (y7 + 9) / (x7 - 20);
                k2 = (y8 + 9) / (x8 - 20);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx7 = (20 - x7) / 3;
            Vx8 = (20 - x8) / 3;
            Vy7 = (-9 - y7) / 3;
            Vy8 = (-9 - y8) / 3;
            speed7 = Mathf.Sqrt(Vx7 * Vx7 + Vy7 * Vy7);
            speed8 = Mathf.Sqrt(Vx8 * Vx8 + Vy8 * Vy8);
        }
        else if (broj4 == 3)
        {
            // sjeciste4.transform.position = new Vector3(20.0f, 0.0f, 0.0f);
            do
            {
                x7 = Random.Range(0.0f, 15.0f);
                y7 = Random.Range(-9.0f, -5.0f);
                x8 = Random.Range(0.0f, 15.0f);
                y8 = Random.Range(-9.0f, -5.0f);

                k1 = (y7 - 0) / (x7 - 20);
                k2 = (y8 - 0) / (x8 - 20);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx7 = (20 - x7) / 3;
            Vx8 = (20 - x8) / 3;
            Vy7 = (0 - y7) / 3;
            Vy8 = (0 - y8) / 3;
            speed7 = Mathf.Sqrt(Vx7 * Vx7 + Vy7 * Vy7);
            speed8 = Mathf.Sqrt(Vx8 * Vx8 + Vy8 * Vy8);
        }
        else
        {
            // sjeciste4.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            do
            {
                x7 = Random.Range(5.0f, 20.0f);
                y7 = Random.Range(-9.0f, -5.0f);
                x8 = Random.Range(5.0f, 20.0f);
                y8 = Random.Range(-9.0f, -5.0f);

                k1 = (y7 - 0) / (x7 - 0);
                k2 = (y8 - 0) / (x8 - 0);
            } while (Mathf.Abs(k1 - k2) < 0.4);

            Vx7 = (0 - x7) / 3;
            Vx8 = (0 - x8) / 3;
            Vy7 = (0 - y7) / 3;
            Vy8 = (0 - y8) / 3;
            speed7 = Mathf.Sqrt(Vx7 * Vx7 + Vy7 * Vy7);
            speed8 = Mathf.Sqrt(Vx8 * Vx8 + Vy8 * Vy8);
        }

        StartCoroutine(Example());
    }


    IEnumerator Example()
    {

        yield return new WaitForSecondsRealtime(numOfSeconds);
        moving = false;

        showWindow = true;
    }



    void OnGUI()
    {
        if (showWindow)
        {
            GUIStyle myWindowStyle = new GUIStyle(GUI.skin.window);
            myWindowStyle.fontSize = 50;
            windowRect = GUI.Window(0, windowRect, DoMyWindow, "Koji se sudare treci? ", myWindowStyle);
            GUI.color = Color.yellow;



        }

    }
    void DoMyWindow(int windowID)
    {
        if (GUI.Button(new Rect(1300, 500, 200, 100), "NEXT"))
        {
            if (counter_case < 10)
            {
                SceneManager.LoadScene("Scene1");
                counter_case++;
            }
            else if (counter_case < 30)
            {
                SceneManager.LoadScene("Scene2");
                counter_case++;
            } else
            {
                SceneManager.LoadScene("Scene3");
            }

            return;
        }


        if (GUI.Button(new Rect(50, 300, 200, 100), "1"))
        {
            Debug.Log("1 clicked");
            userClicked = 1;
            return;


        }

        if (GUI.Button(new Rect(300, 300, 200, 100), "2"))
        {
            Debug.Log("2 clicked");
            userClicked = 2;
            return;

        }

        if (GUI.Button(new Rect(550, 300, 200, 100), "3"))
        {
            Debug.Log("3 clicked");
            userClicked = 3;
            return;

        }

        if (GUI.Button(new Rect(800, 300, 200, 100), "4"))
        {
            Debug.Log("4 clicked");
            userClicked = 4;
            return;

        }


        return;

    }


    void Update()
    {
        counter++;
        if (moving)
        {
            step1 = (float)0.005 * speed1 * counter;
            step2 = (float)0.005 * speed2 * counter;
            step3 = (float)0.005 * speed3 * counter;
            step4 = (float)0.005 * speed4 * counter;
            step5 = (float)0.005 * speed5 * counter;
            step6 = (float)0.005 * speed6 * counter;
            step7 = (float)0.005 * speed7 * counter;
            step8 = (float)0.005 * speed8 * counter;
        }


        if (broj1 == 1)
        {
            plane1.transform.position = new Vector3(x1, y1, 0);
            plane2.transform.position = new Vector3(x2, y2, 0);

            plane1.transform.position = Vector2.MoveTowards(plane1.transform.position, new Vector2(0, 0), step1);
            plane2.transform.position = Vector2.MoveTowards(plane2.transform.position, new Vector2(0, 0), step2);

            Debug.DrawLine(Vector3.zero, new Vector3(x1, y1, 0), Color.yellow);
            Debug.DrawLine(Vector3.zero, new Vector3(x2, y2, 0), Color.yellow);
        }
        else if (broj1 == 2)
        {
            plane1.transform.position = new Vector3(x1, y1, 0);
            plane2.transform.position = new Vector3(x2, y2, 0);

            plane1.transform.position = Vector2.MoveTowards(plane1.transform.position, new Vector2(20, 0), step1);
            plane2.transform.position = Vector2.MoveTowards(plane2.transform.position, new Vector2(20, 0), step2);

            Debug.DrawLine(new Vector3(20, 0, 0), new Vector3(x1, y1, 0), Color.yellow);
            Debug.DrawLine(new Vector3(20, 0, 0), new Vector3(x2, y2, 0), Color.yellow);
        }
        else if (broj1 == 3)
        {
            plane1.transform.position = new Vector3(x1, y1, 0);
            plane2.transform.position = new Vector3(x2, y2, 0);

            plane1.transform.position = Vector2.MoveTowards(plane1.transform.position, new Vector2(20, 9), step1);
            plane2.transform.position = Vector2.MoveTowards(plane2.transform.position, new Vector2(20, 9), step2);

            Debug.DrawLine(new Vector3(20, 9, 0), new Vector3(x1, y1, 0), Color.yellow);
            Debug.DrawLine(new Vector3(20, 9, 0), new Vector3(x2, y2, 0), Color.yellow);
        }
        else
        {
            plane1.transform.position = new Vector3(x1, y1, 0);
            plane2.transform.position = new Vector3(x2, y2, 0);

            plane1.transform.position = Vector2.MoveTowards(plane1.transform.position, new Vector2(0, 9), step1);
            plane2.transform.position = Vector2.MoveTowards(plane2.transform.position, new Vector2(0, 9), step2);

            Debug.DrawLine(new Vector3(0, 9, 0), new Vector3(x1, y1, 0), Color.yellow);
            Debug.DrawLine(new Vector3(0, 9, 0), new Vector3(x2, y2, 0), Color.yellow);
        }

        if (broj2 == 1)
        {
            plane3.transform.position = new Vector3(x3, y3, 0);
            plane4.transform.position = new Vector3(x4, y4, 0);

            plane3.transform.position = Vector2.MoveTowards(plane3.transform.position, new Vector2(-20, 0), step3);
            plane4.transform.position = Vector2.MoveTowards(plane4.transform.position, new Vector2(-20, 0), step4);

            Debug.DrawLine(new Vector3(-20, 0, 0), new Vector3(x3, y3, 0), Color.red);
            Debug.DrawLine(new Vector3(-20, 0, 0), new Vector3(x4, y4, 0), Color.red);
        }
        else if (broj2 == 2)
        {
            plane3.transform.position = new Vector3(x3, y3, 0);
            plane4.transform.position = new Vector3(x4, y4, 0);

            plane3.transform.position = Vector2.MoveTowards(plane3.transform.position, new Vector2(0, 0), step3);
            plane4.transform.position = Vector2.MoveTowards(plane4.transform.position, new Vector2(0, 0), step4);

            Debug.DrawLine(Vector3.zero, new Vector3(x3, y3, 0), Color.red);
            Debug.DrawLine(Vector3.zero, new Vector3(x4, y4, 0), Color.red);
        }
        else if (broj2 == 3)
        {
            plane3.transform.position = new Vector3(x3, y3, 0);
            plane4.transform.position = new Vector3(x4, y4, 0);

            plane3.transform.position = Vector2.MoveTowards(plane3.transform.position, new Vector2(0, 9), step3);
            plane4.transform.position = Vector2.MoveTowards(plane4.transform.position, new Vector2(0, 9), step4);

            Debug.DrawLine(new Vector3(0, 9, 0), new Vector3(x3, y3, 0), Color.red);
            Debug.DrawLine(new Vector3(0, 9, 0), new Vector3(x4, y4, 0), Color.red);
        }
        else
        {
            plane3.transform.position = new Vector3(x3, y3, 0);
            plane4.transform.position = new Vector3(x4, y4, 0);

            plane3.transform.position = Vector2.MoveTowards(plane3.transform.position, new Vector2(-20, 9), step3);
            plane4.transform.position = Vector2.MoveTowards(plane4.transform.position, new Vector2(-20, 9), step4);

            Debug.DrawLine(new Vector3(-20, 9, 0), new Vector3(x3, y3, 0), Color.red);
            Debug.DrawLine(new Vector3(-20, 9, 0), new Vector3(x4, y4, 0), Color.red);
        }

        if (broj3 == 1)
        {
            plane5.transform.position = new Vector3(x5, y6, 0);
            plane6.transform.position = new Vector3(x6, y5, 0);

            plane5.transform.position = Vector2.MoveTowards(plane5.transform.position, new Vector2(-20, -9), step5);
            plane6.transform.position = Vector2.MoveTowards(plane6.transform.position, new Vector2(-20, -9), step6);

            Debug.DrawLine(new Vector3(-20, -9, 0), new Vector3(x5, y5, 0), Color.green);
            Debug.DrawLine(new Vector3(-20, -9, 0), new Vector3(x6, y6, 0), Color.green);
        }
        else if (broj3 == 2)
        {
            plane5.transform.position = new Vector3(x5, y6, 0);
            plane6.transform.position = new Vector3(x6, y5, 0);

            plane5.transform.position = Vector2.MoveTowards(plane5.transform.position, new Vector2(0, -9), step5);
            plane6.transform.position = Vector2.MoveTowards(plane6.transform.position, new Vector2(0, -9), step6);

            Debug.DrawLine(new Vector3(0, -9, 0), new Vector3(x5, y5, 0), Color.green);
            Debug.DrawLine(new Vector3(0, -9, 0), new Vector3(x6, y6, 0), Color.green);
        }
        else if (broj3 == 3)
        {
            plane5.transform.position = new Vector3(x5, y6, 0);
            plane6.transform.position = new Vector3(x6, y5, 0);

            plane5.transform.position = Vector2.MoveTowards(plane5.transform.position, new Vector2(0, 0), step5);
            plane6.transform.position = Vector2.MoveTowards(plane6.transform.position, new Vector2(0, 0), step6);

            Debug.DrawLine(Vector3.zero, new Vector3(x5, y5, 0), Color.green);
            Debug.DrawLine(Vector3.zero, new Vector3(x6, y6, 0), Color.green);
        }
        else
        {
            plane5.transform.position = new Vector3(x5, y6, 0);
            plane6.transform.position = new Vector3(x6, y5, 0);

            plane5.transform.position = Vector2.MoveTowards(plane5.transform.position, new Vector2(-20, 0), step5);
            plane6.transform.position = Vector2.MoveTowards(plane6.transform.position, new Vector2(-20, 0), step6);

            Debug.DrawLine(new Vector3(-20, 0, 0), new Vector3(x5, y5, 0), Color.green);
            Debug.DrawLine(new Vector3(-20, 0, 0), new Vector3(x6, y6, 0), Color.green);
        }

        if (broj4 == 1)
        {
            plane7.transform.position = new Vector3(x7, y7, 0);
            plane8.transform.position = new Vector3(x8, y8, 0);

            plane7.transform.position = Vector2.MoveTowards(plane7.transform.position, new Vector2(0, -9), step7);
            plane8.transform.position = Vector2.MoveTowards(plane8.transform.position, new Vector2(0, -9), step8);

            Debug.DrawLine(new Vector3(0, -9, 0), new Vector3(x7, y7, 0), Color.blue);
            Debug.DrawLine(new Vector3(0, -9, 0), new Vector3(x8, y8, 0), Color.blue);
        }
        else if (broj4 == 2)
        {
            plane7.transform.position = new Vector3(x7, y7, 0);
            plane8.transform.position = new Vector3(x8, y8, 0);

            plane7.transform.position = Vector2.MoveTowards(plane7.transform.position, new Vector2(20, -9), step7);
            plane8.transform.position = Vector2.MoveTowards(plane8.transform.position, new Vector2(20, -9), step8);

            Debug.DrawLine(new Vector3(20, -9, 0), new Vector3(x7, y7, 0), Color.blue);
            Debug.DrawLine(new Vector3(20, -9, 0), new Vector3(x8, y8, 0), Color.blue);
        }
        else if (broj4 == 3)
        {
            plane7.transform.position = new Vector3(x7, y7, 0);
            plane8.transform.position = new Vector3(x8, y8, 0);

            plane7.transform.position = Vector2.MoveTowards(plane7.transform.position, new Vector2(20, 0), step7);
            plane8.transform.position = Vector2.MoveTowards(plane8.transform.position, new Vector2(20, 0), step8);

            Debug.DrawLine(new Vector3(20, 0, 0), new Vector3(x7, y7, 0), Color.blue);
            Debug.DrawLine(new Vector3(20, 0, 0), new Vector3(x8, y8, 0), Color.blue);
        }
        else
        {
            plane7.transform.position = new Vector3(x7, y7, 0);
            plane8.transform.position = new Vector3(x8, y8, 0);

            plane7.transform.position = Vector2.MoveTowards(plane7.transform.position, new Vector2(0, 0), step7);
            plane8.transform.position = Vector2.MoveTowards(plane8.transform.position, new Vector2(0, 0), step8);

            Debug.DrawLine(Vector3.zero, new Vector3(x7, y7, 0), Color.blue);
            Debug.DrawLine(Vector3.zero, new Vector3(x8, y8, 0), Color.blue);
        }
    }


}





/*using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    int selGridInt = 0;
    string[] selStrings = { "radio1", "radio2", "radio3" };

    void OnGUI()
    {
        GUILayout.BeginVertical("Box");
        selGridInt = GUILayout.SelectionGrid(selGridInt, selStrings, 1);
        if (GUILayout.Button("Start"))
        {
            Debug.Log("You chose " + selStrings[selGridInt]);
        }
        GUILayout.EndVertical();
    }
}*/
























