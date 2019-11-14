import apiActions from './api/apiAction'
import Header from './components/Header'
import Home from './components/Home'
import Characters from './components/Characters'
import Position from './components/Position'
import PosChamps from './components/PosChamps'
import Character from './components/Character'


export default () => {
    pageBuild()
}

function pageBuild(){
    header()
    home()
    characterNAV()
    displayHome()
    positionNav()
    // positionTop()
}

function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header()    
}
function home(){
    const home = document.getElementById("app")
    home.innerHTML = Home()    
}


// function positionTop(){
//     const app = document.querySelector("#app")
//     app.addEventListener("click", function(){
//         if(event.target.classList.contains("top")){
//             const posID = event.target.parentElement.querySelector(".position_id").value;
//             console.log(posID);
//             apiActions.getRequest(`https://localhost:44323/api/positions/${positionid}`,
//             position => {
//                 console.log(position.characters)
//                 app.innerHTML = Characters(position.characters)
//             })
//         }
//     });
// }


// nav functions
function positionNav(){
    const positionBtn = document.querySelector("#positions")
    const app = document.querySelector("#app")
        positionBtn.addEventListener("click", function (){
        apiActions.getRequest("https://localhost:44323/api/positions", pos => {
        app.innerHTML = Position(pos);
        });
    });
    app.addEventListener("click", function(){
        if (event.target.classList.contains('posIMG')){
            const positionID = event.target.parentElement.querySelector(".position_id").value;
            console.log(positionID);
            apiActions.getRequest(`https://localhost:44323/api/positions/${positionID}`,
            position => {
                console.log("Position:" + position.characters)
             app.innerHTML = PosChamps(position);
            })
        }
    });
    app.addEventListener("click", function(){
        if (event.target.classList.contains('characterIMG')){
            console.log(event.target.parentElement.querySelector(".character_id"))
            const characterID = event.target.parentElement.querySelector(".character_id").value;
            console.log(characterID);
            apiActions.getRequest(`https://localhost:44323/api/characters/${characterID}`,
            character => {
             app.innerHTML = Character(character);
            })
        }
    });
}

function characterNAV(){
    const navCharacter = document.querySelector("#champions");
    navCharacter.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44323/api/characters", chars => {
            document.querySelector("#app").innerHTML = Characters(chars);
            console.log(`in char nav ${chars}`);
        });
    });


}
function displayHome(){
    const homeButton = document.getElementById("home");
    homeButton.addEventListener("click", function(){
    home()
    });
}
