export default function Header(){
    return `
    <div class="menu-wrap">
    <input type="checkbox" class="toggler">
    <div class="hamburger"><div></div></div>
    <div class="menu">
      <div>
        <div>
          <ul>
            <li><a id="home"><strong>Home</strong></a></li>
            <li><a id="champions"><strong>Champions</strong></a></li>
            <li><a id="position"><strong>Position</strong></a></li>
            </ul>
        </div>
      </div> 
    </div>
  </div>
  <div id="headerpic">
    <img src="../images/header.png" />
    <h1>Champion API</h1>
  </div>
  `
}