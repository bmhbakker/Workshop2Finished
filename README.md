<h1>Mecanim + Cinemachine workshop</h1>
<ol>
  <h2><li>Bereid de animaties voor, voor gebruik met het karakter.</li></h2>
    <ul>
      <li>De animaties zijn nu generiek, zet ze over naar het avatar van het karakter.</li>
      <li>Loop animaties als dit nodig is.</li>
    </ul>
  <br>
  
  <h2><li>Maak een basis layer met een idle animatie</li></h2>
  <ul><li>Maak een eerste layer met de Idle animatie.</li></ul>
  <br>
  
  <h2><li>Maak een blend tree voor de animaties Idle -> Walking -> Running</li></h2>
  <ul>
    <li>Maak een blend tree in de basis layer voor het blenden tussen Idle -> Walking -> Running.</li>
    <li>Gebruik het script om de animatie op de blend tree over te zetten en om de blend waarde aan te passen.</li>
  </ul>
  <br>
  
  <h2><li>Maak een nieuwe layer voor de injured animaties</li></h2>
  <ul>
    <li>Maak een 2de layer aan, zet de checkbox sync aan en vul de states met de injured animaties.</li>
    <li>Maak gebruik van de functie ChangeLayers om het gewicht van de injured layer te wijzigen.</li>
  </ul>
    <br>
    
  <h2><li>Maak een nieuwe layer voor de shooting animatie</li></h2>
  <ul>
    <li>Maak een mask die alleen het bovenlichaam van het karakter gebruikt.</li>
    <li>Pas de mask op de nieuwe layer toe.</li>
    <li>Voeg de shooting animatie toe.</li>
    <li>Ga over op de shooting animatie bij de druk op een knop via het script.</li>
  </ul>
  <br>
    
  <b>(TIP: Bij het enter en exit op de layer kan er logica worden toegepast om de shooting animatie van begin tot eind te laten lopen. Zie: StateMachineBehaviour)</b>
  <br>
  
  <h2><li>Maak een nieuwe layer voor de looking animatie</li></h2>
  <ul>
    <li>Maak een mask die alleen het hoofd van het karakter gebruikt.</li>
    <li>Pas de mask op de nieuwe layer toe.</li>
    <li>Voeg de looking animatie toe.</li>
    <li>Zet het gewicht op 1.</li>
  </ul>
  <br>
    
  <h2><li>Maak animaties voor de kubus</li></h2>
  <ul>
    <li>Maak animatie voor de kubus waarbij deze op en neer beweegt.</li>
    <li>Maak een roteer animatie voor de kubus.</li>
  </ul>
  <br>

  <h2><li>Gebruik additive layer om de animaties te combineren</li></h2>
  <ul>
    <li>Voeg een basis layer toe voor een van de twee animaties.</li>
    <li>Voeg een additive layer toe voor de overige animatie.</li>
  </ul>
  <br>
  
  <h2><li>Zorg dat het karakter naar de kubus kijkt.</li></h2>
  <ul>
    <li>Maak gebruik van LookAt om het karakter naar de kubus te laten kijken wanneer er op een knop wordt gedrukt.</li>
    <li>Dezelfde knop moet de LookAt ook weer uitschakelen.</li>
  </ul>
</ol>
