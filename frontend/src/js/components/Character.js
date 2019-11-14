export default function Character(character){
    return `
    <section class="maincontent_champ">
        <img class="characterIMG" src="${character.image}"></img>
        <h3>${character.name}</h3>
        <h4>${character.atkType}</h4>
        <h4>${character.dmgType}</h4>
    </section>
    
    `
}