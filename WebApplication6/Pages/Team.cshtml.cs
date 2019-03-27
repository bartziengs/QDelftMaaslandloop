using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication6.Pages
{
    public class TeamModel : PageModel
    {

        public List<TeamMember> TeamMembers = new List<TeamMember>();
        public void OnGet()
        {
            TeamMembers.AddRange(new List<TeamMember> {
            new TeamMember
            {
                Name = "Alex van der Meijs",
                Age = 51,
                SpareTime = "Qua sportieve uitspattingen besteed ik mijn vrije tijd geregeld aan tennissen en hardlopen. In de zomermaanden meer tennis, in de andere maanden beetje fifty-fifty. Nu met de Maaslandloop in zicht ben ik naast de tennis weer fanatiek 3 keer per week aan het lopen en dat gaat boven verwachting goed. De ene keer een (d)uurloopje, de ander keren intervallen of een snelheidsloopje. Mijn zoon Twan gaat ook meedoen met een ander Maaslandloop-team en ik kijk er al naar uit om samen met Twan af en toe een run-bike-run-training te gaan doen.",
                GreatestExperience = "Dan kom ik toch uit bij de Maaslandloop wanneer je op zaterdagochtend over een dijk richting Gorinchem aan het hardlopen bent, al ruim 250 km achter de kiezen hebt met elkaar, het zonnetje op komt en je de spreekwoordelijke stal al bijna ruikt. Geweldig gewoon.",
                Motivation = "Van de 10 voorbije edities heb ik er zelf 5 actief meegemaakt. Toch is de motivatie weer volop aanwezig, omdat het stuk voor stuk mooie edities waren met uiteraard moeilijke momenten maar ook zeer veel hoogtepunte de Maaslandloop naast een individuele ook zeker een teamprestatie is en het blijft geweldig om dat mee te maken; ik twee keer eerder met een volledig nieuw team(op mezelf na) heb deel genomen aan de Maaslandloop en ik dat als super leuk heb ervaren; hardlopen met als doel zo’n 32 keer te vlammen tijdens de Maaslandloop gewoon een goede motivatie is en het daarmee ook een stuk leuker wordt, en het een goed doel steunt waarbij kinderen centraal staan.",
                ImgSrc = "/alex.jpg",
            },
            new TeamMember
            {
                Name = "Raymond Verhoef",
                Age = 37,
                SpareTime = "mijn vrouw en twee kinderen van 6 en 3 die af en toe mee willen (fietsen) tijdens mijn rondjes hardlopen. Dat doe ik al sinds mijn 16e waarin ik de laatste jaren steeds vaker deelneem aan georganiseerde evenementen. Ik vind het leuk om mee te doen aan kleinschalige evenementen, zoals een trailrun door het bos en lokale 10km of halve marathons. Desalniettemin heb ik me in 2015 toch laten overhalen om mijn eerste marathon in Rotterdam te lopen, waarin ik mijn doel om dit onder de 4 uur te doen net niet haalde. Vastbesloten dat wel te halen volgden er nog drie marathons maar helaas kom ik nog steeds een paar minuutjes te kort! Ter afwisseling op het hardlopen doe ik regelmatig aan indoor roeien en stap ik graag op een zonnige dag op de racefiets voor een mooie duurtocht door de Zuid Hollandse polders.",
                GreatestExperience = "Het passeren van het 35km punt tijdens de Marathon van Zeeuws Vlaanderen, waarbij ik mijn zoontje passeerde die me letterlijk een duwtje in de rug gaf om door te gaan.",
                Motivation = "De Maaslandloop is een waanzinnige sportieve uitdaging, die je samen met een team collega’s moet volbrengen. De combinatie waarbij we ook nog eens een ontzettend goed doel kunnen steunen is een fantastische drijfveer om door te zetten! Een evenement als de Maaslandloop is een prachtige teamprestatie.",
                ImgSrc = "/raymond.jpg",
            },
            new TeamMember
            {
                Name = "Piet de Jong",
                Age = 48,
                SpareTime = "Al sinds mijn jeugd aan hardlopen. Mijn eerste kennismaking was op 8-jarige leeftijd lid worden van een atletiekvereniging waar ik beslist niet uitblonk in kogelstoten en hoogspringen, maar wel in de langere hardloopafstanden. Verder hou ik deze hobby in balans met mijn gezin, waar helaas geen van mijn kinderen interesse heeft in hardlopen.",
                GreatestExperience = "De Westland marathon van 2014. Dit evenement werd éénmalig georganiseerd en lopen door je eigen achtertuin daar kan niets tegenop. Het was een mooie hete dag en onderweg hebben mijn kinderen mij voorzien van drinken en de nodige gelletjes. En dan afsluiten met een 7de plaats, mooier gaat het voorlopig niet worden.",
                Motivation = "Motivatie voor deze loop heb ik eigenlijk niet nodig. Het lopen met collega’s en voor het goede doel voor kinderen maakt meedoen nog makkelijker. ",
                ImgSrc = "/piet.png",
            }
            });
        }
    }

    public class TeamMember
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string SpareTime { get; set; }

        public string GreatestExperience { get; set; }

        public string Motivation { get; set; }

        public string ImgSrc { get; set; }
    }
}