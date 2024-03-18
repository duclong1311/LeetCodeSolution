// public class Solution
// {
//     public int MaxProfit(int[] prices)
//     {
//         int min = prices[0];
//         int max;
//         int k = 0; // day buy min
//         // find buy min
//         for (int i = 0; i < prices.Length; i++)
//         {
//             if (prices[i] < min)
//             {
//                 min = prices[i];
//                 k = i;
//             }
//         }
//         if (k == prices.Length)
//             return 0;
//         else
//         {
//             // Find sell max
//             max = prices[k];
//             for (int i = k; i < prices.Length; i++)
//             {
//                 if (prices[i] > max)
//                     max = prices[i];
//             }
//         }
//         return max - min;
//     }
// }

public class Solution {
    public int MaxProfit(int[] prices) {
        int buy = prices[0], profit = 0;
        for (int i = 0; i < prices.Length; i++){
            if (prices[i] < buy) {
                buy = prices[i];
            }
            else if (prices[i] - buy > profit){
                profit = prices[i] - buy;
            }
        }
        return profit;
    }
}