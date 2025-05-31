# 3d Graphics Evaluatie

## Procedure

* Op 6 juni om 17.00 uur Belgische tijd zal ik een link plaatsen om je in te schrijven voor een examenblok. Als alle slots vol zijn, stuur me dan een e-mail en ik zal extra slots openen.
* Ik zal twee links plaatsen, aangezien het examen op twee dagen plaatsvindt. Schrijf je alsjeblieft in voor de dag die je is toegewezen in je ISP. Anders verplaats ik je handmatig
* Het examen duurt 30 minuten
* Kom ten minste 30 minuten te vroeg voor je examen. Als je te laat bent voor het examen, geef ik voorrang aan iedereen die op tijd is, dus het kan enkele uren duren voor je aan de beurt bent. 
* Als ik je vraag om je examen eerder te doen omdat iemand te laat is, heb je het recht om dat te weigeren en je examen op de geplande tijd te maken.
* Je hebt het recht om het examen in het Engels of Nederlands te doen. Vertel me op elk moment in welke taal je het examen wilt doen en ik wissel om.
* Als ik je vertel dat het examen klaar is voor die 30 minuten om zijn, is dat geen indicatie van je eindscore, het betekent alleen dat ik gecontroleerd heb wat ik moest controleren.
* Ik laat je je project zien op mijn machine. Neem je eigen machine mee, voor het geval de mijne stuk gaat of we verschillende resultaten hebben.
* Ik neem je code door, op zoek naar onderdelen om over te discussiëren. Ik vraag je wat je code doet, en ik vraag je waarom je het op die manier hebt geïmplementeerd, evenals de context van je code.
* Ik zal je ook vragen om te bevestigen welke features ik heb gemist tijdens mijn eerdere beoordeling.
* Ik zal je ook vragen stellen over de theorie van 3d graphics, vaak omdat het relevant is voor je code, maar ook in het algemeen.
* Ik kan je vragen om iets op het whiteboard te tekenen. Als je je daar niet prettig bij voelt, heb ik ook wat kladpapier en een pen bij me. De redenering is dat veel dingen in 3D-afbeeldingen het beste grafisch kunnen worden uitgelegd.


## Voorbeeld examenvragen

Let op, ik kan je elk van de volgende vragen stellen, ongeacht wat of hoe je de vereisten van de projecten hebt geïmplementeerd. Dat betekent dat ik je iets kan vragen, zelfs als het niet in je code voorkomt. Deze lijst is *niet* volledig, ik zal je ook vragen stellen die niet op deze lijst staan. Een voorbeeld hiervan zijn follow-up vragen. Het is alleen bedoeld om je een idee te geven van de inhoud die wordt behandeld, en op welke manier. 

* Wat is normal? 
* Wat is de face normal?
* Wat is de vertex normal?
* Hoe bereken je de face normal?
* Wat is het dot product? Wat zijn de parameters en wat berekent het? Wat is de range van de return?
* Wat is het cross product? Wat zijn de parameters en wat berekent het? 
* Wat is procedurele generatie?
* Wanneer zou je procedurele generatie gebruiken?
* Wat is aliasing?
* Heb je aliasing in je render? Waar?
* Wat is mipmapping?
* Wat is de relatie tussen mipmapping en aliasing?
* Wat is anti-aliasing?
* Geef een voorbeeld van anti-aliasing
* Wat is een vertex shader? Wat doet het meestal?
* Wat is een pixel/fragment shader? Wat doet deze meestal?
* Wat is de rasterizer?
* Wat is een vertex? Wat zit er meestal in een vertex?
* Wat is een indexbuffer?
* Wat is de winding van een driehoek?
* Geef twee verschillen tussen offline rendering en real time rendering. 
* Wat is handedness?
* Wat zijn transform spaces? Hoe ga je van de ene naar de andere?
* Wat is viewspace?
* Wat is een materiaal/BRDF? Geef een voorbeeld
* Wat is het verschil tussen diffuse en speculaire verlichting?
* Hoe kun je het verschil zien tussen diffuse en speculaire verlichting?
* Hoe werken spiegels?
* Wat zijn enkele redenen om proceduralisme te gebruiken?
* Geef een voordeel en een nadeel van proceduralisme
* Wat is een heightmap?
* Hoe kunnen we een wiskundige functie zoals *sin* gebruiken om terrein te maken?
* Hoe werkt value (of perlin) noise? 
* Hoe kunnen we een 2D textuur mappen op een 3D object?
* Wat is temporal aliasing?
* Wat is een LOD?
* Welke stappen gebeuren er als je een mesh naar de GPU stuurt?
* Wat is een dieptebuffer? Bespreek een gebruik
* Hoe werken schaduwen?
* Wat is een perspectief camera? Bespreek zijn parameters / geometrie (frustum)
* Wat zijn twee verschillende soorten camera's
* Wat is gezichtsveld (FOV)?
* Vergelijk raytracing met rasterizer: hun voordelen, nadelen
* Wat betekent 'renderen'?
* Wat is het “primaire zichtbaarheid” probleem?
* Hoe lost een rasterizer het primaire zichtbaarheidsprobleem op?
* Hoe werkt een voorwaartse renderer?
* Hoe werkt een uitgestelde renderer?
* Wat zijn de voor- en nadelen van een voorwaartse renderer?
* Wat zijn de voor- en nadelen van een uitgestelde renderer?
* Wat is een gbuffer?
* Wat is tonemapping? Hoe werkt het?
* Wat is finite differencing? Geef een voorbeeld van wanneer je eindige differentiëring zou gebruiken

## Diengen die niet gevraagd gaan worden

* Alles over foveated rendering en VRS (je moet wel een aantal dingen weten uit de presentatie, met name over aliasing in het algemeen)
* Waar de afkorting BRDF voor staat
* Gooch shading, behalve dat het een voorbeeld is van een BRDF
* Team Fortress 2 rendering, behalve dat het een voorbeeld is van een BRDF.
* Specifieke videogames en feiten daarover. Je moet bijvoorbeeld wel de algemene principes van proceduralisme kennen, maar niet de games waar we het over hebben gehad. Ik zal je niet vragen “Hoe heeft Elite proceduralisme gebruikt om werelden te maken?”, maar ik kan je wel vragen “Hoe kan proceduralisme gebruikt worden om werelden te maken?”.
* Voronoi-functies
* L-Systemen
* Tiny Glade
* Ambient Occlusion
* Bloom

## Beoordeling 

De beoordeling bestaat uit 3 vermenigvuldigingsstappen
* Elke functie in de projectdocumentatie wordt vooraf in je project gecontroleerd en ik zal dit tijdens het examen met je bevestigen. Je krijgt een cijfer voor hoeveel je hebt kunnen implementeren.
* Je krijgt vragen over deze functies, de theorie erachter en algemene vragen over 3d graphics. Je krijgt een percentage als cijfer, afhankelijk van hoe volledig/correct je antwoorden zijn.
* Je krijgt een aftrek op basis van eventuele overtredingen van de requirements.

Deze waarden worden met elkaar vermenigvuldigd. Dit betekent dat je een voldoende moet halen voor zowel het project als de theorie. 

## Algemeen advies

* Kom opdagen! Als je project niet af is, lever het dan in en schrijf je in voor het examen. Ik heb te vaak gezien dat studenten zichzelf 'lieten zakken' door te denken dat het hopeloos was en niet op te komen dagen. Ik ben daar verantwoordelijk voor :) Schrijf je in, kom opdagen, zelfs als je zakt ben je gerustgesteld als je een herexamen doet, want je weet hoe het examen gaat en je hebt feedback gehad op je project.
* Focus op het grote geheel. Ik denk dat het belangrijker is dat je de context kent van alle verschillende dingen in de cursus en hoe ze bij elkaar passen dan dat je specifieke details kent.
* Antwoord zelfverzekerd en eerlijk. Met zelfverzekerd bedoel ik dat als je denkt dat je iets weet, je het gewoon moet zeggen. Alsof je met een andere student discussieert tijdens practica. Met eerlijk bedoel ik dat als je iets niet weet, je het gewoon zo moet zeggen. 
* 30 minuten is veel tijd. Als je een minuut nodig hebt om over dingen na te denken, vraag er dan gewoon om. Ik kan je misschien opjagen als onze tijd opraakt en ik denk dat het in jouw belang is om verder te gaan, maar over het algemeen hebben we meer dan genoeg tijd.
