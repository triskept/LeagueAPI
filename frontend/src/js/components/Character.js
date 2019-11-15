export default function Character(character) {
  return `
    <section class="maincontent_champ">
        <img class="characterIMG" src="${character.image}"></img>
        <h1>${character.name}</h1>
        <h3>Attack Type:</h3>
        <h4>${character.atkType}</h4>
        <h3>Damage Type:</h3>
        <h4>${character.dmgType}</h4>
        <input class="character__id" type="hidden" value="${character.id}
    </section>
    
    <section class="update-char">
      <input class="update-char_charName" value="${character.name}">
      <input class="update-char_id" type="hidden" value="${character.id}">
      <select class= 'update-char_charatk' name="Attack Type">
        <option value="1">Melee</option>
        <option value="2">Ranged</option>
      </select>    
      <input class="update-char_charimg" type="hidden" value="${character.image}"></input>
      <select class= 'update-char_chardmg' name="Damage Type">
        <option value="1">Attack Damage </option>
        <option value="2">Ability Power</option>
      </select>    
      <select class= 'update-char_positionId' name="Role">
        <option value="1">Top</option>
        <option value="2">Jungle</option>
        <option value="3">Mid</option>
        <option value="4">ADC</option>
        <option value="5">Support</option>
      </select>
      <button class="update-char_submit">Save Changes</button>
    </section>
    `;
}
