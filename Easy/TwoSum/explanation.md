### Two Sum 

- This problem is asking us to find two numbers in an array that add up to a specific target value.
 
- I solved this problem using two for loops to check every possible sums of two numbers in the array. 

---> The outer loop iterates through each number in the array and the inner loop checks the sum of the current number with every other latter number in the array. If the sum of the two numbers equals the target, we return their indices. If we finish checking all pairs and don't find a match, we return an empty array. 

---

###### Time Complexity: O(n^2), where n is the number of elements in the input array. This is because we have two nested loops that each iterate through the array.

### *wm13*
