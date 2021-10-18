var textTitle = document.getElementById("title");
var textDescription = document.getElementById("description");
var buttonLeft = document.getElementById("buttonLeft");
var buttonRight = document.getElementById("buttonRight");
var divInput = document.getElementById("inputDiv");

var steps = ['HOME', 'ASK', 'TELL'];
var step = steps[0];

const urlApiGet = "http://127.0.0.1:8000/pun";
const urlApiPost = "http://127.0.0.1:8000/pun";

// HOME Page
const title = "Alain Fini";
const home_subtitle = "Je partage des Nom/Prénom rigolo !"
const buttonTell = "Racompte moi un jeu de mot";
const buttonAsk = "Jean ney un pour toi";

// TELL Page
const buttonBack = "Retour";
const buttonNext = "Suivant";

// ASK Page
const tell_subtitle = "Ecrit moi ton jeu de mot !";
const firstname = "Prénom: Jean";
const lastname = "Nom: Neymar";
const author = "Auteur: (optionnel) MOI";
const solution = "Solution: (optionnel) J'en ai marre !";
const send = "Envoyer";

// =-=-=-=-=-=-=-=-=-=-=-=

const inputText = `<br>
        <div class="row">
            <div class="col">
                <input id="firstname" class="input-group form-control" placeholder="` + firstname + `"></input>
                </div>
                <div class="col">
                <input id="lastname" class="input-group form-control" placeholder="` + lastname + `"></input>
                </div>
                <div class="col">
                <input id="author" class="input-group form-control" placeholder="` + author + `"></input>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="col">
                <input id="solution" class="input-group form-control" placeholder="` + solution + `"></input>
                </div>
            </div>
            <br>
            <div class="row">
                <div class="col">
                <p>Votre jeu de mot sera ajouté lorsqu'il aura été validé par la modération.</p>
                </div>
            </div>
        </div>`

buttonLeft.onclick = function(){
    if (step == steps[0]){
        step = steps[1];
    }else if(step == steps[1]){
        step = steps[0];
    }else if(step == steps[2]){
        step = steps[0];
    }
    update();
};

buttonRight.onclick = function(){
    if (step == steps[0]){ // HOME -> TELL
        step = steps[2];
        update();
    }else if(step == steps[1]){ // ASK -> ASK
        update();
    }else if(step == steps[2]){ // TELL -> HOME/TELL
        let firstname = document.getElementById('firstname').value;
        let lastname = document.getElementById('lastname').value;
        let author = document.getElementById('author').value;

        if (firstname.length > 0 && lastname.length > 0){
            postPun(firstname, lastname, author);
            setContentPage(title, "Enregistrement en cour...", "", buttonBack, buttonNext);
        }else{
            alert("Veuillez finir de remplir le formulaire avant de vouloir nous le faire parvenir !");
        }
    }
};


function update(){
    if (step == steps[0]){
        setContentPage(title, home_subtitle, "", buttonTell, buttonAsk);
    }else if(step == steps[1]){
        getPun();
        setContentPage("...", "Chargement du jeu de mot...", "", buttonBack, buttonNext);
    }else if(step == steps[2]){
        setContentPage(title, "Ecrit moi ton jeu de mot !", inputText, buttonBack, buttonNext);
    }
}


// =-=-=-=-=-=-=-=

const sendHttpRequest = (method, url, data) => {
  const promise = new Promise((resolve, reject) => {
    const xhr = new XMLHttpRequest();
    xhr.open(method, url);

    xhr.responseType = 'json';

    if (data) {
      xhr.setRequestHeader('Content-Type', 'application/json');
    }

    xhr.onload = () => {
      if (xhr.status >= 400) {
        reject(xhr.response);
      } else {
        resolve(xhr.response);
      }
    };

    xhr.onerror = () => {
      reject('Something went wrong!');
    };

    xhr.send(JSON.stringify(data));
  });
  return promise;
};

const getPun = () => {
  sendHttpRequest('GET', urlApiGet).then(responseData => {
    if (responseData.author == null)
        setContentPage(responseData.firstname + " " + responseData.lastname, "", "", buttonBack, buttonNext);
    else
        setContentPage(responseData.firstname + " " + responseData.lastname, "> " + responseData.author, "", buttonBack, buttonNext);
  });
};

const postPun = (firstname, lastname, author = null) => {
  sendHttpRequest('POST', urlApiPost, {
    firstname: firstname,
    lastname: lastname,
    author: author
  })
    .then(responseData => {
        step = step[0];
        update();
        alert("Votre jeu de mot '" + firstname + " " + lastname + "' a bien été pris en compte !");
    })
    .catch(err => {
      console.log(err);
    });
};

function setContentPage(contentTitle, contentDescription, contentBody, contentBack, contentNext){
    textTitle.innerText = contentTitle;
    textDescription.innerText = contentDescription;
    divInput.innerHTML = contentBody;
    buttonLeft.innerText = contentBack;
    buttonRight.innerText = contentNext;
}

update();
