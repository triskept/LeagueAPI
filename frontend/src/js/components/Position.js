export default function Positions(characters) {
    return `
    <ul> 
    ${characters
      .map(character => {
        return `
             <li id="character">
                <img src=${character.image}></img>
                <h3>${character.name}</h3>
                <h5>Attack Type: ${character.atkType}</h5>
                <h5>Damage Type: ${character.dmgType}</h5>
                <p><input class="artist_id" type="hidden" value="${character.id}"></p>
                <button class="edit-character_submit">Edit</button>
                <button class="delete-character_submit">Delete</button>
                </li>
        `;
      })  
      .join("")}
 </ul>
    `}