# Introduction

Noting down QuickSort for everytime I have to remember it for interviews.

# How QuickSort works in my words

1. Pick a value as the starting point
2. Move the lower values to the left and the higher values to the right. 
3. The algorithm will put the pivot value in the correct spot.
4. Now you have 2 smaller piles. Note that the piles are not necessarily sorted.
5. With each pile repeat the steps above.

# Time Complexity

The average time of using a QuickSort is O(n log n).  
But in it's worse secnario it is O(n^2).

A worse case scenario for QuickSort is when the pivot value used splits the array into 1 element on one side and the rest on the other. Or when the array is already sorted in ascending or descending order.

To avoid this you can mitigate it by doing some of the following:
- User different stragegy of selecting the pivot value. eg. Randomly or using a median of some sort.
- Change to a different sort if the recursion depth traversed is too deep.

# Space Complexity

Best and average case it has O(log n) space complexity.
Worst case it has O(n) space complexity.