var cvs = document.getElementById("canvas");
var ctx = cvs.getContext("2d");

// load images
var bird = new Image();
var bg = new Image();
var fg = new Image();
var pipeNorth = new Image();
var pipeSouth = new Image();
bird.src = "images/bird.png";
bg.src = "images/bg.png";
fg.src = "images/fg.png";
pipeNorth.src = "images/pipeNorth.png";
pipeSouth.src = "images/pipeSouth.png";

// audio files
var fly = new Audio();
var scor = new Audio();
fly.src = "sounds/fly.mp3";
scor.src = "sounds/score.mp3";

// some vars
var gap = 85;
var constant; // = pipeNorth.height + gap;
var bX = 10; // bird x pos
var bY = 150; // bird y pos
var gravity = 1.5;
var score = 0;

// Movement (will handle diagonals too)
window.addEventListener("keydown", keysPressed, false);
window.addEventListener("keyup", keysReleased, false);
var keys = [];

function keysPressed(e) {
	// store an entry for every key pressed
	keys[e.keyCode] = true;    
    
    // Cardinal direction movement
    if (keys[37]) { // left
        bX -= 5;        
    }
    if (keys[38]) { // up
        bY -= 5;
        
    }
    if (keys[39]) { // right
        bX += 5;
    }
    if (keys[40]) { // down
        bY += 5;
    }	
}

function keysReleased(e) {
	// mark keys that were released
	keys[e.keyCode] = false;
}


// original move function
// function move() {
//     bY -= 25;
//     fly.play();
// }


// pipe coordinates
var pipe = [];

pipe[0] = {
    x : cvs.width,
    y : 0
}

// draw images

function draw() {
    
    // draws background image
    ctx.drawImage(bg, 0, 0);
    
    for (var i = 0; i < pipe.length; i++) {

        constant = pipeNorth.height + gap;
        
        ctx.drawImage(pipeNorth, pipe[i].x, pipe[i].y);
        ctx.drawImage(pipeSouth,pipe[i].x,pipe[i].y+constant);

        pipe[i].x--;

        if (pipe[i].x == 125) {
            pipe.push({
                x : cvs.width,
                y : Math.floor(Math.random() * pipeNorth.height) - pipeNorth.height
            });
        }

        // detect collision
        if (bX + bird.width / 2 >= pipe[i].x && bX <= pipe[i].x + pipeNorth.width && 
            (bY <= pipe[i].y + pipeNorth.height || bY + bird.height / 2 >= pipe[i].y + constant) || 
            bY + bird.height / 2 >= cvs.height - fg.height) {
                location.reload();  
        }

        if (pipe[i].x == 5) {
            score++;
            scor.play();
        }
    }

    

    ctx.drawImage(fg,0,cvs.height - fg.height);

    ctx.drawImage(bird,bX,bY);

    //bY += gravity;

    ctx.fillStyle = "#000";
    ctx.font = "20px Verdana";
    ctx.fillText("Score : " + score, 10, cvs.height-20);

    requestAnimationFrame(draw);
}

draw();