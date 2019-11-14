export default function Home() {
  return `
  <div id="homepage">
    <section id="grid">
        <div id="top" class="position">
            <img src="./images/TopLane.png"></img>
            <h3>Top</h3>
        </div>
        <div id="jungle" class="position">
            <img src="./images/JungleLane.png"></img>
            <h3>Jungle</h3>
        </div>
        <div id="mid" class="position">
            <img src="./images/MiddleLane.png"></img>
            <h3>Mid</h3>
        </div>
        <div id="adc" class="position">
            <img src="./images/ADCLane.png"></img>
            <h3>ADC</h3>
        </div>
        <div id="support" class="position">
            <img src="./images/SupportLane.png"></img>
            <h3>Support</h3>
        </div>
    </section>

    <section id="grid2">
        <div id="topbtn">
            <a id="topbrowse">View</a>
        </div>
        <div id="junglebtn">
            <a id="junglebrowse">View</a>
        </div>
        <div id="midbtn">
            <a id="midbrowse">View</a>
        </div>
        <div id="adcbtn">
            <a id="adcbrowse">View</a>
        </div>
        <div id="supportbtn">
            <a id="supportbrowse">View</a>
        </div>
    </section>

    <h1>OP Champs</h1>
    <section id="grid3">
        <div id="creator1" class="opchamp">
            <img src="./images/1.png"></img>
        </div>
        <div id="creator2" class="opchamp">
            <img src="./images/2.png"></img>
        </div>
        <div id="creator3" class="opchamp">
            <img src="./images/3.png"></img>
        </div>
        <div id="creator4" class="opchamp">
            <img src="./images/4.png"></img>
        </div>
        <div id="creator5" class="opchamp">
            <img src="./images/5.png"></img>
        </div>
    </section>
</div>
`;
}
