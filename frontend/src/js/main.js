import apiActions from './api/apiAction';
import Header from './components/Header';
import Home from './components/Home';
import Characters from './components/Characters';
import Position from './components/Position';
import PosChamps from './components/PosChamps';
import Character from './components/Character';
import Footer from './components/Footer';

export default () => {
  pageBuild();
};

function pageBuild() {
  header();
  home();
  footer();
  characterNAV();
  positionNAV();
  homeNAV();
  positionpageNAV();
  characterpageNAV();
}

function header() {
  const header = document.getElementById('header');
  header.innerHTML = Header();
}
function home() {
  const home = document.getElementById('app');
  home.innerHTML = Home();
}
function footer() {
  const footer = document.getElementById('footer');
  footer.innerHTML = Footer();
}

// nav functions
function positionpageNAV() {
  const positionBtn = document.querySelector('#positions');
  const app = document.querySelector('#app');
  positionBtn.addEventListener('click', function() {
    apiActions.getRequest('https://localhost:44323/api/positions', pos => {
      app.innerHTML = Position(pos);
    });
  });
  app.addEventListener('click', function() {
    if (event.target.classList.contains('posIMG')) {
      const positionID = event.target.parentElement.querySelector(
        '.position_id'
      ).value;
      console.log(positionID);
      apiActions.getRequest(
        `https://localhost:44323/api/positions/${positionID}`,
        position => {
          console.log('Position:' + position.characters);
          app.innerHTML = PosChamps(position);
        }
      );
    }
  });
  app.addEventListener('click', function() {
    if (event.target.classList.contains('characterIMG')) {
      console.log(event.target.parentElement.querySelector('.character_id'));
      const characterID = event.target.parentElement.querySelector(
        '.character_id'
      ).value;
      console.log(characterID);
      apiActions.getRequest(
        `https://localhost:44323/api/characters/${characterID}`,
        character => {
          app.innerHTML = Character(character);
        }
      );
    }
  });
}
function characterNAV() {
  const navCharacter = document.querySelector('#champions');
  navCharacter.addEventListener('click', function() {
    apiActions.getRequest('https://localhost:44323/api/characters', chars => {
      document.querySelector('#app').innerHTML = Characters(chars);
    });
  });
}
function characterpageNAV() {
  const navChampion = document.querySelector('#characters');
  const app = document.querySelector('#app');
  navChampion.addEventListener('click', function() {
    apiActions.getRequest('https://localhost:44323/api/characters', chars => {
      app.innerHTML = Characters(chars);
    });
  });
}
function homeNAV() {
  const homeButton = document.getElementById('home');
  homeButton.addEventListener('click', function() {
    window.location.reload();
  });
}
function positionNAV() {
  const navPosition = document.querySelector('#position');
  const app = document.querySelector('#app');
  navPosition.addEventListener('click', function() {
    apiActions.getRequest('https://localhost:44323/api/positions', pos => {
      app.innerHTML = Position(pos);
    });
  });
}
