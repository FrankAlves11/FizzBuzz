using System;

public string FizzBuzz(int number)
{
    var answer = "";  // we are initializing a variable called "answer" and setting its variable to a empty string

    if (number % 3 == 0)  // We are checking if the remainder of the division of 'number' by 3 is 0.
    {
        answer = "fizz"; // if the above condition is true, the code inside this block will execute.

    }

    if (number % 5 == 0) // we are checking if the remainder of the division of 'number' by '5' is '0'. 
    {
        answer += "buzz"; // if the code above is true than the code inside the block will execute
    }

    return answer; // returning the current value of the 'answer' variable
}