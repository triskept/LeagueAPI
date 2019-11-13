import apiActions from './api/apiAction'
import Header from './components/Header'
import Home from './components/Home'
import Characters from './components/Characters'



export default () => {
    pageBuild()
}

function pageBuild(){
    header()
    home()
    characterNAV()
    characters()
    displayHome()
}

function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header()    
}
function home(){
    const home = document.getElementById("app")
    home.innerHTML = Home()    
}
function characters(){
    const characters = document.getElementById("app")
    characters.innerHTML = Characters()    
}
// nav functions
function characterNAV(){
    const navCharacter = document.querySelector("#champions");
    navCharacter.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44323/api/characters", characters => {
            document.querySelector("#app").innerHTML = Characters(characters);
            console.log(characters);
        });
    });
}
function displayHome(){
    const homeButton = document.getElementById("#home");
    homeButton.addEventListener("click", function(){
    home()
    });
}
