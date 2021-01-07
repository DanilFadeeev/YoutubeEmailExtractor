function searchChannels() {
    let text = document.getElementById("channelId").value;
    text.replace(" ", "+");
    console.log("in searchchannels, text: " + text);
    if (isEmptyOrSpaces(text)) return;

    document.querySelectorAll(".channelInfo").forEach((e) => e.remove());
    let url = "https://localhost:44395/api/getchannels?channelName=" + text;
    fetch(url)
        .then((responce) => responce.json())
        .then((result) =>
            result.forEach((obj) => {
                let channelInfoDiv = document.createElement("div");
                channelInfoDiv.classList.add("channelInfo");
                let lineDiv = document.createElement("div");
                lineDiv.classList.add("line");
                let imgLineDiv = document.createElement("img");
                imgLineDiv.setAttribute("src", obj.imageAddress);
                lineDiv.appendChild(imgLineDiv);
                channelInfoDiv.appendChild(lineDiv);
                let channelTextDiv = document.createElement("div");
                channelTextDiv.classList.add("channelText");
                channelTextDiv.innerHTML =
                    '<span class="first">channel Id:&nbsp;</span><span>' +
                    obj.id +
                    ' <i class="fa fa-copy" onclick="CopyToClipboard(this.parentElement)"></i> </span><br /> <span>channel name: ' +
                    obj.title +
                    "</span>";
                channelInfoDiv.appendChild(channelTextDiv);
                document.querySelector(".container").appendChild(channelInfoDiv);
            })
        );
}
function isEmptyOrSpaces(str) {
    return str === null || str.match(/^ *$/) !== null;
}