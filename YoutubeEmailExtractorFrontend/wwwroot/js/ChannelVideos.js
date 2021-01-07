function CopyToClipboard(element){
    // document.querySelector("#test").select();
    let input = document.querySelector("#test");
    input.setAttribute("type", "text");
    input.value = element.innerText;
    input.select();  
    document.execCommand('copy');
    input.setAttribute("type", "hidden");
}

function searchVideos() {
    let id = document.getElementById("channelId").value;
    console.log("in searchchannels, text: " + id);
    if (isEmptyOrSpaces(id)) return;

    document.querySelectorAll(".videoInfo").forEach((e) => e.remove());
    let url = "https://localhost:44395/api/getvideos?channelId=" + id;
    fetch(url)
      .then((responce) => responce.json())
      .then((result) =>
        result.forEach((obj) => {
            console.log(obj);
            let videoInfoDiv = document.createElement("div");
            videoInfoDiv.classList.add("videoInfo");
            
            let videoImageDiv = document.createElement("div");
            videoImageDiv.classList.add("image");

            let videoImage = document.createElement("img");
            videoImage.setAttribute("src", obj.imageAddress);
            videoImageDiv.appendChild(videoImage);
            
            videoInfoDiv.appendChild(videoImageDiv);

            let textDiv = document.createElement("div");
            textDiv.classList.add("text");

            let channelNameSpan = document.createElement("span");
            channelNameSpan.classList.add("videoName");
            channelNameSpan.innerText = "Video name: "+obj.title;

            textDiv.appendChild(channelNameSpan);

            let channelIdSpan = document.createElement("span");
            channelIdSpan.classList.add("videoId");
            channelIdSpan.innerHTML =
            'Channel Id: <span>'+ obj.id+' '+
            '<i class = "fa fa-copy" onclick = "CopyToClipboard(this.parentElement)"></i></span>'
            
            textDiv.appendChild(channelIdSpan);
            videoInfoDiv.appendChild(textDiv);

            document.querySelector(".container").appendChild(videoInfoDiv);
        })
      );
    }

function isEmptyOrSpaces(str){
    return str === null || str.match(/^ *$/) !== null;
}