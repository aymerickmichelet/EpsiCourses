var channel = document.getElementById("channel");

function jsonParsed(json){
    let json_parsed = [];
    json.forEach(element => {
        json_parsed.unshift(element);
    });
    return json_parsed;
}

function displayMessages(messages){
    messages.forEach(message => {
        const messageDiv = `
            <div class='message_container'>
                <div class='message_title'>
                    <img src='https://cdn.discordapp.com/avatars/`+message.author.id+`/`+message.author.avatar+`.webp?size=160' class='profile_image'>
                    <h2 class='message_title_element'>
                        `+message.author.username+`#`+message.author.discriminator+`
                        —
                        `+message.timestamp+`
                    </h2>
                </div>
                <div class="message_text">
                    `+message.content+`
                </div>
            </div>`;
        channel.innerHTML += messageDiv;
    });
}

const json = []; //past here your json discussion

displayMessages(jsonParsed(json));