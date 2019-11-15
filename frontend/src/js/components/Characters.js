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
                <button class="delete-char">Delete</button>
            </li>
        `;
      })
      .join('')}
 </ul>

 <section id="shortcutref" class='add-char'>
 <input class='add-char_charName' type='text' placeholder='Add A New Character!'>
 <select class= 'add-char_charatk' name="Attack Type">
     <option value="1">Melee</option>
     <option value="2">Ranged</option>
 </select>    
 <input class="add-char_charimg" type="hidden" value="./images/genericArtist.jpg"></input>
 <select class= 'add-char_chardmg' name="Damage Type">
     <option value="1">Attack Damage </option>
     <option value="2">Ability Power</option>
 </select>    
 <select class= "add-char_positionId" name="Role">
      <option value="1">Top</option>
      <option value="2">Jungle</option>
      <option value="3">Mid</option>
      <option value="4">ADC</option>      
      <option value="5">Support</option>
</select>
<button class='add-char_submit'>Submit</button>
</section>

 `;
}
