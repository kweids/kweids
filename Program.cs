using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Runtime.CompilerServices;
using Microsoft.SqlServer.Server;
using System.Speech.Recognition.SrgsGrammar;

namespace FinalProject
{
    internal class Program
    {
        static void Speak(string Genre)
        {
            SpeechSynthesizer _SS = new SpeechSynthesizer();
            _SS.Volume = 100;
            _SS.Rate = 1;
            _SS.Speak(Genre);
        }
        private static void Main(string[] args)
        {

            string DoYouEnjoyReading;
            Console.Write("Do you enjoy reading?: ");
            DoYouEnjoyReading = Console.ReadLine();
            int score = 0;

            if (DoYouEnjoyReading == "Yes")
            {//simula ng program
                Console.WriteLine("Welcome to Aye, I Read");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Try to guess who said the line and what book was it from.");
                Console.WriteLine("E.g.   Soleil Cervantes - Sands of Time");
                Console.WriteLine("-------------------------");

                string Action;
                Console.WriteLine("Action");
                string Adventure;
                Console.WriteLine("Adventure");
                string Drama;
                Console.WriteLine("Drama");
                string Fantasy;
                Console.WriteLine("Fantasy");
                string GeneralFiction;
                Console.WriteLine("General Fiction");
                string Paranormal;
                Console.WriteLine("Paranormal");
                string Romance;
                Console.WriteLine("Romance");
                string RomanticComedy;
                Console.WriteLine("Romantic Comedy");
                string ScienceFiction;
                Console.WriteLine("Science Fiction");
                string TeenFiction;
                Console.WriteLine("Teen Fiction");
                string Thriller;
                Console.WriteLine("Thriller");
                string YoungAdult;
                Console.WriteLine("YoungAdult");
                Console.WriteLine("");


                string Genre;
                Console.Write("What genre would you like to try?: ");
                Genre = Console.ReadLine();
                if (Genre == "Action")
                {//simula ng action
                    //book 1
                    string SIYFT = "As they say, burnt people find comfort in the fire.";
                    string shel;
                    Console.Write("As they say, burnt people find comfort in the fire.: ");
                    Speak(SIYFT);
                    shel = Console.ReadLine();
                    if (shel == "Markus Saldivar - Shelter In Your Fingertips")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (shel == "Markus - Shelter In Your Fingertips")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Markus Saldivar from the book Shelter In Your Fingertips");
                    }
                    Console.WriteLine();//para may space
                    //book 2
                    string hisec = "You irritated me in the worst way possible, but you also made me happy in a level that it could almost reach heaven." ;
                    string BHO;
                    Console.Write("You irritated me in the worst way possible, but you also made me happy in a level that it could almost reach heaven.: ");
                    Speak(hisec);
                    BHO = Console.ReadLine();
                    if (BHO == "Mishiella Greene - BHO: His Secret Agent Pretend Wife")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    if (BHO == "Mishiella - BHO: His Secret Agent Pretend Wife")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Mishiella Greene from the book BHO: His Secret Agent Pretend Wife.");
                    }
                    Console.WriteLine();
                    //book3
                    string TH = "To have great powers is to also experience great misery. That's the rule of our world.";
                    string tantei;
                    Console.Write("To have great powers is to also experience great misery. That's the rule of our world.: ");
                    Speak(TH);
                    tantei = Console.ReadLine();
                    if (tantei == "Rin - Tantei High")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Rin from the book Tantei High.");
                    }
                    Console.WriteLine();
                    //book4
                    string SWIAG = "I will make sure that nothing can harm you now. Just stay with me and not even death can touch you.";
                    string snow;
                    Console.Write("I will make sure that nothing can harm you now. Just stay with me and not even death can touch you.: ");
                    Speak(SWIAG);
                    snow = Console.ReadLine();
                    if (snow == "Sebastian Freniere - Snow White is a Gangster")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (snow == "Sebastian - Snow White is a Gangster")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (snow == "Ian - Snow White is a Gangster")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (snow == "Ian Freniere - Snow White is a Gangster")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Sebastian Freniere from the book Snow White is a Gangster.");
                    }
                    Console.WriteLine();
                    //book5
                    string DSU = "I promise you a life better than the movies and a love better than a fiction.";
                    string dagger;
                    Console.Write("I promise you a life better than the movies and a love better than a fiction.: ");
                    Speak(DSU);
                    dagger = Console.ReadLine();
                    if (dagger == "Thorn Dawson - Unwritten")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }    
                    else if (dagger == "Thorn - Unwritten")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Thorn Dawson from the book Unwritten.");
                    }
                    Console.WriteLine();
                    //book6
                    string OMIG = "The day we lead this nation was the day we discarded our own lives. There's no family to consider but only the nation and its people.";
                    string ice;
                    Console.Write("The day we lead this nation was the day we discarded our own lives. There's no family to consider but only the nation and its people.: ");
                    Speak(OMIG);
                    ice = Console.ReadLine();
                    if (ice == "Ark - Oh My Ice Goddess")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Ark from the book Oh My Ice Goddess.");
                    }
                    Console.WriteLine();
                    //book7
                    string MA = "Live today, fight tomorrow?";
                    string mhorfell;
                    Console.Write("Live today, fight tomorrow.: ");
                    Speak(MA);
                    mhorfell = Console.ReadLine();
                    if (mhorfell == "Skyzzer Yuan Cromello Sanchez - Mhorfell Academy of Gangsters")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (mhorfell == "Skyzzer Yuan Sanchez - Mhorfell Academy of Gangsters")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (mhorfell == "Sky Yuan Sanchez - Mhorfell Academy of Gangsters")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (mhorfell == "Sky Sanchez - Mhorfell Academy of Gangsters")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (mhorfell == "Skyzzer Sanchez - Mhorfell Academy of Gangsters")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Skyzzer Yuan Cromello Sanchez from the book Mhorfell Academy of Gangsters.");
                    }
                    Console.WriteLine();
                    //book8
                    string pricked = "My spinning wheel didn't plan to make me fall inyo a deep sleep, but to awaken me in the bittersweet reality of love.";
                    string wheel;
                    Console.Write("My spinning wheel didn't plan to make me fall inyo a deep sleep, but to awaken me in the bittersweet reality of love.: ");
                    Speak(pricked);
                    wheel = Console.ReadLine();
                    if (wheel == "Euphiemia Soren - The Prince Who Pricked His Finger on the Spindle of a Spinning Wheel")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (wheel == "Euphie Soren - The Prince Who Pricked His Finger on the Spindle of a Spinning Wheel")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (wheel == "Euphie - The Prince Who Pricked His Finger on the Spindle of a Spinning Wheel")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (wheel == "Euphiemia - The Prince Who Pricked His Finger on the Spindle of a Spinning Wheel")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Euphiemia Soren from the book The Prince Who Pricked His Finger on the Spindle of a Spinning Wheel.");
                    }
                    Console.WriteLine();
                    //book9
                    string glass = "I never thought that a pair of glass shoes will be worth stealing. A very beautiful and immeasurable worth.";
                    string slippers;
                    Console.Write("I never thought that a pair of glass shoes will be worth stealing. A very beautiful and immeasurable worth.: ");
                    Speak(glass);
                    slippers = Console.ReadLine();
                    if (slippers == "Captain Rashido - The Prince Who Stole My Glass Slippers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (slippers == "Rashido - The Prince Who Stole My Glass Slippers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (slippers == "Rashid Amadeus Villegas - The Prince Who Stole My Glass Slippers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (slippers == "Rashid Amadeus - The Prince Who Stole My Glass Slippers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (slippers == "Rashido Amadeus Villegas - The Prince Who Stole My Glass Slippers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (slippers == "Cinderello - The Prince Who Stole My Glass Slippers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Rashid Amadeus Villegas from the book The Prince Who Stole My Glass Slippers.");
                    }
                    Console.WriteLine();
                    //book10
                    string HB = "I've seen everything that her eyes have been searching, I've heard everything that her ears have been wanting, and I've felt everything that her whole existence has been longing for.";
                    string bite;
                    Console.Write("I've seen everything that her eyes have been searching, I've heard everything that her ears have been wanting, and I've felt everything that her whole existence has been longing for.: ");
                    Speak(HB);
                    bite = Console.ReadLine();
                    if (bite == "Zen Lancelot Gazellian - Hidden Bite")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (bite == "Zen Lancelot - Hidden Bite")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (bite == "Zen Gazellian - Hidden Bite")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (bite == "Prince Zen Lancelot Gazellian - Hidden Bite")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Zen Lancelot from the book Hidden Bite.");
                    }
                    Console.WriteLine();//para may space
                    if (score >= 7)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 10");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 10");
                    }
                }//tapos ng action
                else if (Genre == "Adventure")
                {//start ng adventure
                    //book1
                    string sd = "Because I know that in those worlds, our souls would never meet. I can't be with you in any of those worlds; not in a land of rulers fueled by their lust for power, and definitely not in the sea of pirates where blood and crimes are the currency.";
                    string saudade;
                    Console.Write("Because I know that in those worlds, our souls would never meet. I can't be with you in any of those worlds; not in a land of rulers fueled by their lust for power, and definitely not in the sea of pirates where blood and crimes are the currency.: ");
                    Speak(sd);
                    saudade = Console.ReadLine();
                    if (saudade == "Threy Weston - Saudade")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (saudade == "The Skull - Saudade")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (saudade == "Remus Borja IX - Saudade")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (saudade == "Threy - Saudade")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Threy Weston from the book Saudade.");
                    }
                    Console.WriteLine();
                    //book2
                    string tost = "Our fate might be a little bit tangled, but you should always remember that in every twist our of fate, there's a certain road which is unbreakable; our bond.";
                    string tear;
                    Console.Write("Our fate might be a little bit tangled, but you should always remember that in every twist our of fate, there's a certain road which is unbreakable; our bond.: ");
                    Speak(tost);
                    tear = Console.ReadLine();
                    if (tear == "Dastan Lancelot Gazellian - Trail of a Single Tear")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (tear == "Dastan Lancelot - Trail of a Single Tear")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (tear == "Dastan Gazellian - Trail of a Single Tear")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (tear == "Kamahalan - Trail of a Single Tear")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Dastan Lancelot Gazellian from the book Trail of a Single Tear.");
                    }
                    Console.WriteLine();
                    //book3
                    string mistress = "My affection for you know no bounds, my lady.";
                    string flame;
                    Console.Write("My affection for you know no bounds, my lady.: ");
                    Speak(mistress);
                    flame = Console.ReadLine();
                    if (flame == "Hakkeran Adral - Mistress of Flame")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (flame == "Hakken Adral - Mistress of Flame")
                        {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (flame == "Hakken - Mistress of Flame")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (flame == "Hakkeran - Mistress of Flame")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Hakkeran Adral from the book Mistress of Flame.");
                    }
                    Console.WriteLine();
                    //book4
                    string JAM = "Sometimes, goodbye is a painful way to say I love you.";
                    string maybes;
                    Console.Write("Sometimes, goodbye is a painful way to say I love you.: ");
                    Speak(JAM);
                    maybes = Console.ReadLine();
                    if (maybes == "City Sandoval - Just Another Maybe")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (maybes == "City - Just Another Maybe")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was City Sandoval from the book Just Another Maybe.");
                    }
                    Console.WriteLine();
                    //book5
                    string MIB = "We made something in Baguio. Friendship, companionship, love, and a family we yearned for";
                    string baguio;
                    Console.Write("We made something in Baguio. Friendship, companionship, love, and a family we yearned for.: ");
                    Speak(MIB);
                    baguio = Console.ReadLine();
                    if (baguio == "Keanu Yves Tomihari - Made in Baguio")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (baguio == "Keanu Yves - Made in Baguio")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (baguio == "Keanu Tomihari - Made in Baguio")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (baguio == "Keanu - Made in Baguio")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was City Sandoval from the book Just Another Maybe.");
                    }
                    Console.WriteLine();
                    //book6
                    string TWS = "Being a father is not an easy task, and some men are pursuing parenthood through adoption or co-parenting.";
                    string wayward;
                    Console.Write("Being a father is not an easy task, and some men are pursuing parenthood through adoption or co-parenting.: ");
                    Speak(TWS);
                    wayward = Console.ReadLine();
                    if (wayward == "Gener Celizana - The Wayward Son")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (wayward == "Celizana - The Wayward Son")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (wayward == "Gener - The Wayward Son")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Gener Celizana from the book The Wayward Son.");
                    }
                    Console.WriteLine();
                    //book7
                    string RIP = "I perfectly knew that I was born to hearken the music he radiates, the rhapsodic melody he molds, and the harmonious words he sets free.";
                    string rhapsody;
                    Console.Write("I perfectly knew that I was born to hearken the music he radiates, the rhapsodic melody he molds, and the harmonious words he sets free.: ");
                    Speak(RIP);
                    rhapsody = Console.ReadLine();
                    if (rhapsody == "Natalia Alexandrine C. Dela Merced - Rhapsody in Pampanga")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (rhapsody == "Natalia Alexandrine Dela Merced - Rhapsody in Pampanga")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (rhapsody == "Natalia Alexandrine - Rhapsody in Pampanga")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (rhapsody == "Natalia Dela Merced - Rhapsody in Pampanga")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (rhapsody == "Alexandrine Dela Merced - Rhapsody in Pampanga")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Natalia Alexandrine Dela Merced from the book Rhapsody in Pampanga.");
                    }
                    Console.WriteLine();
                    //book8
                    string SWIP = "I'm kind of unique in my own way - just not his kind of wonder.";
                    string wonders;
                    Console.Write("I'm kind of unique in my own way - just not his kind of wonder.");
                    Speak(SWIP);
                    wonders = Console.ReadLine();
                    if (wonders == "Corentienne Majia Dimaranan - Seeking Wonders in Pampanga")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (wonders == "Cory Dimaranan - Seeking Wonders in Pampanga")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (wonders == "Corentienne Dimaranan - Seeking Wonders in Pampanga")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (wonders == "Cory Majia Dimaranan - Seeking Wonders in Pampanga")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Corentienne Majia Dimaranan from the book Seeking Wonders in Pampanga.");
                    }
                    Console.WriteLine();
                    //book9
                    string bitter = "I'm scared that she won't be like the mother I imagined or though she would be.";
                    string sweet;
                    Console.Write("I'm scared that she won't be like the mother I imagined or though she would be.: ");
                    Speak(bitter);
                    sweet = Console.ReadLine();
                    if (sweet == "Katherine Jesse Smith - Bittersweet Kiss in Batangas")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (sweet == "Kat Smith - Bittersweet Kiss in Batangas")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (sweet == "Katherine Smith - Bittersweet Kiss in Batangas")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (sweet == "Kat Jesse Smith - Bittersweet Kiss in Batangas")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Katherine Jesse Smith from the book Bittersweet Kiss in Batangas.");
                    }
                    Console.WriteLine();
                    //book10
                    string LL = "Seeing what happened to his parents, he was skeptical of the thought of 'true love'.";
                    string lanlist;
                    Console.Write("Seeing what happened to his parents, he was skeptical of the thought of 'true love'.: ");
                    Speak(LL);
                    lanlist = Console.ReadLine();
                    if (lanlist == "Zeo ALcante - Lana's List")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (lanlist == "Zeo - Lana's List")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (lanlist == "Mufasa - Lana's List")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Zeo Alcante from the book Lana's List.");
                    }
                    Console.WriteLine();
                    if (score >= 7)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 10");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 10");
                    }
                }//end ng adventure
                else if (Genre == "Drama")
                {//start ng drama
                    //book 1
                    string VOTHS = "Love is not all about happy endings and staying together. Sometimes, it is about those words left unsaid and bittersweet goodbyes.";
                    string Visions;
                    Console.Write("Love is not all about happy endings and staying together. Sometimes, it is about those words left unsaid and bittersweet goodbyes.: ");
                    Speak(VOTHS);
                    Visions = Console.ReadLine();
                    if (Visions == "Thylane Puertollano - Visions of the Sea")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (Visions == "Thylane - Visions of the Sea")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (Visions == "Thyl Puertollano - Visions of the Sea")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Thylane Puertollano from the book Visions of the Sea.");
                    }
                    Console.WriteLine();
                    //book2
                    string DOS = "For the first time in a long time, I was free. I was happy. She was the one who kept me going - my dosage of serotonin.";
                    string dosage;
                    Console.Write("For the first time in a long time, I was free.I was happy.She was the one who kept me going - my dosage of serotonin.: ");
                    Speak(DOS);
                    dosage = Console.ReadLine();
                    if (dosage == "Calix Dylan Fujimoto - Dosage of Serotonin")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (dosage == "Calix Dylan - Dosage of Serotonin")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (dosage == "Calix Fujimoto - Dosage of Serotonin")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (dosage == "Dylan Fujimoto - Dosage of Serotonin")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Calix Dylan Fujimoto from the book Dosage of Serotonin!");
                    }
                    Console.WriteLine();
                    //book3
                    string STIY = "When I was a kid, I thought that you'll be fine as long as you're happy. Now I'm on the path to adulthood, happiness bacame vague. It was something hard to get - because time can always take it away.";
                    string youth;
                    Console.Write("When I was a kid, I thought that you'll be fine as long as you're happy. Now I'm on the path to adulthood, happiness bacame vague. It was something hard to get - because time can always take it away.: ");
                    Speak(STIY);
                    youth = Console.ReadLine();
                    if (youth == "Blake Godini - So, This Is Youth")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (youth == "Blake - So, This Is Youth")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Blake Godini from the book So, This Is Youth");
                    }
                    Console.WriteLine();
                    //book4
                    string rew = "What's the use of this power if I can't even stop his death.";
                    string inde;
                    Console.Write("What's the use of this power if I can't even stop his death.: ");
                    Speak(rew);
                    inde = Console.ReadLine();
                    if (inde == "Nathalie Alejandrino - Rewind")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (inde == "Nathalie - Rewind")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (inde == "Nathalie Lazaro- Rewind")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (inde == "Rina Lazaro - Rewind")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (inde == "Naomi - Rewind")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Nathalie Alejandrino from the book Rewind.");
                    }
                    Console.WriteLine();
                    //book5
                    string saa = "Indeed life isn't easy, in fact life can be cruel and shitty.";
                    string stayaga;
                    Console.Write("Indeed life isn't easy, in fact life can be cruel and shitty.: ");
                    Speak(saa);
                    stayaga = Console.ReadLine();
                    if (stayaga == "Agatha Grace Tanya - Stay Awake, Agatha")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (stayaga == "Agatha Grace - Stay Awake, Agatha")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (stayaga == "Agatha Grace - Stay Awake, Agatha")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (stayaga == "Agatha - Stay Awake, Agatha")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Agatha Grace Tanya from the book Stay, Awake Agatha.");
                    }
                    Console.WriteLine();
                    //book6
                    string midst = "I though it would be hard for you to find a reason to leave me.";
                    string crowd;
                    Console.Write("I though it would be hard for you to find a reason to leave me.: ");
                    Speak(midst);
                    crowd = Console.ReadLine();
                    if (crowd == "Dior Kobe Gallardo - In The Midst of the Crowds")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (crowd == "Kobe Gallardo - In The Midst of the Crowds")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (crowd == "Dior Gallardo - In The Midst of the Crowds")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (crowd == "Dior Kobe - In The Midst of the Crowds")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Dior Kobe Gallardo from the book In The Midst of the Crowds.");
                    }
                    Console.WriteLine();
                    //book7
                    string mistakes = "You don't realize how lucky you are just to be loved like that.";
                    string laugh;
                    Console.Write("You don't realize how lucky you are just to be loved like that.: ");
                    Speak(mistakes);
                    laugh = Console.ReadLine();
                    if (laugh == "Psyche - Mistakes We Can't Laugh About")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Psyche from the book Mistakes We Can't Laugh About.");
                    }
                    Console.WriteLine();
                    //book8
                    string htg = "It was like waves of memories came crashing back. How I almost failed a class trying to be there for him. How had to put a smile on my face trying to cheer him up. How I wanted to still be there to tell him that failing the BAR wasn't the end of the world - that he could take it again.";
                    string hate;
                    Console.Write("It was like waves of memories came crashing back. How I almost failed a class trying to be there for him. How had to put a smile on my face trying to cheer him up. How I wanted to still be there to tell him that failing the BAR wasn't the end of the world - that he could take it again.: ");
                    Speak(htg);
                    hate = Console.ReadLine();
                    if (hate == "Adriadna Deanne Manjarrez - Hate The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (hate == "Deanne Manjarrez - Hate The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (hate == "Deanne - Hate The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (hate == "D - Hate The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Adriadna Deanne Manjarrez from the book Hate The Game.");
                    }
                    Console.WriteLine();
                    //book9
                    string ilwtg = "When will you learn how to argue without getting emotional?";
                    string inlobe;
                    Console.Write("When will you learn how to argue without getting emotional?: ");
                    Speak(ilwtg);
                    inlobe = Console.ReadLine();
                    if (inlobe == "Atty. Ysmael Gomez de Liaño - In Love With The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (inlobe == "Ysmael Gomez de Liaño - In Love With The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (inlobe == "Ysmael GDL - In Love With The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (inlobe == "Yago Gomez de Liaño - In Love With The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (inlobe == "Yago GDL - In Love With The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Ysmael Gomez de Liaño from the book In Love With The Game.");
                    }
                    Console.WriteLine();
                    //book10
                    string ptg = "Don't give up on me, okay? I promise I'll work harder to give you the life you deserve.";
                    string putla;
                    Console.Write("Don't give up on me, okay? I promise I'll work harder to give you the life you deserve.: ");
                    Speak(ptg);
                    putla = Console.ReadLine();
                    if (putla == "Atty. Juan Alexandro Yuchengco - Play The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (putla == "Juan Alexandro Yuchengco - Play The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (putla == "Jax Yuchengco - Play The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (putla == "Atty. Jax Yuchengco - Play The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (putla == "Juan Alexandro - Play The Game")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Juan Alexandro Yuchengco from the book Play The Game.");
                    }
                    Console.WriteLine();
                    if (score >= 7)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 10");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 10");
                    }
                }//end ng drama
                else if (Genre == "Fantasy")
                {//start ng fantasy
                    //book1
                    string Fallen;
                    Console.Write("It's humility that makes men as angels. It was pride that turned angles into devils.: ");
                    Fallen = Console.ReadLine();
                    if (Fallen == "Lucinda Price - Fallen")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (Fallen == "Luce Price - Fallen")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (Fallen == "Luce - Fallen")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (Fallen == "Lucinda - Fallen")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Lucinda Price from the book Fallen");
                    }
                    Console.WriteLine();
                    //book2
                    string live = "I don't know why, but I am hurting.";
                    string blood;
                    Console.Write("I don't know why, but I am hurting.: ");
                    Speak(live);
                    blood = Console.ReadLine();
                    if (blood == "Laura Arden - Living with a Half Blood")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (blood == "Laura - Living with a Half Blood")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (blood == "Laura Van Zanth - Living with a Half Blood")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Laura Arden from the book Living with a Half Blood");
                    }
                    Console.WriteLine();
                    //book3
                    string NBT = "If you can't control the people below you, time will come when they will pull you down to take themselves up.";
                    string tamed;
                    Console.Write("If you can't control the people below you, time will come when they will pull you down to take themselves up.");
                    Speak(NBT);
                    tamed = Console.ReadLine();
                    if (tamed == "Mr. Wicke - Never Be Tamed")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (tamed == "Wicke - Never Be Tamed")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Mr. Wicke from the book Never Be Tamed");
                    }
                    Console.WriteLine();
                    //book4
                    string TJIAG = "Now I understand how it feels - how the saddest goodbyes are the ones never said.";
                    string ghost;
                    Console.Write("Now I understand how it feels - how the saddest goodbyes are the ones never said.: ");
                    Speak(TJIAG);
                    ghost = Console.ReadLine();
                    if (ghost == "Delia Salazar - The Jerk is a Ghost")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (ghost == "Delia - The Jerk is a Ghost")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (ghost == "Deels Salazar - The Jerk is a Ghost")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (ghost == "Deels - The Jerk is a Ghost")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Delia Salazar from the book The Jerk is a Ghost");
                    }
                    Console.WriteLine();
                    //book5
                    string OA = "You do not need to chase true love. It finds you, when you're ready.";
                    string olymp;
                    Console.Write("You do not need to chase true love. It finds you, when you're ready.: ");
                    Speak(OA);
                    olymp = Console.ReadLine();
                    if (olymp == "Abigail Young - Olympus Academy")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (olymp == "Abigail - Olympus Academy") 
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (olymp == "Abby Young - Olympus Academy")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (olymp == "Cesia - Olympus Academy")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (olymp == "Daughter of Aphrodite - Olympus Academy")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (olymp == "Cesia, Daughter of Aphrodite - Olympus Academy")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Cesia from the book Olympus Academy.");
                    }
                    Console.WriteLine();
                    //book6
                    string secret = "The beauty of love and friendship can overcome boundaries that we can't even imagine.";
                    string nerd;
                    Console.Write("The beauty of love and friendship can overcome boundaries that we can't even imagine.: ");
                    Speak(secret);
                    nerd = Console.ReadLine();
                    if (nerd == "Shea Alysia Valdemore - That Nerd has a Secret")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (nerd == "Shea Alysia - That Nerd has a Secret")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (nerd == "Shea Valdemore - That Nerd has a Secret")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (nerd == "Alysia Valdemore - That Nerd has a Secret")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was She Alysia Valdemore from the book That Nerd has a Secret.");
                    }
                    Console.WriteLine();
                    //book7
                    string th = "You're too obsessed with death, do you actually want to die?";
                    string tame;
                    Console.Write("You're too obsessed with death, do you actually want to die?: ");
                    Speak(th);
                    tame = Console.ReadLine();
                    if (tame == "Delian Iverson - Taming Hades")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (tame == "Delian - Taming Hades")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (tame == "Apollo - Taming Hades")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Delian Iverson from the book Taming Hades.");
                    }
                    Console.WriteLine();
                    //book8
                    string voice = "All beasts have their own weakness and never in my wildest thoughts that mine will be a very beautiful woman with fangs.";
                    string howl;
                    Console.Write("All beasts have their own weakness and never in my wildest thoughts that mine will be a very beautiful woman with fangs.");
                    Speak(voice);
                    howl = Console.ReadLine();
                    if (howl == "Alpha Adam Ephraim Daverionne - His Howling Voice")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (howl == "Adam Ephraim Daverionne - His Howling Voice")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (howl == "Adam Ephraim - His Howling Voice")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (howl == "Adam Daverionne - His Howling Voice")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (howl == "Alpha Adam - His Howling Voice")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Adam Ephraim Daverionne from the book His Howling Voice.");
                    }
                    Console.WriteLine();
                    //book9
                    string white = "You're the sweetest curse that I am willing to embrace.";
                    string curse;
                    Console.Write("You're the sweetest curse that I am willing to embrace.: ");
                    Speak(white);
                    curse = Console.ReadLine();
                    if (curse == "Finn Lancelot Gazellain - The White Curse")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (curse == "Finn Lancelot - The White Curse")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (curse == "Finn Gazellian - The White Curse")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (curse == "Prince Finn Lancelot Gazellian - The White Curse")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Finn Lancelot Gazellian from the book The White Curse.");
                    }
                    Console.WriteLine();
                    //book10
                    string hiding = "Because running from someone you love is like running from your own shadow.";
                    string alpha;
                    Console.Write("Because running from someone you love is like running from your own shadow.: ");
                    Speak(hiding);
                    alpha = Console.ReadLine();
                    if (alpha == "Jordan Avianna Evangelista - Hiding from the Alpha")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (alpha == "Jordan Avianna - Hiding from the Alpha")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (alpha == "Avianna - Hiding from the Alpha")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (alpha == "Avianna Evangelista - Hiding from the Alpha")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Jordan Avianna Evangelista from the book Hiding from the Alpha.");
                    }
                    Console.WriteLine();
                    if (score >= 7)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 10");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 10");
                    }
                }//end ng fantasy
                else if (Genre == "General Fiction")
                {//start ng gen fic
                    //book1
                    string BND = "I love you with all the love the universe and outside the universe can hold. With all the love from the beginning of time to its end called forever.";
                    string nextdoor;
                    Console.Write("I love you with all the love the universe and outside the universe can hold. With all the love from the beginning of time to its end called forever.: ");
                    Speak(BND);
                    nextdoor = Console.ReadLine();
                    if (nextdoor == "Karl Dominguez - The Boy Next Door")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (nextdoor == "Karl - The Boy Next Door")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Karl Dominguez from the book The Boy Next Door.");
                    }
                    Console.WriteLine();
                    //book2
                    string TUD = "I can't give you up like you want me to.";
                    string ugly;
                    Console.Write("I can't give you up like you want me to.: ");
                    Speak(TUD);
                    ugly = Console.ReadLine();
                    if (ugly == "Sage Savellano - The Ugly Duckling")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (ugly == "Sage - The Ugly Duckling")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Sage Savellano from the book The Ugly Duckling.");
                    }
                    Console.WriteLine();
                    //book3
                    string JTB = "Why are you pushing the person who makes you happy just because you think the whole world won't approve?";
                    string benefits;
                    Console.Write("Why are you pushing the person who makes you happy just because you think the whole world won't approve?: ");
                    Speak(JTB);
                    benefits = Console.ReadLine();
                    if (benefits == "Shiloah Angelo Suarez - Just The Benefits")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (benefits == "Shiloah Suarez - Just The Benefits")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (benefits == "Shiloah Angelo - Just The Benefits")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (benefits == "Angelo Suarez - Just The Benefits")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Shiloah Angelo Suarez from the book Just The Benefits.");
                    }
                    Console.WriteLine();
                    //book4
                    string TLWOB = "roi I'm not sure what love was like back then, but I do know that's not the way you should love someone.";
                    string barriers;
                    Console.Write("roi I'm not sure what love was like back then, but I do know that's not the way you should love someone.: ");
                    Speak(TLWOB);
                    barriers = Console.ReadLine();
                    if (barriers == "Ian Coronel Esquivel - To Love Without Barriers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (barriers == "Ian Coronel - To Love Without Barriers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (barriers == "Ian Esquivel - To Love Without Barriers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (barriers == "Roi - To Love Without Barriers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (barriers == "Roi Esquivel - To Love Without Barriers")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Ian Coronel Esquivel from the book To Love Without Barriers.");
                    }
                    Console.WriteLine();
                    //book5
                    string FT = "You have to face this savage world with courage and hope.";
                    string tenacity;
                    Console.Write("You have to face this savage world with courage and hope.: ");
                    Speak(FT);
                    tenacity = Console.ReadLine();
                    if (tenacity == "Mooze Diego Montevinski - Firm Tenacity ")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (tenacity == "Mooze Diego - Firm Tenacity ")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (tenacity == "Diego Montevinski - Firm Tenacity ")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Mooze Diego Montevinski from the book Firm Tenacity.");
                    }
                    Console.WriteLine();
                    //book6
                    string eomb = "When you told me before that we should just be friends. I did not recognize that that was heartbreak I was experiencing. Even hearing your name was enough to put me in a bad mood.";
                    string eyes;
                    Console.Write("When you told me before that we should just be friends. I did not recognize that that was heartbreak I was experiencing. Even hearing your name was enough to put me in a bad mood.: ");
                    Speak(eomb);
                    eyes = Console.ReadLine();
                    if (eyes == "Karaminah Viel Trajano - Eyes On Me, Baby")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (eyes == "Karaminah Viel - Eyes On Me, Baby")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (eyes == "Karaminah Trajano - Eyes On Me, Baby")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (eyes == "Karaminah - Eyes On Me, Baby")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Karaminah Viel Trajano from the book Eyes On Me, Baby.");
                    }
                    Console.WriteLine();
                    //book7
                    string rtg = "That's why it was hard to let go, because I knew how much you loved me before. I was just hoping that somewhere inside you, you still had it in you. The love you had for me then. But I guess I was the only one holding on.";
                    string reclaim;
                    Console.Write("That's why it was hard to let go, because I knew how much you loved me before. I was just hoping that somewhere inside you, you still had it in you. The love you had for me then. But I guess I was the only one holding on.: ");
                    Speak(rtg);
                    reclaim = Console.ReadLine();
                    if (reclaim == "Sean Denver Cuesta - Reclaim The Game")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (reclaim == "Sean Denver - Reclaim The Game")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (reclaim == "Sean Cuesta - Reclaim The Game")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (reclaim == "Sean - Reclaim The Game")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Sean Denver Cuesta from the book Reclaim The Game.");
                    }
                    Console.WriteLine();
                    //book8
                    string jts = "If I fail to do it once, I'll fail to do it some other time again - until this becomes a cycle. Until it becomes our normal. Until me not following through my words becomes a habit.";
                    string ive;
                    Console.Write("If I fail to do it once, I'll fail to do it some other time again - until this becomes a cycle. Until it becomes our normal. Until me not following through my words becomes a habit.: ");
                    Speak(jts);
                    ive = Console.ReadLine();
                    if (ive == "Saint Iverson Gomez de Liaño - Just The Strings")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (ive == "Saint Gomez de Liaño - Just The Strings")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (ive == "Saint Iverson - Just The Strings")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (ive == "Saint Iverson GDL - Just The Strings")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (ive == "Saint GDL - Just The Strings")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Saint Iverson Gomez de Liaño from the book Just The Strings.");
                    }
                    Console.WriteLine();
                    //book9
                    string tfa = "I don't remember crying for a girl... or in front of a girl. But right now, I can't look straight on her eyes. Because I feel weak.";
                    string tofall;
                    Console.Write("I don't remember crying for a girl... or in front of a girl. But right now, I can't look straight on her eyes. Because I feel weak.: ");
                    Speak(tfa);
                    tofall = Console.ReadLine();
                    if (tofall == "Jossiah Travis Montefalco - To Fall Again")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (tofall == "Jossiah Montefalco - To Fall Again")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (tofall == "Joss Travis Montefalco - To Fall Again")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (tofall == "Joss Montefalco - To Fall Again")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Jossiah Travis Montefalco from the book To Fall Again.");
                    }
                    Console.WriteLine();
                    //book10
                    string sot = "If you are tired, then let me be our strength now. Please. We can't give this up.";
                    string sands;
                    Console.Write("If you are tired, then let me be our strength now. Please. We can't give this up.: ");
                    Speak(sot);
                    sands = Console.ReadLine();
                    if (sands == "Raoul Vesarius Riego - Sands of Time")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (sands == "Raoul Vesarius - Sands of Time")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (sands == "Rao Vesarius Riego - Sands of Time")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (sands == "Raj Vesarius Riego - Sands of Time")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (sands == "Raoul Riego - Sands of Time")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Raoul Vesarius Riego from the book Sands of Time.");
                    }
                    Console.WriteLine();
                    if (score >= 7)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 10");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 10");
                    }
                }//end ng gen fic
                else if (Genre == "Paranormal")
                {//start ng paranorm
                    //book1
                    string am = "There are different ways in which you can deal with your struggles in life.";
                    string another;
                    Console.Write("There are different ways in which you can deal with your struggles in life.: ");
                    Speak(am);
                    another = Console.ReadLine();
                    if (another == "Samara Haya Martinez - Another Samara")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (another == "Samara Haya - Another Samara")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (another == "Samara - Another Samara")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (another == "Haya - Another Samara")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (another == "Samara Martinez - Another Samara")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (another == "Haya Martinez - Another Samara")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Samara Haya Martinez from the book Another Samara.");
                    }
                    Console.WriteLine();
                    //book2
                    string ilya = "I want you to know me better, Ara.";
                    string ara;
                    Console.Write("I want you to know me better, Ara.");
                    Speak(ilya);
                    ara = Console.ReadLine();
                    if (ara == "Roli - I Love You, Ara")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Roli from the book I Love You, Ara.");
                    }
                    Console.WriteLine();
                    //book3
                    string gw = "Am I sure that I don't want to risk getting myself killed and leave you behind? Of course.";
                    string gen;
                    Console.Write("Am I sure that I don't want to risk getting myself killed and leave you behind? Of course.: ");
                    Speak(gw);
                    gen = Console.ReadLine();
                    if (gen == "General War - The General")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (gen == "War - The General")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was General War from the book The General.");
                    }
                    Console.WriteLine();
                    //book4
                    string mav = "Not all vampires are our mortal enemies.";
                    string mervamp;
                    Console.Write("Not all vampires are our mortal enemies.: ");
                    Speak(mav);
                    mervamp = Console.ReadLine();
                    if (mervamp == "Waverly Marie Fishwater - Mermaids and Vampires Who Love Them")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (mervamp == "Waverly Fishwater - Mermaids and Vampires Who Love Them")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (mervamp == "Waverly Marie - Mermaids and Vampires Who Love Them")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Waverly Marie Fishwater from the book Mermaids and Vampires Who Love Them.");
                    }
                    Console.WriteLine();
                    //book5
                    string trg = "All humans label unexplainable events as some form of temporary insanity - but I gave you my ring to prove that I was no trick of the mind.";
                    string raven;
                    Console.Write("All humans label unexplainable events as some form of temporary insanity - but I gave you my ring to prove that I was no trick of the mind.: ");
                    Speak(trg);
                    raven = Console.ReadLine();
                    if (raven == "Erik - The Raven Girl")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Erik from the book The Raven Girl.");
                    }
                    Console.WriteLine();
                    //book6
                    string tf = "Despite the loud noises still happening upstairs, I force myself to close my eyes as I cry silently to myself, wishing I was one of the happy women in the books I read about.";
                    string fem;
                    Console.Write("Despite the loud noises still happening upstairs, I force myself to close my eyes as I cry silently to myself, wishing I was one of the happy women in the books I read about.: ");
                    Speak(tf);
                    fem = Console.ReadLine();
                    if (raven == "Charlotte - The Female")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Charlotte from the book The Femle.");
                    }
                    Console.WriteLine();
                    //book7
                    string alp = "At a young age, I'd learned that life wasn't guaranteed and that anyone could be taken away at any moment. This had pushed me to live my life to the fullest. It had also made me fiercely independent, and my need for control had grown.";
                    string forone;
                    Console.Write("At a young age, I'd learned that life wasn't guaranteed and that anyone could be taken away at any moment. This had pushed me to live my life to the fullest. It had also made me fiercely independent, and my need for control had grown.");
                    Speak(alp);
                    forone = Console.ReadLine();
                    if (forone == "Scarlett Hayes - Alpha, Forever Book 1")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (forone == "Scarlett - Alpha, Forever Book 1")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Scarlett Hayes from the book Alpha, Forever Book 1.");
                    }
                    Console.WriteLine();
                    //book8
                    string tea = "A beautiful winter night has never looked so ugly.";
                    string exiled;
                    Console.Write("A beautiful winter night has never looked so ugly.: ");
                    Speak(tea);
                    exiled = Console.ReadLine();
                    if (exiled == "Adrienne Gage - The Exiled Alpha")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (exiled == "Adrienne - The Exiled Alpha")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Adrienne Gage from the book The Exiled Alpha.");
                    }
                    Console.WriteLine();
                    //book9
                    string cm = "I shouldn't have come here. But I had to find her, I had to know if it was true; I had to find my match.\r\nYou of all people should understan that. You fell for a human once.";
                    string cupii;
                    Console.Write("I shouldn't have come here. But I had to find her, I had to know if it was true; I had to find my match.\r\nYou of all people should understan that. You fell for a human once.: ");
                    Speak(cm);
                    cupii = Console.ReadLine();
                    if (cupii == "Cupid - Cupid's Match")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Cupid from the book Cupid's Match.");
                    }
                    Console.WriteLine();
                    //book10
                    string thoc = "He was the first person that scared me - sent shivers down my spine. Made me do things I never did.";
                    string hohow;
                    Console.Write("He was the first person that scared me - sent shivers down my spine. Made me do things I never did.: ");
                    Speak(thoc);
                    hohow = Console.ReadLine();
                    if (hohow == "Alpha Freya Ruth - The Howl of Claim")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (hohow == "Freya Ruth - The Howl of Claim")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (hohow == "Alpha Freya - The Howl of Claim")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Freya Ruth from the book The Howl of Claim.");
                    }
                    Console.WriteLine();
                    if (score >= 7)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 10");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 10");
                    }
                }//end ng paranorm
                else if (Genre == "Romance")
                {//start ng romance
                    //book1
                    string ATH = "I realized then that infedelity isn't really exclusive to men. Everyone can cheat. Even those who marry for love, their feelings eventually fade with time.";
                    string AgainsttheHeart;
                    Console.Write("I realized then that infedelity isn't really exclusive to men. Everyone can cheat. Even those who marry for love, their feelings eventually fade with time. :");
                    Speak(ATH);
                    AgainsttheHeart = Console.ReadLine();
                    if (AgainsttheHeart == "Chayo - Against the Heart")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (AgainsttheHeart == "Charlotta del Real - Against the Heart")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (AgainsttheHeart == "Chayo del Real - Against the Heart")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (AgainsttheHeart == "Charlotta - Against the Heart")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (AgainsttheHeart == "Charlotta Yvonna del Real - Against the Heart")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (AgainsttheHeart == "Yvonna del Real - Against the Heart")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Charlotta del Real from the book Against the Heart.");
                    }
                    Console.WriteLine();
                    //book2
                    string comake = "You don't force people to move on, same as you don't force people to eat when they're already full.";
                    string COMM;
                    Console.Write("You don't force people to move on, same as you don't force people to eat when they're already full.: ");
                    Speak(comake);
                    COMM = Console.ReadLine();
                    if (COMM == "Jasper Alexander Ybañez - Come On, Make Me")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (COMM == "Jasper Alexander - Come On, Make Me")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (COMM == "Jasper Ybañez - Come On, Make Me")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (COMM == "Alexander Ybañez - Come On, Make Me")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Jasper Alexander Ybañez from the book Come On, Make Me");
                    }
                    Console.WriteLine();
                    //book3
                    string sun = "But a lisk risk is what makes us all alive.";
                    string TSH;
                    Console.Write("But a lisk risk is what makes us all alive.: ");
                    Speak(sun);
                    TSH = Console.ReadLine();
                    if (TSH == "Snow Galvez - The Sun's Heartbeat")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (TSH == "Snow - The Sun's Heartbeat")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (TSH == "Nieves Solanna Galvez - The Sun's Heartbeat")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (TSH == "Nieves Solanna - The Sun's Heartbeat")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (TSH == "Snow Riego - The Sun's Heartbeat")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Amber Semilla from the book The Sun's Heartbeat!");
                    }
                    Console.WriteLine();
                    //book4
                    string LITD = "This kind of love. This kind of kindness and gentleness should be spread heavily in this cruel world.";
                    string dark;
                    Console.Write("This kind of love. This kind of kindness and gentleness should be spread heavily in this cruel world.: ");
                    Speak(LITD);
                    dark = Console.ReadLine();
                    if (dark == "Felici Riego - Love in the Dark")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (dark == "Felicia Valerio - Love in the Dark")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (dark == "Raia Felicia Valerio - Love in the Dark")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (dark == "Raia Felicia Valerio Riego - Love in the Dark")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (dark == "Raia Felicia - Love in the Dark")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Felicia Riego from the book Love in the Dark.");
                    }
                    Console.WriteLine();
                    //book5
                    string tosta = "How could you smile when you're hurting me so bad?";
                    string davcon;
                    Console.Write("How could you smile when you're hurting me so bad?: ");
                    Speak(tosta);
                    davcon = Console.ReadLine();
                    if (davcon == "Hendrix Richard Ty - To Stay")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (davcon == "Hendrix Ty - To Stay")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Hendrix Richard Ty from the book To Stay.");
                    }
                    Console.WriteLine();
                    //book6
                    string ttw = "I spent two months in a hospital with no one but a person I'm not familiar with";
                    string tamwav;
                    Console.Write("I spent two months in a hospital with no one but a person I'm not familiar with.: ");
                    Speak(ttw);
                    tamwav = Console.ReadLine();
                    if (tamwav == "Elora Chin Valencia - Taming The Waves")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (tamwav == "Elora Chin - Taming The Waves")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (tamwav == "Chin Valencia - Taming The Waves")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Elora Chin Valencia from the book Taming The Waves.");
                    }
                    Console.WriteLine();
                    //book7
                    string wotw = "You are both my family and my riches, Thraia.";
                    string whisper;
                    Console.Write("You are both my family and my riches, Thraia.: ");
                    Speak(wotw);
                    whisper = Console.ReadLine();
                    if (whisper == "Antonius Lienzo Mercadejas - Whispers of the Wind")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (whisper == "Ali Mercadejas - Whispers of the Wind")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Antonius Lienzo Mercadejas from the book Whispers of the Wind.");
                    }
                    Console.WriteLine();
                    //book8
                    string gty = "I have given so many peoples, expensive and rare gifts, but I've never have someone appreciate it this way.";
                    string softie;
                    Console.Write("I have given so many peoples, expensive and rare gifts, but I've never have someone appreciate it this way.: ");
                    Speak(gty);
                    softie = Console.ReadLine();
                    if (gty == "Crisanta Camila Alcazar - Getting To You")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (gty == "Crisanta Camila - Getting To You")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (gty == "Sancha Alcazar - Getting To You")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (gty == "Crisanta Alcazar - Getting To You")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Crisanta Camila Alcazar from the book Getting To You.");
                    }
                    Console.WriteLine();
                    //book9
                    string TBWY = "I'd rather have my heart this broken, than miss the chance to know you.";
                    string withyou;
                    Console.Write("I'd rather have my heart this broken, than miss the chance to know you.: ");
                    Speak(TBWY);
                    withyou = Console.ReadLine();
                    if (withyou == "Pierre Ty - To Be With You")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (withyou == "Pierre Angelo Ty - To Be With You")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (withyou == "Pierre Angelo Chongbian Ty - To Be With You")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (withyou == "Pierre Angelo - To Be With You")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Pierre Angelo Ty from the book To Be With You.");
                    }
                    Console.WriteLine();
                    //book10
                    string TD = "The way you look at me makes me want to hate myself too.";
                    string trou;
                    Console.Write("The way you look at me makes me want to hate myself too.: ");
                    Speak(TD);
                    trou = Console.ReadLine();
                    if (trou == "Agezho Ranchi Venxid - Trouvaille Discovery")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (trou == "Agezho Ranchi - Trouvaille Discovery")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (trou == "Agezho Venxid - Trouvaille Discovery")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (trou == "Agezho - Trouvaille Discovery")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Agezho Ranchi Venxid from the book Trouvaille Discovery.");
                    }
                    Console.WriteLine();
                    if (score >= 7)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 10");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 10");
                    }
                }//end ng romance
                else if (Genre == "Romantic Comedy")
                {//start ng romcom
                    //book1
                    string AMNSE = "I used you and the whole Section E knows it.";
                    string mutya;
                    Console.WriteLine("I used you and the whole Section E knows it.: ");
                    Speak(AMNSE);
                    mutya = Console.ReadLine();
                    if (mutya == "Mark Keifer Watson - Ang Mutya ng Section E")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (mutya == "Keifer Watson - Ang Mutya ng Section E")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (mutya == "Keifer - Ang Mutya ng Section E")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Mark Keifer Watson from the book Ang Mutya ng Section E.");
                    }
                    Console.WriteLine();
                    //book2
                    string MHIAMB = "And a lifetime could never be enough to show how much I love you.";
                    string mafia;
                    Console.Write("And a lifetime could never be enough to show how much I love you.");
                    Speak(MHIAMB);
                    mafia = Console.ReadLine();
                    if (mafia == "Ezekiel Roswell - My Husband is a Mafia Boss")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (mafia == "Engineer Ezekiel Roswell - My Husband is a Mafia Boss")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (mafia == "Zeke - My Husband is a Mafia Boss")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (mafia == "Zeke Roswell - My Husband is a Mafia Boss") 
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Ezekiel Roswell from the book My Husband is a Mafia Boss.");
                    }
                    Console.WriteLine();
                    //book3
                    string TWTM = "The funny thing is, the more I repeatedly affirm that to myself, the more my eyes want to bulge and pour all the tears I'm trying hard to suppress.";
                    string marry;
                    Console.Write("The funny thing is, the more I repeatedly affirm that to myself, the more my eyes want to bulge and pour all the tears I'm trying hard to suppress.");
                    Speak(TWTM);
                    marry = Console.ReadLine();
                    if (marry == "Thirdy - Thirdy Wants to Marry")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Thirdy from the book Thirdy Wants to Marry.");
                    }
                    Console.WriteLine();
                    //book4
                    string tmd = "I've made a lot of mistakes in my life. But marrying you was the best decision i ever made, and I wouldn't change it for the world.";
                    string daylight;
                    Console.Write("I've made a lot of mistakes in my life. But marrying you was the best decision i ever made, and I wouldn't change it for the world.: ");
                    Speak(tmd);
                    daylight = Console.ReadLine();
                    if (daylight == "Brent Esplana - Truly, Madly, Deeply")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (daylight == "Brent - Truly, Madly, Deeply")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Brent Esplana from the book Truly, Madly, Deeply.");
                    }
                    Console.WriteLine();
                    //book5
                    string stktvd = "Everything happens for a reason. I had always believed that saying. But right now, nothing was making sense anymore.";
                    string valen;
                    Console.Write("Everything happens for a reason. I had always believed that saying. But right now, nothing was making sense anymore.: ");
                    Speak(stktvd);
                    valen = Console.ReadLine();
                    if (valen == "Birthday Salvador - Someone to Kiss This Valentine's Day")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (valen == "B Salvador - Someone to Kiss This Valentine's Day")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Birthday Salvador from the book Someone to Kiss This Valentine's Day.");
                    }
                    Console.WriteLine();
                    if (score >= 3)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 5");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 5");
                    }
                }//end ng romcom
                else if (Genre == "Science Fiction")
                {//start ng scifi
                    //book1
                    string TPT = "People want to see their future because they believe that there are greater things set for the,. They dream big and expect something spectacular will happen.";
                    string peculiar;
                    Console.Write("People want to see their future because they believe that there are greater things set for the,. They dream big and expect something spectacular will happen.: ");
                    Speak(TPT);
                    peculiar = Console.ReadLine();
                    if (peculiar == "Jillianne Morie - The Peculiar's Tale")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (peculiar == "Jill Morie - The Peculiar's Tale")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (peculiar == "Jill - The Peculiar's Tale")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (peculiar == "Jillianne - The Peculiar's Tale")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (peculiar == "Morie - The Peculiar's Tale")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Jilliane Morie from the book The Peculiar's Tale.");
                    }
                    Console.WriteLine();
                    //book2
                    string TOS = "I love you, let the sky cross our paths again.";
                    string sky;
                    Console.Write("I love you, let the sky cross out paths again.: ");
                    Speak(TOS);
                    sky = Console.ReadLine();
                    if (sky == "Rylandrien Peter Armstrong - Taste of Sky")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sky == "Peter Armstrong - Taste of Sky")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sky == "Rylandrien Peter - Taste of Sky")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sky == "Pedro Armstrong - Taste of Sky")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sky == "Pedro - Taste of Sky")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sky == "Space Commander Rylandrien Peter Armstrong - Taste of Sky")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Rylandrien Peter Armstrong from the book Taste of Sky.");
                    }
                    Console.WriteLine();
                    //book3
                    string stand = "I know that sending off a friend is hard, even unbearable for some. But there are times that you have to.";
                    string sstill;
                    Console.Write("I know that sending off a friend is hard, even unbearable for some. But there are times that you have to.: ");
                    Speak(stand);
                    sstill = Console.ReadLine();
                    if (sstill == "Aaron Lopez - Standstill")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sstill == "Hideo - Standstill")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Aaron Lopez from the book Standstill.");
                    }
                    Console.WriteLine();
                    //book4
                    string cold = "I'll fight for my people and for our rightful home until hell freezes over.";
                    string winter;
                    Console.Write("I'll fight for my people and for our rightful home until hell freezes over.: ");
                    Speak(cold);
                    winter = Console.ReadLine();
                    if (winter == "Winter Alveria - Winter")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (winter == "Lady Winter - Winter")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Winter Alveria from the book Winter.");
                    }
                    Console.WriteLine();
                    //book5
                    string kk = "Keeping them alive is my job.";
                    string keep;
                    Console.Write("Keeping them alive is my job.: ");
                    Speak(kk);
                    keep = Console.ReadLine();
                    if (keep == "Naia - Keeper")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (keep == "Agent Naia - Keeper")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Naia from the book Keeper.");
                    }
                    Console.WriteLine();
                    //book6
                    string cd = "I know it isn't right, but secretly, I ended up caring about him.";
                    string stine;
                    Console.Write("I know it isn't right, but secretly, I ended up caring about him.: ");
                    Speak(cd);
                    stine = Console.ReadLine();
                    if (stine == "Michiko - Clandestine")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (stine == "Erika - Clandestine")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Michiko from the book Clandestine.");
                    }
                    Console.WriteLine();
                    //book7
                    string tsos = "How could I protect the people I swore to keep safe if I could not even look after myself.";
                    string spy;
                    Console.Write("How could I protect the people I swore to keep safe if I could not even look after myself.: ");
                    Speak(tsos);
                    spy = Console.ReadLine();
                    if (spy == "Cliff - The Science of Spying")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Cliff from the book The Science of Spying.");
                    }
                    Console.WriteLine();
                    //book8
                    string seventh = "She'll go through a lot of pain because of us so support her in every way that you can. Don't let her experience what we have gone through.";
                    string sense;
                    Console.Write("She'll go through a lot of pain because of us so support her in every way that you can. Don't let her experience what we have gone through.: ");
                    Speak(seventh);
                    sense = Console.ReadLine();
                    if (sense == "Rielle Miyamoto - Seventh Sense")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sense == "Akemi - Seventh Sense")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sense == "Rielle - Seventh Sense")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Rielle Miyamoto from the book Seventh Sense.");
                    }
                    Console.WriteLine();
                    //book9
                    string awwa = "Birthdays were supposed to be special days for people.";
                    string wakenn;
                    Console.Write("Birthdays were supposed to be special days for people.: ");
                    Speak(awwa);
                    wakenn = Console.ReadLine();
                    if (wakenn == "Victoria Stryzyga - Awakened")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (wakenn == "Victoria - Awakened")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Victoria Stryzyga from the book Awakened.");
                    }
                    Console.WriteLine();
                    //book10
                    string sihc = "Waiting for Kiana to recover was torture for me, the fear of losing her was always there.";
                    string skeletons;
                    Console.Write("Waiting for Kiana to recover was torture for me, the fear of losing her was always there.: ");
                    Speak(sihc);
                    skeletons = Console.ReadLine();
                    if (skeletons == "Maddieson Paredes - Skeletons in her Closet")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (skeletons == "Maddy - Skeletons in her Closet")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (skeletons == "Maddy Paredes - Skeletons in her Closet")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Maddieson Paredes from the book Skeletons in her Closet.");
                    }
                    Console.WriteLine();
                    if (score >= 7)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 10");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 10");
                    }
                }//end ng scifi
                else if (Genre == "Teen Fiction")
                {//start ng teenfic
                    //book1
                    string POF = "I wanna be someone who treasures you, rather than just a person who knows your worth but does nothing to keep it. If you were indeead a poetry, I wouldn't want to illiterate.";
                    string pursue;
                    Console.Write("I wanna be someone who treasures you, rather than just a person who knows your worth but does nothing to keep it. If you were indeead a poetry, I wouldn't want to illiterate.: ");
                    Speak(POF);
                    pursue = Console.ReadLine();
                    if (pursue == "Iscalade Jance Altreaano - Pursuing Our Freedom")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (pursue == "Iscalade - Pursuing Our Freedom") 
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (pursue == "Iscalade Altreano - Pursuing Our Freedom")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (pursue == "Jance Altreano - Pursuing Our Freedom")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Iscalade Jance Altreano from the book Pursuing Our Freedom!");
                    }
                    Console.WriteLine();
                    //book2
                    string GHA = "You know, I was glade when I met him. But I wasn't the best version of myself when he met me.";
                    string tention;
                    Console.Write("You know, I was glade when I met him. But I wasn't the best version of myself when he met me.");
                    Speak(GHA);
                    tention = Console.ReadLine();
                    if (tention == "Jillian Chen Cojuanco - Getting His Attention")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (tention == "Jillian Chen - Getting His Attention")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (tention == "Jillian - Getting His Attention")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (tention == "Chen - Getting His Attention")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (tention == "Jillian Cojuanco - Getting His Attention")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (tention == "Chen Cojuanco - Getting His Attention")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Jillian Chen Cojuanco from the book Getting His Attention.");
                    }
                    Console.WriteLine();
                    //book3
                    string btw = "I can't spend my forever with her, but she spent the rest of her life with me.";
                    string beneath;
                    Console.Write("I can't spend my forever with her, but she spent the rest of her life with me.: ");
                    Speak(btw);
                    beneath = Console.ReadLine();
                    if (beneath == "Zachary Ismael Javier - Beneath the Two")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (beneath == "Zach Ismael Javier - Beneath the Two")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (beneath == "Zachary Javier - Beneath the Two")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (beneath == "Zach Javier - Beneath the Two")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (beneath == "Zach Ismael - Beneath the Two")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (beneath == "Zachary Ismael - Beneath the Two")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Zachary Ismael Javier from the book Beneath the Two.");
                    }
                    Console.WriteLine();
                    //book4
                    string badboy = "It sucks how I still love her after everything she did.";
                    string breakup;
                    Console.Write("It sucks how I still love her after everything she did.: ");
                    Speak(badboy);
                    breakup = Console.ReadLine();
                    if (breakup == "Chance Lucas Sandoval - How to Break-up With The Bad Boy")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (breakup == "Chance Sandoval - How to Break-up With the Bad Boy")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (breakup == "Chance Lucas - How to Break-up With The Bad Boy")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (breakup == "Lucas Sandoval - How to Break-up With The Bad Boy")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Chance Lucas Sandoval from the book How to Break-up With The Bad Boy.");
                    }
                    Console.WriteLine();
                    //book5
                    string TTW = "I regret loving you. I hope you always remember that.";
                    string waves;
                    Console.Write("I regret loving you. I hope you always remember that.: ");
                    Speak(TTW);
                    waves = Console.ReadLine();
                    if (waves == "Troy Jefferson Dela Paz - Taming the Waves")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (waves == "Troy Jefferson - Taming the Waves")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (waves == "Troy Dela Paz - Taming the Waves")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (waves == "Troy - Taming the Waves")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Troy Jefferson Dela Paz from the book Taming The Waves.");
                    }
                    Console.WriteLine();
                    //book6
                    string something = "Adulthood is hard, and we were just starting. But the experiences that shape you as you grow up, the people you build yourself with, are the best foundation you'll ever had.";
                    string spectacular;
                    Console.Write("Adulthood is hard, and we were just starting. But the experiences that shape you as you grow up, the people you build yourself with, are the best foundation you'll ever had.: ");
                    Speak(something);
                    spectacular = Console.ReadLine();
                    if (spectacular == "Isabelle Dizon - Something Spectacular")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (spectacular == "Isabelle - Something Spectacular")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Isabelle Dizon from the book Something Spectacular");
                    }
                    Console.WriteLine();
                    //book7
                    string until = "Love is war. I am your soldier.";
                    string trilo;
                    Console.Write("Love is war. I am your soldier.: ");
                    Speak(until);
                    trilo = Console.ReadLine();
                    if (trilo == "Elijah Riley Montefalco - Until He Returned")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (trilo == "Elijah Montefalco - Until He Returned")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (trilo == "Elijah Riley - Until He Returned")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (trilo == "Elijah - Until He Returned")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Elijah Riley Montefalco from the book Until He Returned");
                    }
                    Console.WriteLine();
                    //book8
                    string poison = "Always remember that the flower of friendship will not just bloom in lights, it can also bloom in dark.";
                    string apple;
                    Console.Write("Always remember that the flower of friendship will not just bloom in lights, it can also bloom in dark.: ");
                    Speak(poison);
                    apple = Console.ReadLine();
                    if (apple == "Alcer Arellano - The Prince Who Bit The Poisonous Apple")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (apple == "Don Alcer Arellano - The Prince Who Bit The Poisonous Apple")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Alcer Arellano from the book The Prince Who Bit The Poisonous Apple.");
                    }
                    Console.WriteLine();
                    //book9
                    string sm = "But in the process of intensely loving her, she drowned and got tired of me.";
                    string snow;
                    Console.Write("But in the process of intensely loving her... she drowned and got tired of me.: ");
                    Speak(sm);
                    snow = Console.ReadLine();
                    if (snow == "Keaton Samonte - The Prince Who Built the Snowman")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (snow == "Keaton - The Prince Who Built the Snowman")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (snow == "Samonteng Lamig - The Prince Who Built the Snowman")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Keaton Samonte from the book The Prince Who Built the Snowman.");
                    }
                    Console.WriteLine();
                    //book10
                    string iof = "I'm the fire that will burn you to ashes.";
                    string island;
                    Console.Write("I'm the fire that will burn you to ashes.: ");
                    Speak(iof);
                    island = Console.ReadLine();
                    if (island == "Zariyah Isla Leviste - Island of Fire")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (island == "Zariyah Isla - Island of Fire")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (island == "Zari Leviste - Island of Fire")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (island == "Zariyah Leviste - Island of Fire")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Zariyah Isla Leviste from the book Island of Fire.");
                    }
                    Console.WriteLine();
                    if (score >= 7)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 10");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 10");
                    }
                }//end ng teen fic
                else if (Genre == "Thriller")
                {//start ng thrill
                    //book1
                    string HU = "As long as I am breathing you are safe.";
                    string hell;
                    Console.WriteLine("As long as I am breathing you are safe.: ");
                    Speak(HU);
                    hell = Console.ReadLine();
                    if (hell == "Ace Craige - Hell University")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (hell == "Supremo - Hell University")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (hell == "Ace - Hell University")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (hell == "Highest Supreme Student Government - Hell University")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Ace Craige from the book Hell University.");
                    }
                    Console.WriteLine();
                    //book2
                    string PL = "If it's you, maybe we can make it work";
                    string project;
                    Console.Write("If it's you, maybe we can make it work.");
                    Speak(PL);
                    project = Console.ReadLine();
                    if (project == "Loki Mendez - Project Loki")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (project == "Loki - Project Loki")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Loki Mendez from the book Project Loki.");
                    }
                    Console.WriteLine();
                    //book3
                    string qu = "It takes courage to step into darkness, to prepare for uncertainty and to face for the unknown.";
                    string qed;
                    Console.Write("It takes courage to step into darkness, to prepare for uncertainty and to face for the unknown.: ");
                    Speak(qu);
                    qed = Console.ReadLine();
                    if (qed == "Morrie Moreno - QED University")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (qed == "Morrie - QED University")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Morrie Moreno from the book QED University.");
                    }
                    Console.WriteLine();
                    //book4
                    string cl = "Unlike you and father, I am not worthy because I am powerless.";
                    string aimed;
                    Console.Write("Unlike you and father, I am not worthy because I am powerless.: ");
                    Speak(cl);
                    aimed = Console.ReadLine();
                    if (aimed == "Zaria Stryzyga - Claimed")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (aimed == "Zaria - Claimed")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Zaria Stryzyga from the book Claimed.");
                    }
                    Console.WriteLine();
                    //book5
                    string pnd = "Blood will splatter on these floors, but this time, it won't be mine.";
                    string psycho;
                    Console.Write("Blood will splatter on these floors, but this time, it won't be mine.: ");
                    Speak(pnd);
                    psycho = Console.ReadLine();
                    if (psycho == "Kleya Hudson - Psycho Next Door")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (psycho == "Kleya - Psycho Next Door")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Kleya Hudson from the book Psycho Next Door.");
                    }
                    Console.WriteLine();
                    if (score >= 3)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 5");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 5");
                    }
                }//end ng thrill
                else if (Genre == "Young Adult")
                {//start ng young adu
                    //book1
                    string alen = "She has no memory of him, but he knows it's her. It's her soul reincarnated.";
                    string Fallen;
                    Console.Write("She has no memory of him, but he knows it's her. It's her soul reincarnated.: ");
                    Speak(alen);
                    Fallen = Console.ReadLine();
                    if (Fallen == "Daniel Grigori - Fallen")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (Fallen == "Daniel - Fallen")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Daniel Grigori from the book Fallen");
                    }
                    Console.WriteLine();
                    //book2
                    string TCOL = "I'm willing to help you. If your parents weren't there for you to understand you, then I will.";
                    string curse;
                    Console.Write("I'm willing to help you. If your parents weren't there for you to understand you, then I will.: ");
                    Speak(TCOL);
                    curse = Console.ReadLine();
                    if (curse == "Athaleigh Swishreigh - The Curse of Limerence")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (curse == "Athaleigh - The Curse of Limerence")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (curse == "Leigh Swishreigh - The Curse of Limerence")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (curse == "Athena - The Curse of Limerence")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Delian from the book The Curse of Limerence.");
                    }
                    Console.WriteLine();
                    //book3
                    string ak = "You'll always be inlove with me. No matter what happens, day by day your feelings for me will only go bitter and will not falter.";
                    string polo;
                    Console.Write("You'll always be inlove with me. No matter what happens, day by day your feelings for me will only go bitter and will not falter.: ");
                    Speak(ak);
                    polo = Console.ReadLine();
                    if (polo == "Apollo King - No More Apollo")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (polo == "Apollo - No More Apollo")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Apollo King from the book No More Apollo.");
                    }
                    Console.WriteLine();
                    //book4
                    string ph = "You'll never be ready to leave, to give it all up no matter how painful things are. Even though you feel like you're in a pit and couldn't move forward, you'll realize there's a lot more you have to know, to see, to experienpce.";
                    string phenom;
                    Console.Write("You'll never be ready to leave, to give it all up no matter how painful things are. Even though you feel like you're in a pit and couldn't move forward, you'll realize there's a lot more you have to know, to see, to experienpce.");
                    Speak(ph);
                    phenom = Console.ReadLine();
                    if (phenom == "Gabriela San Gabriel - Something Phenomenal")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (phenom == "Gabriel San Gabriel - Something Phenomenal")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (phenom == "Gabriel - Something Phenomenal")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (phenom == "Gab San Gabriel - Something Phenomenal")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (phenom == "Gab - Something Phenomenal")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Gabriela San Gabriel from the book Something Phenomenal.");
                    }
                    Console.WriteLine();
                    //book5
                    string lts = "The sky that I admired the most gave me nothing but thunderstorms and nimbus clouds.";
                    string sky;
                    Console.Write("The sky that I admired the most gave me nothing but thunderstorms and nimbus clouds.: ");
                    Speak(lts);
                    sky = Console.ReadLine();
                    if (sky == "Reese Deborah Madrid - Loving the Sky")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sky == "Reese Madrid - Loving the Sky")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sky == "Reese Deborah - Loving the Sky")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else if (sky == "Deborah Madrid - Loving the Sky")
                    {
                        Console.WriteLine("Correct");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Reese Deborah Madrid from the book Loving the Sky.");
                    }
                    Console.WriteLine();
                    //book6
                    string trails = "The pain is gone, just like the wind. I felt healed already when I met his eyes.";
                    string deceit;
                    Console.Write("The pain is gone, just like the wind. I felt healed already when I met his eyes.");
                    Speak(trails);
                    deceit = Console.ReadLine();
                    if (deceit == "Giovanna Chantria Asuncion - The Secluded Trails of Deceit")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (deceit == "Giovanna Chantria - The Secluded Trails of Deceit")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (deceit == "Chantria Asuncion - The Secluded Trails of Deceit")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Giovanna Chantria Asuncion from the book The Secluded Trails of Deceit.");
                    }
                    Console.WriteLine();
                    //book7
                    string hearts = "I was still young when they made me aware of the value of my responsibility. I thought that it was cool at first, as a young boy with a heart hungry for adventure, but as I grew up and understood a lot of things about life, I just realized that life was much better when you're free, less power, and influence.";
                    string trap;
                    Console.Write("I was still young when they made me aware of the value of my responsibility. I thought that it was cool at first, as a young boy with a heart hungry for adventure, but as I grew up and understood a lot of things about life, I just realized that life was much better when you're free, less power, and influence.: ");
                    Speak(hearts);
                    trap = Console.ReadLine();
                    if (trap == "Seiji Matsumoto - Trapped Hearts")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (trap == "Seiji - Trapped Hearts")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Seiji Matsumoto from the book Trapped Hearts.");
                    }
                    Console.WriteLine();
                    //book8
                    string ctg = "Growing up, I'd always been told that success is measured by diploma.";
                    string game;
                    Console.Write("Growing up, I'd always been told that success is measured by diploma.: ");
                    Speak(ctg);
                    game = Console.ReadLine();
                    if (game == "Charisse Faith Viste - Control the Game")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (game == "Charisse Faith - Control the Game")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (game == "Cha Faith Viste - Control the Game")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (game == "Cha - Control the Game")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (game == "Charisse Viste - Control the Game")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Charisse Faith Viste from the book Control the Game.");
                    }
                    Console.WriteLine();
                    //book9
                    string hnal = "Just when I though I got over from the ghost of the past, another person started haunting me.";
                    string lobe;
                    Console.Write("Just when I though I got over from the ghost of the past, another person started haunting me.: ");
                    Speak(hnal);
                    lobe = Console.ReadLine();
                    if (lobe == "Cayleigh Javier - Hello, Not Almost Lover")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (lobe == "Cayleigh - Hello, Not Almost Lover")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Cayleigh Javier from the book Hello, Not Almost Lover.");
                    }
                    Console.WriteLine();
                    //book10
                    string co = "I was just happily watching my ship sailing when suddenly, someone boarded the ship I was in.";
                    string cap;
                    Console.Write("I was just happily watching my ship sailing when suddenly, someone boarded the ship I was in.: ");
                    Speak(co);
                    cap = Console.ReadLine();
                    if (co == "Ianne Lorenzana - Hello, Co-Captain")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else if (co == "Ianne - Hello, Co-Captain")
                    {
                        Console.WriteLine("Correct!");
                        score = score + 1;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! It was Ianne Lorenzana from the book Hello, Co-Captain.");
                    }
                    Console.WriteLine();
                    if (score >= 7)
                    {
                        Console.WriteLine("Well done! Your score is " + score + " out of 10");
                    }
                    else
                    {
                        Console.WriteLine("Bummer. You only scored " + score + " out of 10");
                    }
                }//end ng young adu
                else
                {//end na kapag wala sa list yung genre
                    Console.WriteLine("Sorry, We currently don't have that kind of genre");
                }
                //dito pag wala sa list yung genre mapprint pa rin
                Console.WriteLine("-------------------------");
                Console.WriteLine("Bonus Question:");
                Console.Write("What was the line you cannot forget, and what book was it from?: ");


            }//tapos ng program
            else
            {//dapat dito tapos na din ang program
                Console.WriteLine("Aww too bad");
            }


            Console.ReadLine();
        }
    }
}
