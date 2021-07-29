**Tic Tac Toe Game on WFA**

using : 
 * C#
 * WFA
 * Guna UI
 * Bunifu UI

Now we need to make this real game with backend programming !
You have a 3 * 3 matrix. When you press any of the buttons 
in the game box, you must perform a set of the operations mentioned below, such as : 

```
getPlayerSymbol()
```
should return x or o

```
onPlayerClicked(row, col)
```
should properly update class state (change current player, update marks storage etc.)

```
getStatusOfGame()
```
should return winner symbol (x or o) or null if there is no winner yet
```
noMoreAtempts()
```
should return true if there is no more fields to place a x or o
```
setFieldValue(row, col)
```
should set matrix[row][col] value (if X || O) or null


![Screenshot 2021-07-29 165803](https://user-images.githubusercontent.com/64478989/127505222-4b487c11-666e-412c-8423-dd24a1fc931d.jpg)

