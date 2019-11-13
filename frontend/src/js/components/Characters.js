export default function Characters(characters) {
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
 
<section class='add-champion'>
    <input class='add-artist_characterName' type='text' placeholder='Add A New Character!'>
    <select class= 'character_atk' name="Attack Type">
    <option value="1">Melee</option>
    <option value="2">Ranged</option>
    </select>    
    <select class= 'character_atk' name="Attack Type">
    <option value="1">Attack Damage </option>
    <option value="2">Ability Power</option>
    </select>    
    <button class='add-character_submit'>Submit</button>
</section>
    `;
}