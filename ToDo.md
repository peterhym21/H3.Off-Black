# ToDo

- lav sorting / filtering 
- lav cart færdig,
- lav place order færdig
- lav user login færdig
- admin user tabel, + admin side (kan laves med area) 

## Krav til Siden

### A. Krav til forsiden

- [X] Forsiden viser et antal produkter med et billede af hver, prisen, navn og en knap til at lægge varen i kurven
- [X] Der benyttes Paging således at forsiden kun viser et bestemt antal produkter ad gangen. Man kan se at der evt. er flere produkter
- [X] Der er mulighed for at søge på "Brand" og på "Type" eller lignende
- [X] Der er også fritekst-søgning
- [ ] Der er mulighed for stigende og faldende sortering
- [X] Der vises et ikon med en varekurv og et antal varer i kurven. Klikkes på ikonet, vises varekurven
- [X] Lægges en vare i kurven, vises den opdaterede varekurv

### B. Krav til varekurven

- [X] Varekurven viser en opdateret liste af valgte produkter, med billede, navn, styk-pris, antal (skal kunne ændres) samt linjepriseen.
- [ ] Der skal være en Update knap, som opdaterer priserne hvis man ændrer antallet.
- [ ] Det skal være muligt at fjerne et produkt fra varekurven, hvis man fortryder valget
- [ ] Der skal være en Checkout knap, som fører til Checkout-siden
- [ ] Der skal være en knap, der giver mulighed for at fortsætte med at handle, inden man går til checkout


### C. Krav til checkout

- [ ] Brugeren skal afgive oplysninger om email, navn, adresse, valg af betalingsmiddel og forsendelse
- [ ] Når brugeren trykke på Køb knappen, skal der udsendes en mail som bekræftelse af købet


### D. Administration

- [ ] En Admin side, der giver en administrator en liste over alle produkter 
- [ ] Admin siden skal have mulighed for at redigere produkterne og deres data.
- [ ] Der er fokus på at demonstrere update og delete af en graf af data.

### Optionelle krav til applikationen

- [ ] Forsiden viser "featured" produkter
- [ ] Når musen passerer henover et billede af et produkt, fremhæves billedet (evt. med en skygge eller ramme)
- [ ] Mulighed for at logge ind, f.eks. når man går til Checkout. 
- [ ] Hvis brugeren er logget ind, slipper brugeren for at registrere sig igen
- [ ] Når brugeren er logget ind, vises produkter som anses for at være interessante for netop denne kunde, baseret på en profil


### Andre krav til design og implementation

- [ ] Designet laves således at det opfylder best practice indenfor databasedesign
- [X] Der benyttes Entity Framework Core
- [ ] Der foretages en funktionstest, der viser at de funktionelle krav er opfyldt
- [X] Der skal indbygges en Logging facilitet (f.eks. NLog)
- [X] Der skal indbygges exception handling.