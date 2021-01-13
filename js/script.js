let WIDTH = $(window).width();
let HEIGHT = $(window).height();
let WIDTH_GAME = 0;
let GAME = true;

// Variable général ------------------------------------------------ //
var myBody = document.getElementById("body");
var mario;
var balls = [];
var on_press_right = false;
var on_press_left = false;
var inertia = 0; // inertie
var const_move_right = 20;
var const_move_left = -20;
var godmod = false;

// define color background
document.body.style.backgroundColor = "rgb(156, 195, 238)";
$(document.getElementById("godmod").parentElement).hide();


// Init ------------------------------------------------------------ //
setGround();
setCloud();
setMario();

// GAME -------------------------------------------------------------//
setInterval(function(){ // refrsh de 30 images/secondes
    if(GAME){
        moveBalls();
        moveMario();
        collisionMario();
        godmodMario();
    }
}, 30);

setInterval(function (){ // summon balls
    if(GAME) createBalls();
}, 15);

setInterval(function (){
    if (godmod){
        if (getGodmodCooldown() > 0)
            setGodmodCooldown(-1);
        else
            godmod = false;
    }
}, 1000);

// Utils ----------------------------------------------------------- //

function getRandom(min, max) {
    return Math.round(Math.random() * (max - min) + min);
}

function getImage(imageName){
    let image = document.createElement("img");
    if (imageName == 'billball'){ // billball
        image.src = "img/billball.png";
        $(image).css("height", 128);
        $(image).css("width", 92);
    }else if (imageName == 'mushroomred'){ // mushroom red
        image.src = "img/mushroom_red.png";
        $(image).css("height", 100);
        $(image).css("width", 100);
    }else if (imageName == 'goomba'){ // goomba
        image.src = "img/goomba.png";
        $(image).css("height", 92);
        $(image).css("width", 72);
    }else if (imageName == 'star'){ // mushroom green
        image.src = "img/star.png";
        $(image).css("height", 100);
        $(image).css("width", 100);
    }else if (imageName == 'block'){ // grounds blocks
        image.src = "img/block.png";
        $(image).css("height", 100);
        $(image).css("width", 100);
    }else if (imageName == 'cloud'){
        image.src = "img/cloud.png";
    }else if (imageName == 'mario_right'){
        $(image).attr("src","img/mario_right.png");
        $(image).css("height", 128);
        $(image).css("width", 96);
    }else if (imageName == 'mario_left'){
        $(image).attr("src","img/mario_left.png");
    }
    image.style.position = "absolute";
    myBody.appendChild(image);
    return image;
}

function setGround(){

    WIDTH_GAME = Math.round(WIDTH / 100);

    let nbLine = 2;
    let groundBoard = [];
    for (let y = HEIGHT - 100, ymax = HEIGHT - 100*(nbLine+1); y > ymax; y-=100){
        for (let i = WIDTH_GAME, imax = WIDTH; i < imax; i+=100){
            if (i+100 <= WIDTH){
                groundBoard[i] = getImage("block");
                $(groundBoard[i]).offset({top: y, left: i});
            }
        }
    }
}

function setCloud(){
    let cloudBoard = [];

    cloudBoard[0] = getImage("cloud");
    $(cloudBoard[0]).offset({top: HEIGHT/8, left: WIDTH/8+WIDTH_GAME});

    if (WIDTH > 1200){
        cloudBoard[1] = getImage("cloud");
        $(cloudBoard[1]).offset({top: HEIGHT/3, left: WIDTH/8*6+WIDTH_GAME});
    }

    if (HEIGHT > 1200){
        cloudBoard[2] = getImage("cloud");
        $(cloudBoard[2]).offset({top: HEIGHT/8*4, left: WIDTH/8*3+WIDTH_GAME});
    }
}

function setMario(){
    mario = getImage("mario_right");
    $(mario).offset({top: HEIGHT-200-128, left: WIDTH/8+WIDTH_GAME});
}

// Events ---------------------------------------------------------- //

// event touche enfoncée
document.onkeydown = function(wesh){
    if (GAME){
        switch(wesh.keyCode){
            case 39: // touche fleche droite
                if(on_press_right == false){
                    $(mario).attr("src","img/mario_right.png");
                    on_press_right = true;
                    // move_right = 0;
                }
                break;
            case 37: // touche fleche gauche
                if(on_press_left == false){
                    $(mario).attr("src","img/mario_left.png");
                    on_press_left = true;
                    // move_left = 0;
                }
                break;
        }
    }
}

document.onkeyup = function(wesh){
    if (GAME){
        switch(wesh.keyCode){
            case 39: // touche fleche droite
                on_press_right = false;
                break;
            case 37: // touche fleche gauche
                on_press_left = false;
                break;
        }
    }
}


// Mario ----------------------------------------------------------- //

function moveMario(){
    if(mario.offsetLeft < WIDTH - WIDTH_GAME - mario.offsetWidth && mario.offsetLeft > WIDTH_GAME){
        $(mario).offset({top:mario.offsetTop, left:mario.offsetLeft + inertia});
        if (on_press_right && inertia < const_move_right)
            inertia++;
        if (on_press_left && inertia > const_move_left)
            inertia--;
        if (!on_press_right && !on_press_left)
            if (inertia > 0)
                inertia--;
            else if (inertia < 0)
                inertia++;
    }
}

function collisionMario(){
    let delta_x, delta_y;
    for (let i = 0, imax = balls.length; i < imax; i++){
        if (balls[i].offsetLeft >= mario.offsetLeft)
            delta_x = balls[i].offsetLeft - mario.offsetLeft;
        else
            delta_x = mario.offsetLeft - balls[i].offsetLeft;

        if (balls[i].offsetTop >= mario.offsetTop)
            delta_y = balls[i].offsetTop - mario.offsetTop;
        else
            delta_y = mario.offsetTop - balls[i].offsetTop;

        if (delta_x <= mario.offsetWidth/2 + balls[i].offsetWidth/2 && delta_y <= mario.offsetHeight/3 + balls[i].offsetHeight/3){
            console.log("Touché");
            ballType = getBallType(balls[i]);
            if (!godmod){
                if (ballType == "billball"){ // tuer
                    setGameOver("Une fusée vous a touché !");
                }else if (ballType == "goomba"){ // retirer 1 point
                    setPoints(-1);
                    decreaseMario();
                    if (getPoint() < 0)
                        setGameOver("Vous n'avez plus de point !");
                }else if (ballType == "star"){ // bouclier
                    godmod = true;
                }
            }
            if (ballType == "mushroomred"){ // grandir
                setPoints(+1);
                growMario();
            }
            deleteBall(i);

        }
    }
}

function growMario(){
    $(mario).width(mario.width + 50);
    $(mario).height(mario.height + 50);
    $(mario).offset({top:mario.offsetTop - 50, left:mario.offsetLeft});
}

function decreaseMario(){
    $(mario).width(mario.width - 50);
    $(mario).height(mario.height - 50);
    $(mario).offset({top:mario.offsetTop + 50, left:mario.offsetLeft});
}

function godmodMario(){
    if (godmod) {
        if (document.body.style.backgroundColor != "rgb(254, 180, 41)") {
            document.body.style.backgroundColor = "rgb(254, 180, 41)";
            setGodmodCooldown(10);
            $(document.getElementById("godmod").parentElement).show();
        }
    }
    else{
        if (document.body.style.backgroundColor != "rgb(156, 195, 238)"){
            $(document.getElementById("godmod").parentElement).hide();
            document.body.style.backgroundColor = "rgb(156, 195, 238)";
        }
    }
}

function setGameOver(message){
    GAME = false;
    alert("-=-=-= GAME OVER =-=-=-\n" + message);
}

// Balls ----------------------------------------------------------- //

function createBalls(){
    let random_x = getRandom(0, WIDTH-WIDTH_GAME-100);
    if (random_x % 50 == 0 && balls.length < 30){
        let random_type = getRandom(0, 4);
        let ball;
        if (random_type == 0){
            ball = getImage("mushroomred");
            $(ball).offset({top: 0, left: random_x});
            balls.push(ball);
        }else if(random_type == 1){
            ball = getImage("goomba");
            $(ball).offset({top: 0, left: random_x});
            balls.push(ball);
        }else if (random_type == 2){
            ball = getImage("billball");
            $(ball).offset({top: 0, left: random_x});
            balls.push(ball);
        }else if (random_type == 3){
            ball = getImage("star");
            $(ball).offset({top: 0, left: random_x});
            balls.push(ball);
        }
    }
}

function moveBalls(){
    for (let i = 0, imax = balls.length; i < imax; i++){
        $(balls[i]).offset({top:balls[i].offsetTop + 10, left:balls[i].offsetLeft});
        if (balls[i].offsetTop >= HEIGHT-200-100){
            deleteBall(i);
        }
    }
}

function deleteBall(index){
    ball = balls[index];
    balls.splice(index, 1);
    ball.remove();
}

function getBallType(ball){
    route = $(ball).attr('src');
    if (route == 'img/billball.png'){ // billball
        return "billball";
    }else if (route == 'img/mushroom_red.png'){ // mushroom red
        return "mushroomred";
    }else if (route == 'img/goomba.png'){ // goomba
        return "goomba";
    }else if (route == 'img/star.png'){ // mushroom green
        return "star";
    }else if (route == 'img/block.png'){ // grounds blocks
        return "block";
    }else if (route == 'img/cloud.png'){
        return "cloud";
    }else if (route == 'img/mario_right.png' || route == 'img/mario_left.png') {
        return "mario";
    }else{
        return "";
    }
}

// Points ---------------------------------------------------------- //

function setPoints(number){
    document.getElementById("points").innerText = getPoint() + number;
}

function getPoint(){
    return parseInt(document.getElementById("points").innerText);
}

// Godmod ---------------------------------------------------------- //

function setGodmodCooldown(number){
    document.getElementById("godmod").innerText = getGodmodCooldown() + number;
}

function getGodmodCooldown(){
    return parseInt(document.getElementById("godmod").innerText);
}


// function detectWin(){
//     if(mario.offsetLeft >= flag.offsetLeft + flag.offsetWidth / 2){
//         stop = true;
//         alert("Bravo tu as gagné !");
//     }
// }
//
// function detectLose(){
//     var delta_x, delta_y;
//     if(mario.offsetLeft >= goomba.offsetLeft){
//         delta_x = mario.offsetLeft - goomba.offsetLeft;
//     }else{
//         delta_x = goomba.offsetLeft - mario.offsetLeft;
//     }
//     if(mario.offsetTop >= goomba.offsetTop){
//         delta_y = mario.offsetTop - goomba.offsetTop;
//     }else{
//         delta_y = goomba.offsetTop - mario.offsetTop;
//     }
//
//     if(delta_x <= mario.offsetWidth/2 + goomba.offsetWidth/2 && delta_y <= mario.offsetHeight/2 + goomba.offsetHeight/2){
//         stop = true;
//         alert("Tu as perdu !");
//     }
//
// }
//
// var right = false;
// function setMoveGoomba(){
//     if(right == true){
//         $(goomba).offset({top:goomba.offsetTop, left:goomba.offsetLeft + 10});
//         if(goomba.offsetLeft >= max){
//             right = false;
//         }
//     }else{
//         if(goomba.offsetLeft <= min){
//             right = true;
//         }
//         $(goomba).offset({top:goomba.offsetTop, left:goomba.offsetLeft - 10});
//     }
// }
//
// var jump = -1;
// var const_jump = 20;
// var on_press_jump = false;
// function setJump(){
//     if(jump != -1){
//         jump += 1;
//         if(jump <= const_jump){
//             $(mario).offset({top:mario.offsetTop - (const_jump - jump), left:mario.offsetLeft});
//         }else if(jump > const_jump && jump < const_jump*2){
//             $(mario).offset({top:mario.offsetTop + (jump - const_jump), left:mario.offsetLeft});
//         }else{
//             jump = -1;
//         }
//     }
// }
