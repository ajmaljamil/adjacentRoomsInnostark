# adjacentRoomsInnostark
Write an algorithm that tells the state of the Cell Block after n number of days

#CompeleteStatement  
Eight(8) rooms adjacent to each other are called a Cell-Block and each room is called a Cell. On a given day, each cell is either occupied or empty. An integer value of 0 or 1 represents each cell as either 1=occupied and 0=empty. Every passing day all cell updates their values based on following logic.  
1.	If a cell with its adjacent cells(right cell and left cell) are both empty=0 or both occupied=1, then cell updates its value to empty  
2.	Otherwise cell updates its value to occupied=1  
3.	Consider left cell of the first cell and right cell of the last cell as empty=0  
Write an algorithm that tells the state of the Cell Block after n number of days  
Example after n=2 days  
Current State of the cell  
	0	1	1	0	0	1	0	0	  

After Day 1  
 	1	1	1	1	1	0	1	0  

After Day 2  
	1	0	0	0	1	0	0	1  
  


**A: Explain in your words the approach you have taken to solve the problem**  
I have used XOR bitwise operator ^ to get the desired result, we could have also used ternary operator instead of bitwise operator. Also a for loop which does not include cornor cases as we will deal with the cornor cases separately.  
*Details:* I have checked first whether we have 0 days or 0 length of the input string. Then I checked cornor cases and also checked when we will have 1 length of input array. To make it better performance wise I used *Buffer.BlockCopy* because BlockCopy is aimed at fast byte-level primitive array copying, whereas Copy is the general-purpose implementation also used XOR bitwise operator. As you can see it is nothing but updation of an array and returing a list of int. Also given a touch of lambda expression in the code.  
  
**Explain what is the time-complexity (O) of your algorithm and how you are calculating it**  
Time complexity varies depending upon the input array and number of days. when we will have input array with length greater than ONE and we have number of days (d) greater than ONE In this case we will have time complexity O(d*(N-2)) i.e. excluding cornor cases because we will have constant time complexity for cornor cases.