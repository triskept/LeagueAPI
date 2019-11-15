export default function Position(pos) {
  console.log(pos);
  return `
      <ul id="poslist"> 
      ${pos
        .map(position => {
          return `
               <li class="position">
                  <img class="posIMG" src=${position.image}></img>
                  <h3>${position.name}</h3>
                  <input class="position_id" type="hidden" value="${position.id}">
                  </li>
          `;
        })
        .join('')}
   </ul>   
      `;
}
