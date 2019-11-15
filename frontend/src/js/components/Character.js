export default function Character(character) {
  return `
    <section class="maincontent_champ">
        <img class="characterIMG" src="${character.image}"></img>
        <h1>${character.name}</h1>
        <h3>Attack Type:</h3>
        <h4>${character.atkType}</h4>
        <h3>Damage Type:</h3>
        <h4>${character.dmgType}</h4>
    </section>
    
    `;
}
