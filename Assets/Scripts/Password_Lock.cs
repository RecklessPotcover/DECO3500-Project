using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password_Lock : MonoBehaviour
{
    public string password;

    private string input = "";

    // Input a number
    public void add(string number)
    {
        if (input.Length <= 5)
        {
            input = string.Concat(input, number);
        }
    }

    // Delete one number from the last
    public void delete()
    {
        if (input.Length >= 1)
        {
            input = input.Remove(input.Length - 1, 1);
        }
    }

    // Clear the input
    public void clear()
    {
        input = "";
    }

    // Return a new string where the input is in proper format
    public string display()
    {
        // Convert string to array inspired by https://www.geeksforgeeks.org/convert-string-to-character-array-in-c-sharp/
        string[] stringArray = new string[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            stringArray[i] = " " + input[i] + " ";
        }

        string displayContent = string.Join("", stringArray);

        return displayContent;
    }

    // Compare the input with the password
    public bool verifyPassword()
    {
        if (input == password)
        {
            return true;
        }
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
