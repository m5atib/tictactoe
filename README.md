**Tic Tac Toe Game on WFA**

using : 
 * C#
 * WFA
 * Guna UI
 * Bunifu UI

Now we need to make this real game with backend programming !

You have a 3 * 3 boolean matrix.

```
bool **matrixPatel [3][3]**
```

When you press any of the buttons 
in the game box, you must perform a set of the operations mentioned below, such as : 


```
anyButton_Click(row,col)
```
should set 1 as **X** or 0 as **O** after user clicked on any game box buttons then change current player, update marks storage etc.
```
getPlayerSymbol()
```
should return **X** or **O** 

```
getStatusOfGame()
```
should return winner symbol (X or O) or null if there is no winner yet
```
noMoreAtempts()
```
should return true if there is no more fields to place a X or O


![Screenshot 2021-07-29 165803](https://user-images.githubusercontent.com/64478989/127505222-4b487c11-666e-412c-8423-dd24a1fc931d.jpg)

