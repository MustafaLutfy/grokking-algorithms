<h2>EXERCISES 📝</h2>

<h3>Chapter 1</h3>

1.1 Suppose you have a sorted list of 128 names, and you’re searching 
through it using binary search. What’s the maximum number of 
steps it would take?

Answer : 7 Steps 
I also made a code to solve this type of problem included in this repo "numOfSteps.cs"

1.2 Suppose you double the size of the list. What’s the maximum 
number of steps now?

Answer : 8 Steps 
The number is doubled so it needs only one more step (divde by 2) to reach the previous value of exercice 1.1

1.3   You have a name, and you want to find the person’s phone number 
in the phone book. 

Answer : Since we have a known name the names sorted alphbetically so the best way is to use binary search that have run time of O(log n)

1.4   You have a phone number, and you want to find the person’s name 
in the phone book. (Hint: You’ll have to search through the whole 
book!)

Answer : Since we don't have a known name the numbers are not sorted so the have to use the slowest way (simple search) that have run time of O(n)

1.5   You want to read the numbers of every person in the phone book.

Answer: Same as before O(n)

 1.6 You want to read the numbers of just the As. 

Answer: Same as before O(n)



<h2>Big O notation</h2>
<h3>Solutions</h3>

1-O(n) depends on the count of input linearly 

2-O(n) also depends on the count of input lineary

3-O(1) the code perform once (one itteration)

4-O(n) depends on the count of input lineary 

5-O(log n) each time value is divided by 2 and get smaller to half each itteration

6-O(n^1/2) each time the value equals the square root of the input value n

7-O(n) for unbalanced BST 

8-O(n) for unorderd BT

9-O(n^2) each time the first loop run it runs another loop depending on the number of inputs

10-O(log10 n) each time value is divided by 10 and get smaller to half each itteration


