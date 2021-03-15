var textTitle = document.getElementById("title");
var textDescription = document.getElementById("description");
var buttonLeft = document.getElementById("buttonLeft");
var buttonRight = document.getElementById("buttonRight");

var steps = ['HOME', 'ASK', 'AAA'];
var step = steps[0];

var headerMain = '<header class="masthead d-flex">\n' +
    '    <div class="container text-center my-auto">\n' +
    '      <h1 class="mb-1">BottleFlip</h1>\n' +
    '      <h3 class="mb-5">\n' +
    '        <em>Bot humour. Fait des blagues sur demande !</em>\n' +
    '      </h3>\n' +
    '      <a id="buttonAfkJoke" class="btn btn-primary btn-xl js-scroll-trigger" href="">Racompte moi une blague</a>\n' +
    '      <a class="btn btn-primary btn-xl js-scroll-trigger" href="">Propose moi des blagues</a>\n' +
    '    </div>\n' +
    '    <div class="overlay"></div>\n' +
    '  </header>';


buttonLeft.onclick = function(){
    if (step == steps[0]){
        step = steps[1];
        console.log("HOME -> ASK");
    }else if(step == steps[1]){
        step = steps[0];
        console.log("ASK -> HOME");
    }else if(step == steps[2]){
        step = steps[0];
        console.log("AAA -> HOME");
    }
    update();
};

buttonRight.onclick = function(){
    if (step == steps[0]){
        step = steps[2];
        console.log("HOME -> AAA");
    }else if(step == steps[1]){
        console.log("another joke");
    }else if(step == steps[2]){
        step = steps[0];
        console.log("upload joke");
        console.log("AAA -> HOME");
    }
    update();
};


function update(){
    if (step == steps[0]){
        textTitle.innerText = "BottleFlip";
        textDescription.innerText = "Bot humour. Je ne sais plus la suite mais voilà";
        buttonLeft.innerText = "Racompte moi une blague";
        buttonRight.innerText = "Donne en une autre";
    }else if(step == steps[1]){
        textTitle.innerText = "Qu'est-ce qui est jaune et qui attend ?";
        textDescription.innerText = "> Johnathan";
        buttonLeft.innerText = "Retour";
        buttonRight.innerText = "Suivante !";
    }else if(step == steps[2]){
        textTitle.innerText = "Ecrit nous ta blague !";
        textDescription.innerText = "Merci gro";
        buttonLeft.innerText = "Retour";
        buttonRight.innerText = "Envoyer";
    }
}

update();
