using UnityEngine;

public class OddEven : MonoBehaviour
{
    void Start()
    {
        var counter = 10;
        while (counter > 0)
        {
            if(counter % 2 == 0)
            {
                print(counter + " is even");
            }
            else
            {
                print(counter + " is odd");
            }
            counter--;
        }
    }
}