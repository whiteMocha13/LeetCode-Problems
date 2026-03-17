### Palindrome Numbers
 
A palindrome number is a number that reads the same backward as forward. For example, 121 is a palindrome, while 123 is not. 

To determine if a number is a palindrome, I followed these steps: 

1. First I checked if the number is negative. If it is, then it cannot be a palindrome, so I returned false.
2. Next, I modded the number by 10 to get the last digit and stored it in a List called 'digits'. 
3. I then removed the last digit from the number by dividing it by 10. I repeated this process until the number became 0, which means I had extracted all the digits and stored them in the list.
4. Finally, I compared the digits in the list to check if they are the same when read from the front and back, by using the last index and the first index of the list. If they are the same, I returned true, indicating that the number is a palindrome. If they are not the same, I returned false. 

--- 

###### Time Complexity: O(n), where n is the number of digits in the input number. This is because we need to extract each digit and compare them.

### *wm13*
