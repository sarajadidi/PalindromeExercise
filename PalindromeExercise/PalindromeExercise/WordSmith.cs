using System;


namespace PalindromeExercise
{
	public class WordSmith
	{
		
        public bool IsAPalendrome(string word)
        {
            //reverse the word see that is it the same after reversed
            var reversed = "";
            for(int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            if(reversed == word)
            {
                return true;
            }
            else
            {
                return false;
            }

            //compare with original
            //retrun whether true or false/ same or not
        }
    }
}

