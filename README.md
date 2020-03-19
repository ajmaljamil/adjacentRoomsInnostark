# adjacentRoomsInnostark
Write an algorithm that tells the state of the Cell Block after n number of days

#Compelete Statement
Eight(8) rooms adjacent to each other are called a Cell-Block and each room is called a Cell. On a given day, each cell is either occupied or empty. An integer value of 0 or 1 represents each cell as either 1=occupied and 0=empty. Every passing day all cell updates their values based on following logic.
1.	If a cell with its adjacent cells(right cell and left cell) are both empty=0 or both occupied=1, then cell updates its value to empty
2.	Otherwise cell updates its value to occupied=1
3.	Consider left cell of the first cell and right cell of the last cell as empty=0
Write an algorithm that tells the state of the Cell Block after n number of days
Example after n=2 days
Current State of the cell
			empty	occupied	occupied	empty	empty	occupied	empty	empty	
Empty=0 	0	1	1	0	0	1	0	0	Empty=0

After Day 1
			occupied	occupied	occupied	occupied	occupied	empty	occupied	empty	
Empty=0 	1	1	1	1	1	0	1	0	Empty=0

After Day 2
			occupied	empty	empty	empty	occupied	empty	empty	occupied	
Empty=0 	1	0	0	0	1	0	0	1	Empty=0

