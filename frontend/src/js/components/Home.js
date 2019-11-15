import Position from './Position'

export default function Home() {
  return `
  <div id="homepage">
    <section id="grid">
        <div id="characters" class="btn">
            <img src="./images/JungleLane.png"></img>
            <h3>Champions</h3>
        </div>
        <div id="positions" class="btn">
            <img class="top" src="./images/TopLane.png"></img>
            <h3>Positions</h3>
        </div>
    </section>

    <h1>Overpowered Champions (Patch 9.22)</h1>
    <section id="grid2">
        <div id="creator1" class="opchamp">
            <img src="./images/99.png"></img>
        </div>
        <div id="creator2" class="opchamp">
            <img src="./images/100.png"></img>
        </div>
        <div id="creator3" class="opchamp">
            <img src="./images/54.png"></img>
    </section>
</div>
`;
}
