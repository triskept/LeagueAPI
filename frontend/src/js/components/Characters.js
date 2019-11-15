export default function Characters(chars) {
  console.log(chars);
  return `
    <div>
      <button id="champshortcut"><a href="#shortcutref">Add Champion</a></button>
    </div>
    <ul id="charlist"> 
    ${chars
      .map(character => {
        return `
             <li id="character">
                <img class="characterIMG" src=${character.image}></img>
                <h3>${character.name}</h3>
                <input class="character_id" type="hidden" value="${character.id}"></input>
                <button class="charbutton">Edit</button>
                <button class="charbutton">Delete</button>
            </li>
        `;
      })
      .join('')}
 </ul>

 <section id="shortcutref" class='add-champion'>
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
