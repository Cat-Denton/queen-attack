# _Title_

#### _Short Description_

#### By _**Cat Denton**_

## Technologies Used

* C#
* .NET V5

## Description

_long description_

## Setup/Installation Requirements

* Clone repository to local drive
* Open code with a text editor
* Install NPM
* Type npm run start

## Specs

| describe | input | output |
|----------|------:|--------|
| Queen constructor returns an instance of Queen | new Queen() | typeof === "Queen" |
| Queen constructor accepts X and Y coordinate to be stored as Queen instance position | int xPos = 4; int yPos = 5; new Queen(xPos, yPos) | no build errors |
| Queen instance can return its current X and Y coordinates | thisQueen.getCoordinates() | 4, 5  |
| Knight constructor returns an instance of Knight | new Knight() | typeof === "Knight" |
| Knight constructor accepts an X and Y coordinate for new Knight instance | int xPos = 5; int yPos = 6; new Knight(xPos, yPos) | no build errors |
| Knight instance can return its current X and Y coordinates | thisKnight.GetCoordinates() | 5, 6 |
| thisQueen.canAttack() accepts an instance of Knight as an argument | thisQueen.canAttack(thisKnight); | no build errors |
| canAttack() returns true if Knight instanced passed as argument can be attacked from present Queen position | given Queen position ( 4, 5 ); Knight position ( 5, 6 ); thisQueen.canAttack(); | expect true  |
| canAttack() returns false if Knight passed as argument *cannot* be attacked from present position of Queen instance | given Queen position ( 4, 3 ); Knight position ( 5, 6 ) | expect false |


## Known Bugs

* none

## License

Copyright <YEAR> Cat Denton

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.



## Contact Information

_Cat Denton <willwdenton@gmail.com>_