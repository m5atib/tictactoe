**Tic Tac Toe Game on WFA**

using : 
 * C#
 * WFA
 * Guna UI
 * Bunifu UI

Now we need to make this real game with backend programming !

```
getCurrentPlayerSymbol()
```
should return x or o

```
nextTurn(row, col)
```
should properly update class state (change current player, update marks storage etc.)

```
isFinished()
```
should return true if game is finished (e.g. there is a winner or it is a draw)
```
getWinner()
```
should return winner symbol (x or o) or null if there is no winner yet
```
noMoreTurns()
```
should return true if there is no more fields to place a x or o
```
isDraw()
```
should return true if there is no more turns and no winner
```
getFieldValue(row, col)
```
should return matrix[row][col] value (if any) or null


![Screenshot 2021-07-29 165803](https://user-images.githubusercontent.com/64478989/127505222-4b487c11-666e-412c-8423-dd24a1fc931d.jpg)

