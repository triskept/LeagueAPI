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
        .join("")}
   </ul>
   
  <section class='add-position'>
      <input class='add-positionname' type='text' placeholder='Add A New Position!'>
      <input class='add-positionimg' type='hidden' value='../docs/images/1.png'
      <button class='add-position_submit'>Submit</button>
  </section>
      `;
  }
  