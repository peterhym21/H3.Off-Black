# ToDo

- lav sorting / filtering 
- lav cart f�rdig,
- lav place order f�rdig
- lav user login f�rdig
- admin user tabel, + admin side (kan laves med area) 

## Krav til Siden

### A. Krav til forsiden

- [X] Forsiden viser et antal produkter med et billede af hver, prisen, navn og en knap til at l�gge varen i kurven
- [X] Der benyttes Paging s�ledes at forsiden kun viser et bestemt antal produkter ad gangen. Man kan se at der evt. er flere produkter
- [X] Der er mulighed for at s�ge p� "Brand" og p� "Type" eller lignende
- [X] Der er ogs� fritekst-s�gning
- [ ] Der er mulighed for stigende og faldende sortering
- [X] Der vises et ikon med en varekurv og et antal varer i kurven. Klikkes p� ikonet, vises varekurven
- [X] L�gges en vare i kurven, vises den opdaterede varekurv

### B. Krav til varekurven

- [X] Varekurven viser en opdateret liste af valgte produkter, med billede, navn, styk-pris, antal (skal kunne �ndres) samt linjepriseen.
- [ ] Der skal v�re en Update knap, som opdaterer priserne hvis man �ndrer antallet.
- [ ] Det skal v�re muligt at fjerne et produkt fra varekurven, hvis man fortryder valget
- [ ] Der skal v�re en Checkout knap, som f�rer til Checkout-siden
- [ ] Der skal v�re en knap, der giver mulighed for at forts�tte med at handle, inden man g�r til checkout


### C. Krav til checkout

- [ ] Brugeren skal afgive oplysninger om email, navn, adresse, valg af betalingsmiddel og forsendelse
- [ ] N�r brugeren trykke p� K�b knappen, skal der udsendes en mail som bekr�ftelse af k�bet


### D. Administration

- [ ] En Admin side, der giver en administrator en liste over alle produkter 
- [ ] Admin siden skal have mulighed for at redigere produkterne og deres data.
- [ ] Der er fokus p� at demonstrere update og delete af en graf af data.

### Optionelle krav til applikationen

- [ ] Forsiden viser "featured" produkter
- [ ] N�r musen passerer henover et billede af et produkt, fremh�ves billedet (evt. med en skygge eller ramme)
- [ ] Mulighed for at logge ind, f.eks. n�r man g�r til Checkout. 
- [ ] Hvis brugeren er logget ind, slipper brugeren for at registrere sig igen
- [ ] N�r brugeren er logget ind, vises produkter som anses for at v�re interessante for netop denne kunde, baseret p� en profil


### Andre krav til design og implementation

- [ ] Designet laves s�ledes at det opfylder best practice indenfor databasedesign
- [X] Der benyttes Entity Framework Core
- [ ] Der foretages en funktionstest, der viser at de funktionelle krav er opfyldt
- [X] Der skal indbygges en Logging facilitet (f.eks. NLog)
- [X] Der skal indbygges exception handling.