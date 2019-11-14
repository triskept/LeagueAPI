export default function PosChamps(position){console.log(position)
    return `
    <article>
        <img src=${position.image} class="positionIMG"></img>
        <input class="position_id" type="hidden" value="${position.id}"></input>
    </article>
    <ul>
        ${position.characters
        .map(character => {
            return `
            <li>
                <img class="characterIMG" src=${character.image}></img>
                <input class="character_id" type="hidden" value="${character.id}"></input>
                <h3>${character.name}</h3>
            </li>
            `;
        })
    .join("")}
    </ul>
    `;
}