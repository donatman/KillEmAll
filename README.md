<<<<<<< HEAD
# HackNNSlash

Aina ennen kuin aletaan tehdä uusia muutoksia:
=======
# KillEmAll

Aina ennen kuin aloittaa tekemään mitään:
>>>>>>> d3a65ab7d8e02798150e149207327f877a1115cf
git pull
Tällä saa kaikki muutokset repositorysta itselleen.

Komennoilla git log tai git log --name-status näkee mitä muutoksia on tapahtunut viimeksi.

Kun on tehnyt haluttuihin tiedostoihin muutoksia niin komennolla:
git status
näkee mihin tiedostoihin on tehnyt muutoksia.
git diff
komennolla näkee tarkemmin tiedostoihin tehdyt muutokset.

<<<<<<< HEAD
Jos haluaa lisätä kokonaan uusia tiedostoja niin git status näyttää "Untracked files" alla tiedostot, jotka pitää lisätä git add komennolla.
=======
git status näkee uudet tiedostot jotka voi laittaa git add -A komennolla

>>>>>>> d3a65ab7d8e02798150e149207327f877a1115cf
Seuraavalla komennolla laitetaan muutokset lokaalisti talteen. Nämä eivät siis vielä näy repositoryssa (eli itse gitissä):
git commit -a -m "Tähän tulee viesti minkä muut näkee"

Tämän jälkeen repositoryyn:
git push
Jonka jälkeen, kun muut tekevät git pull he saavat tehdyt muutokset

Jos push ei mene läpi, on todennäköisesti jollakin toisella jo muutoksia repositoryssa. Tällöin:
git pull --rebase
Ottaa muiden muuutokset ja laittaa omat muutokset niiden päälle. Omat ovat siis uusimmat jälleen kerran.


Konfliktit
Uuden tiedoston lisääminen
Tiedoston poistaminen kokonaan
