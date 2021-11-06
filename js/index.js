var textTitle = document.getElementById("title");
var textDescription = document.getElementById("description");
var buttonLeft = document.getElementById("buttonLeft");
var buttonRight = document.getElementById("buttonRight");
var divInput = document.getElementById("inputDiv");

var steps = ['HOME', 'ASK', 'TELL'];
var step = steps[0];


buttonLeft.onclick = function(){
    if (step == steps[0]){
        step = steps[1];
        console.log(steps[0] +" -> " + steps[1]);
    }else if(step == steps[1]){
        step = steps[0];
        console.log(steps[1] +" -> " + steps[0]);
    }else if(step == steps[2]){
        step = steps[0];
        console.log(steps[2] +" -> " + steps[0]);
    }
    update();
};

buttonRight.onclick = function(){
    if (step == steps[0]){
        step = steps[2];
        console.log(steps[0] +" -> " + steps[2]);
    }else if(step == steps[1]){
        console.log("another joke");
    }else if(step == steps[2]){
        step = steps[0];

        joke = document.getElementById('joke').value;
        name = document.getElementById('name').value;

        console.log("upload joke");
        console.log(steps[2] +" -> " + steps[0]);
    }
    update();
};


function update(){
    if (step == steps[0]){
        textTitle.innerText = "BottleFlip";
        textDescription.innerText = "Bot humour. Je racompte vos blagues sur demande !";
        buttonLeft.innerText = "Racompte moi une blague";
        buttonRight.innerText = "J'ai une blague pour toi";
        divInput.innerHTML = '';
    }else if(step == steps[1]){
        textTitle.innerText = "Qu'est-ce qui est jaune et qui attend ?";
        textDescription.innerText = "> Johnathan";
        buttonLeft.innerText = "Retour";
        buttonRight.innerText = "Suivante !";
        divInput.innerHTML = '';
    }else if(step == steps[2]){
        textTitle.innerText = "BottleFlip";
        textDescription.innerText = "Ecrit moi ta blague !";
        buttonLeft.innerText = "Retour";
        buttonRight.innerText = "Envoyer";

        inputText = '<br>\n' +
            '        <textarea id="joke" class="input-group form-control" aria-label="Blague" placeholder="Blague"></textarea>\n' +
            '        <br>\n' +
            '        <input id="name" type="text" class="input-group mb-3 form-control" placeholder="Nom">';

        divInput.innerHTML += inputText;
    }
}

update();
