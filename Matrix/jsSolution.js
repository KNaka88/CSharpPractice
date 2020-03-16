// --- Directions
// Write a function that accepts an integer N
// and returns a NxN spiral matrix.
// --- Examples
//   matrix(2)
//     [[1, 2],
//     [4, 3]]
//   matrix(3)
//     [[1, 2, 3],
//     [8, 9, 4],
//     [7, 6, 5]]
//  matrix(4)
//     [[1,   2,  3, 4],
//     [12, 13, 14, 5],
//     [11, 16, 15, 6],
//     [10,  9,  8, 7]]

//  matrix(5)
//     [ 1,  2,  3,  4, 5]
//     [16, 17, 18, 19, 6]
//     [15, 24, 25, 20, 7]
//     [14, 23, 22, 21, 8]
//     [13, 12, 11, 10, 9]

function matrix(n) {
    const obj = createMatrixBase(n)
    const curr = {
        x: 0,
        y: 0,
        num: 0,
        dir: 'east'
    };

    moveNext(obj, curr, n * n);
    console.log(obj);
    return obj;
}

function moveNext(obj, curr, max) {
    if (curr.dir === 'east') {
        if (nextPositionExists(obj, curr, 0, 1)) {
            curr.num++;
            obj[curr.y][curr.x] = curr.num;        
            curr.x += 1;                
        } else if (nextPositionExists(obj, curr, 1, 0)) {
            curr.dir = 'south';
        } else {
            curr.num++;
            obj[curr.y][curr.x] = curr.num;        
            return;
        }
    }

    if (curr.dir === 'south') {
        if (nextPositionExists(obj, curr, 1, 0)) {
            curr.num++;
            obj[curr.y][curr.x] = curr.num;        
            curr.y += 1;            
        } else if (nextPositionExists(obj, curr, 0, -1)) {
            curr.dir = 'west';
        } else {
            curr.num++;
            obj[curr.y][curr.x] = curr.num;    
            return;    
        }
    }

    if (curr.dir === 'west') {
        if (nextPositionExists(obj, curr, 0, -1)) {
            curr.num++;
            obj[curr.y][curr.x] = curr.num;        
            curr.x -= 1;            
        } else if (nextPositionExists(obj, curr, -1, 0)) {
            curr.dir = 'north';
        } else {
            curr.num++;
            obj[curr.y][curr.x] = curr.num;
            return;
        }
    }

    if (curr.dir === 'north') {
        if (nextPositionExists(obj, curr, -1, 0)) {
            curr.num++;
            obj[curr.y][curr.x] = curr.num;        
            curr.y -= 1;            
        } else if (nextPositionExists(obj, curr, 0, 1)) {
            curr.dir = 'east';
        } else {
            curr.num++;
            obj[curr.y][curr.x] = curr.num;        
            return;
        }
    }
    moveNext(obj, curr, max);
}

function nextPositionExists(obj, curr, nextYPos, nextXPos) {
    if (obj[curr.y + nextYPos] && 
        obj[curr.y + nextYPos][curr.x + nextXPos] !== 'undefined' && 
        obj[curr.y + nextYPos][curr.x + nextXPos] === '') {
            return true;
    } else {
        false;
    }
}

function createMatrixBase(n) {
    let obj = [];
    for (let x = 0; x < n; x++) {
        obj.push([]);
        for (let y = 0; y < n; y++) {
            obj[x][y] = '';
        }    
    }
    return obj;
}

module.exports = matrix;
