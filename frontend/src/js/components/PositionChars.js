export default function PositionChars(position) {
  return `
  <section class='main-content_position'>
  <h3>Position: ${position.name}</h3>  
  </section>

<section id="poschar">    
<ul> 
  ${position.characters
    .map(character => {
      return `
           <li id="chars">
              <img id="charIMG" src=${character.image}></img>
              <h3>${character.name}></h3>
              <h3>${character.atkType}</h3>
              <h3>${character.dmgType}</h3>
              <p><input class="album_id" type="hidden" value="${character.positionid}"></p>
           </li>
      `;
    })
    .join("")}
</ul>
</section>
  `
};