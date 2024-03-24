<ol>
  <h2><li>ga door op je animation project of ga naar de git workshop2finished</li></h2>
  <h2><li>Package install:</li></h2>
    <ul>
      <li>Ga naar de package manager en zoek in de registry naar Cinemachine (2.9.7) en timeline(1.8.2) en voeg deze toe aan het unity project.</li>
      <li>(Indien je met het vooropgezette animation project werkt moet je ook naar de scene Jian in de scene’s folder gaan)</li>
    </ul>
  <h2><li>Eerste vCam</li></li></h2>
    <ul>
      <li>Onder de hierarchy maak je een onder cinemachine een nieuwe virtual camera aan en laat deze via de lookat naar de speler kijken (verplaats deze in de wereld om te kijken of het              werkt)</li>
    </ul>
  <h2><li>Tweede vCam</li></h2>
    <ul>
      <li>Voeg een 2e virtual camera toe die je een hogere prioriteit geeft en controlleer of in de game deze camera nu wordt gebruikt. (deze ook een lookat naar de speler maken)</li>
    </ul>
  <h2><li>Switch tussen camera</li></h2>
    <ul>
      <li>In de game kun je in de unity editor door de prioriteit te veranderen van camera switches. De prioriteit staat standaard op 10 en je kunt het beste de prioriteit in kleine stappen           verhogen 10->11->12. Probeer dit uit en kijk naar de transities tussen de camera's.</li>
    </ul>
   <h2><li>Dolly cart</li></h2>
    <ul>
      <li>In de Hierarchy, voeg via cinemachine een dolly track with cart toe, voeg in de track een 3e waypoint toe en sleep deze om de speler heen. De snelheid waarmee de cart standaard              beeweegd is 0, zet deze hoger (rond de 5)</li>
      <li>Zet daarna een van de virtual camera's uit de eerste stappen (degene met de hoogste prioriteit) in de dolly cart en kijk of dit naar behoren werkt.</li>
      <li>(de camera volgt het pad veranderingen niet het pad zelf, als je camera te ver weg is dan sleep de camera/cart naar de track toe), (als je wilt dat de camera de cart niet 1 keer             maar vaker over de track gaat dan moet je het vinkje “Looped” aanzetten)</li>
    </ul>
  <h2><li>State camera</li></h2>
    <ul>
      <li>Voeg via hierarchy een state-driven camera toe, zet in de animation target je geanimeerde object.</li>
      <li>In de editor, onder states staat een plus, druk hierop en clik all unhandled states (of handmatig alle states via new state).</li>
      <li>Onder virtual camera children voeg je per state een camera toe en in states koppel je de camera aan een state. Maak hiervoor eventueel extra virtual camera's. Geef deze camera's             een hogere prioriteit.</li>
      <li>Check in game of een state change in je animatie voor een andere camera zorgt.</li>
    </ul>
  <h2><li>Impulse op camera</li></h2>
    <ul>
      <li>Voeg een Cinemachine Independent Impulse Listener component toe op de Main Camera (waar de Cinemachine Brain op staat).</li>
      <li>Voeg vervolgens een Cinemachine Impulse Source component toe op de Y Bot (waar de Animation Controller Script op staat).</li>
      <li>Nu kun je in de code van de Animation Controller Script bij de Start method GetComponent gebruiken om een referentie naar de Cinemachine Impulse Source te verkrijgen.</li>
      <li>Hierna kan je in de code de functie GenerateImpulse(Vector3 vector3) aanroepen om zo een Cinemachine Impulse naar alle listeners te sturen. Dit zou je in de ResetAimingLayer                 kunnen doen.</li>
    </ul>
  <h2><li>Objecten bewegen via dolly</li></h2>
    <ul>
      <li>Voeg 2 nieuwe dolly track with cart toe en zorg dat deze op looped staan.</li>
      <li>Voeg 3 objecten toe (cubus bijvoorbeeld) en laat er 2 van bewegen door deze in de dolly carts te zetten. (het derde object hoeft niet te bewegen)</li>
    </ul>
  <h2><li>Target group, alles in beeld houden</li></h2>
    <ul>
      <li>Voeg via hierarchy een target groep met camera toe, zet in de target group de targets op de stilstaande cubus + de 2 dolly carts targetten)</li>
      <li>Zet de aangemaakte virtual camera de follow property op None en sleep de camera naar een positie in de buurt van de cubussen</li>
    </ul>
  <b>(test in game of de camera werkt)</b>
  <br>
  <h2><li>Timeline</li></h2>
    <ul>
      <li>Ga naar Window->sequensing en druk op timeline.</li>
      <li>Create a empy game object en click create in de timeline window.</li>
      <li>In de timeline click in het linker scherm op + cinemachine track</li>
      <li>Zet in deze je main camera en plaats alle virtual camera's die je tot nu toe hebt gemaakt achter elkaar in deze timeline</li>
    </ul>
  <b>(Check of dit werkt)</b>
  <br>
   <h2><li>Blending in timeline/li></h2>
    <ul>
      <li>Sleep sommige virtual camera's in elkaar en kijk of deze blenden, des te meer je ze in elkaar sleept des te meer en langer</li>
    </ul>
</ol>





