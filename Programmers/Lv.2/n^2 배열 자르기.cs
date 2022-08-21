using System;

public class Solution
{
    public int[] solution(int n, long left, long right)
    {
        int[] answer = new int[right-left+1];

        for(long i=left; i<right+1; i++)
        {
            if (i == 0)
                answer[i - left] = 1;
            else
                answer[i - left] = (int)Math.Max(i / n, i % n) + 1;
        }

        return answer;
    }
}