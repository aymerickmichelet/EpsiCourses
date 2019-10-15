var stop = false;
var min = 0;
var max = 1400;

var flag = document.getElementById("flag");
var mario = document.getElementById("mario");
var goomba = document.getElementById("goomba");
$(flag).offset({top:160, left:1200}); //set la position du drapo
$(mario).offset({top:570, left:50}); //set la position du drapo
$(goomba).offset({top:593, left:1000}); //set la position du drapo

setInterval(function(){ // refrsh de 30 images/secondes
    if(stop == false){
        setMoveGoomba();
        setJump();
        setMoveRight();
        setMoveLeft();
        detectLose();
        detectWin();
    }
}, 30);



// event touche enfoncée
document.onkeydown = function(wesh){
    switch(wesh.keyCode){
        case 32: case 38: // touche espace et/ou fleche haut
            // lancement fonction saut
            console.log("espace / fleche haut");
            if(mario.offsetTop == 570){
                jump = 0;
            }
            break;
        case 39: // touche fleche droite
            console.log("fleche droite");
            if(on_press_right == false){
                on_press_right = true;
                move_right = 0;
            }
            break;
        case 37: // touche fleche gauche
            console.log("fleche gauche");
            if(on_press_left == false){
                on_press_left = true;
                move_left = 0;
            }
            break;
    }
}


document.onkeyup = function(wesh){
    switch(wesh.keyCode){
        case 39: // touche fleche droite
            on_press_right = false;
            break;
        case 37: // touche fleche gauche
            on_press_left = false;
            break;
    }
}
    
    
function detectWin(){
    if(mario.offsetLeft >= flag.offsetLeft + flag.offsetWidth / 2){
        stop = true;
        alert("Bravo tu as gagné !");
    }
}

function detectLose(){
    var delta_x, delta_y;
    if(mario.offsetLeft >= goomba.offsetLeft){
        delta_x = mario.offsetLeft - goomba.offsetLeft;
    }else{
        delta_x = goomba.offsetLeft - mario.offsetLeft;
    }
    if(mario.offsetTop >= goomba.offsetTop){
        delta_y = mario.offsetTop - goomba.offsetTop;
    }else{
        delta_y = goomba.offsetTop - mario.offsetTop;
    }

    if(delta_x <= mario.offsetWidth/2 + goomba.offsetWidth/2 && delta_y <= mario.offsetHeight/2 + goomba.offsetHeight/2){
        stop = true;
        alert("Tu as perdu !");
    }

}

var right = false;
function setMoveGoomba(){
    if(right == true){
        $(goomba).offset({top:goomba.offsetTop, left:goomba.offsetLeft + 10});
        if(goomba.offsetLeft >= max){
            right = false;
        }
    }else{
        if(goomba.offsetLeft <= min){
            right = true;
        }
        $(goomba).offset({top:goomba.offsetTop, left:goomba.offsetLeft - 10});
    }
}
    
var jump = -1;
var const_jump = 20;
var on_press_jump = false;
function setJump(){
    if(jump != -1){
        jump += 1;
        if(jump <= const_jump){
            $(mario).offset({top:mario.offsetTop - (const_jump - jump), left:mario.offsetLeft});
        }else if(jump > const_jump && jump < const_jump*2){
            $(mario).offset({top:mario.offsetTop + (jump - const_jump), left:mario.offsetLeft});
        }else{
            jump = -1;
        }
    }
}

var move_left = -1;
var const_move_left = 10;
var on_press_left = false;
function setMoveLeft(){
    if(move_left != -1 && mario.offsetLeft > min){
        $(mario).offset({top:mario.offsetTop, left:mario.offsetLeft - move_left});
        if(on_press_left == true){
            move_left += 1;
            if(move_left = const_move_left){
                move_left -+ 1;
            }
        }else{
            move_left -= 1;
            if(move_left == 0){
                move_left = -1;
            }
        }
    }
}


var move_right = -1;
var const_move_right = 10;
var on_press_right = false;
function setMoveRight(){
    if(move_right != -1 && mario.offsetLeft < max){
        $(mario).offset({top:mario.offsetTop, left:mario.offsetLeft + move_right});
        if(on_press_right == true){
            move_right += 1;
            if(move_right = const_move_right){
                move_right -+ 1;
            }
        }else{
            move_right -= 1;
            if(move_right == 0){
                move_right = -1;
            }
        }
    }
}