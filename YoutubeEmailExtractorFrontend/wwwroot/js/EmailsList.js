//code for support enter click on input
let input = document.querySelector("#videoId");

    input.addEventListener("keyup", function (event) {
    if (event.keyCode === 13) {
        event.preventDefault();
        document.getElementById("submit").click();
    }
    });

    function CopyToClipboard(element){
        let input = document.querySelector("#test");
        input.setAttribute("type", "text");
        input.value = element.innerText;
        input.select();  
        document.execCommand('copy');
        input.setAttribute("type", "hidden");
    }
    function searchEmails(){
        let id = document.getElementById("videoId").value;
        console.log("in add emails, text: " + id);
        if (isEmptyOrSpaces(id)) {
            return;
        }
        document.querySelectorAll(".email").forEach((e) => e.remove());
        let url = "https://localhost:44395/api/StartExtractEmails?videoId=" + id;
            fetch(url)
            .then((responce)=>{
                if(!responce.ok){
                    console.log("something went wrong");
                }
            }).catch(e=>console.log("something went wrong"));
            setTimeout(function() { AddNewEmails(); }, 5000);
            console.log("searching...");
    }

    let WaitinNewEmails = false;
    $(document).scroll(function(e){
        e.preventDefault();
        if(1500> ($(document).height()-$(window).scrollTop())&&!WaitinNewEmails){
            console.log("scroll event");
            console.log(WaitinNewEmails);
            AddNewEmails();
        }
    });
    let emailsCount = 0;
    function AddNewEmails(){
        WaitinNewEmails = true;

    let url = "https://localhost:44395/api/GetNewListOfEmails?startindex=" + emailsCount;
    fetch(url)
      .then((responce) => responce.json())
      .then((result) =>
        result.emails.forEach((obj) => {
            emailsCount++;
            console.log(emailsCount);

            let emailDiv = document.createElement("div");
            emailDiv.classList.add("email");

            let emailSpan = document.createElement("span");
            emailSpan.innerHTML = obj+
            '<i class="fa fa-copy" onclick="CopyToClipboard(this.parentElement)"></i>'
            emailDiv.appendChild(emailSpan);

            document.querySelector(".container").appendChild(emailDiv);
        }));
    WaitinNewEmails = false;
}

function isEmptyOrSpaces(str){
    return str === null || str.match(/^ *$/) !== null;
}