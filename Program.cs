using System;
using System.Linq;

namespace AbstractInterfaceEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Battlelines are drawn at Cannae.***");
            
            Console.WriteLine("***The events that follow will be taught in military academies for millenia.***");
            
            Console.WriteLine("***Dust obscures visibility on the battlefield.***");

            Console.WriteLine("***On one side, Hannibal Barca fights for Carthage, leading a force of mercenaries from across the Western Mediterranean.***");

            Console.WriteLine("***Hannibal's forces stand at 49,500 strong.***");
            Console.WriteLine("***His forces are in an outward facing bow formation.***");

            //Skirmish line:
            Baleric_Slingers Carthaginian_Baleric_Slingers = new Baleric_Slingers("Carthaginian_Baleric_Slingers");
            Lusitanian_Skirmishers Carthaginian_Lusitanian_Skirmishers = new Lusitanian_Skirmishers("Carthaginian_Lusitanian_Skirmishers");
            //Front line in outward facing bow formation:
            Hero h1 = new Hero("Hannibal Barca");
            Iberian_Infantry Carthaginian_Iberian_Infantry = new Iberian_Infantry("Carthaginian_Iberian_Infantry");
            Gallic_Infantry Carthaginian_Gallic_Infantry = new Gallic_Infantry("Carthaginian_Gallic_Infantry");
            //Left flank:
            Gaetulian_Infantry Carthaginian_Gaetulian_Infantry = new Gaetulian_Infantry("Carthaginian_Gaetulian_Infantry");
            Gallic_Cavalry Carthaginian_Gallic_Cavalry = new Gallic_Cavalry("Carthaginian_Gallic_Cavalry");
            Iberian_Cavalry Carthaginian_Iberian_Cavalry = new Iberian_Cavalry("Carthaginian_Iberian_Cavalry");
            Libyan_Pheonecian_Cavalry Carthaginian_Libyan_Pheonecian_Cavalry = new Libyan_Pheonecian_Cavalry("Carthaginian_Libyan_Pheonecian_Cavalry");
            //Right flank:
            Lybian_Infantry Carthaginian_Lybian_Infantry = new Lybian_Infantry("Carthaginian_Lybian_Infantry");
            Numidian_Cavalry Carthaginian_Numidian_Cavalry = new Numidian_Cavalry("Carthaginian_Numidian_Cavalry");

            Console.WriteLine("***On the other side of the battlefield is the Roman army led by consuls Gaius Terentius Varro and Lucius Aemilius Paullus.***");

            Console.WriteLine("***Roman forces stand at 85,000 strong.***");

            //Skirmish line:
            Velites Roman_Velites = new Velites("Roman_Velites");
            //Front line:
            Hastatii Roman_Hastatii = new Hastatii("Roman_Hastatii");
            //Reserve line:
            Principes Roman_Principes = new Principes("Roman_Principes");
            //Vanguard:
            Triarii Roman_Triarii = new Triarii("Roman_Triarii");
            //Support:
            Socii_Infantry Roman_Socii_Infantry = new Socii_Infantry("Roman_Socii_Infantry");
            //Command:
            Hero h2 = new Hero("Gaius_Terentius_Varro");
            Hero h3 = new Hero("Lucius_Aemilius_Paullus");
            //Left flank:
            Socii_Cavalry Roman_Socii_Cavalry = new Socii_Cavalry("Roman_Socii_Cavalry");
            //Right flank:
            Equites Roman_Equites = new Equites("Roman_Equites");

            Console.WriteLine("***Hannibal's forces are outnumbered.***");

            Console.WriteLine("***The battle begins.***");
            Console.WriteLine("***The fate of the 'Western World' hangs in the balance.***");

            //Skirmishing phase:
            Console.WriteLine("***Skirmishers on both sides engage each other as the Roman heavy infantry advances on the Carthaginian front line.***");
            Roman_Velites.Attack(Carthaginian_Lusitanian_Skirmishers);
            Carthaginian_Baleric_Slingers.Attack(Roman_Velites);
            Roman_Velites.Attack(Carthaginian_Baleric_Slingers);
            Carthaginian_Lusitanian_Skirmishers.Attack(Roman_Velites);
            Console.WriteLine("***Skirmishers on both sides withdraw as the Roman heavy infantry advances on the Carthaginian front line.***");

            //Cavalry engagements on flanks:
            Console.WriteLine("***Cavalry on both sides engage on the flanks.***");
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Gallic_Cavalry.Attack(Roman_Equites);
                Carthaginian_Iberian_Cavalry.Attack(Roman_Equites);
            }, 5).ToList().ForEach(x => x());
            Carthaginian_Libyan_Pheonecian_Cavalry.Attack(Roman_Equites);
            Roman_Equites.Attack(Carthaginian_Gallic_Cavalry);
            Roman_Equites.Attack(Carthaginian_Iberian_Cavalry);
            Roman_Equites.Attack(Carthaginian_Libyan_Pheonecian_Cavalry);
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Gallic_Cavalry.Attack(Roman_Equites);
                Carthaginian_Iberian_Cavalry.Attack(Roman_Equites);
            }, 6).ToList().ForEach(x => x());
            Console.WriteLine("***Carthaginian cavalry on the left flank routes the Roman right flank cavalry.***");
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Numidian_Cavalry.Attack(Roman_Socii_Cavalry);
            }, 16).ToList().ForEach(x => x());
            Roman_Socii_Cavalry.Attack(Carthaginian_Numidian_Cavalry);
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Numidian_Cavalry.Attack(Roman_Socii_Cavalry);
            }, 17).ToList().ForEach(x => x());
            Console.WriteLine("***Roman left flank cavalry route before encirclement by encroaching Carthaginian cavalry.***");
            Console.WriteLine("***Carthaginian left flank cavalry chase fleeing Roman left flank cavalry from the battlefield.***");
            Console.WriteLine("***Carthaginian right flank cavalry close in on the Roman rear.***");

            //Infantry engagements:
            Console.WriteLine("***Roman heavy infantry engages Carthaginina front line.***");
            Enumerable.Repeat<Action>(() => 
            {
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Iberian_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Iberian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Socii_Infantry);

            }, 2).ToList().ForEach(x => x());
            Console.WriteLine("***Carthaginian front line continuously gives ground.***");
            Enumerable.Repeat<Action>(() => 
            {
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Iberian_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Iberian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Socii_Infantry);
            }, 2).ToList().ForEach(x => x());
            Console.WriteLine("***Roman infantry push further into Carthaginian front line in wedge formation.***");
            Enumerable.Repeat<Action>(() => 
            {
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Iberian_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Iberian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Socii_Infantry);
            }, 2).ToList().ForEach(x => x());

            //Encirclement of the Roman army:
            Console.WriteLine("***Carthaginian flanking infantry engage Roman infantry flanks in a pincer.***");
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Principes);
                Carthaginian_Lybian_Infantry.Attack(Roman_Principes);
                Carthaginian_Lybian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Socii_Infantry);
            }, 10).ToList().ForEach(x => x());
            Roman_Principes.Attack(Carthaginian_Gaetulian_Infantry);
            Carthaginian_Lybian_Infantry.Attack(Roman_Triarii);
            Roman_Principes.Attack(Carthaginian_Lybian_Infantry);
            Roman_Triarii.Attack(Carthaginian_Gaetulian_Infantry);
            Carthaginian_Gaetulian_Infantry.Attack(Roman_Triarii);
            Roman_Triarii.Attack(Carthaginian_Lybian_Infantry);
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Principes);
                Carthaginian_Lybian_Infantry.Attack(Roman_Principes);
                Carthaginian_Lybian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Socii_Infantry);
            }, 10).ToList().ForEach(x => x());
            Console.WriteLine("***Roman infantry push further into Carthaginian front line in wedge formation.***");
            Enumerable.Repeat<Action>(() => 
            {
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Iberian_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Iberian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Socii_Infantry);
            }, 2).ToList().ForEach(x => x());
            Console.WriteLine("***With the Romans pinned by a Carthaginian anvil, the Carthaginian right flank cavalry returns and hammers the Roman rear.***");
            Carthaginian_Numidian_Cavalry.Attack(Roman_Triarii);
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Numidian_Cavalry.Attack(Roman_Velites);
            }, 20).ToList().ForEach(x => x());
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Numidian_Cavalry.Attack(Roman_Principes);
            }, 20).ToList().ForEach(x => x());
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Numidian_Cavalry.Attack(Roman_Socii_Infantry);
            }, 20).ToList().ForEach(x => x());
            Console.WriteLine("***Encirclement of the Roman army is complete.***");
            Console.WriteLine("***The systematic slaughter of Roman forces proceeds until Hannibal achieves victory.***");
            Carthaginian_Lybian_Infantry.Attack(Roman_Triarii);
            Carthaginian_Gaetulian_Infantry.Attack(Roman_Triarii);
            Roman_Socii_Infantry.Attack(Carthaginian_Gaetulian_Infantry);
            Roman_Hastatii.Attack(Carthaginian_Iberian_Infantry);
            Roman_Principes.Attack(Carthaginian_Lybian_Infantry);
            Enumerable.Repeat<Action>(() => 
            {
                Roman_Hastatii.Attack(Carthaginian_Gallic_Infantry);
                Roman_Socii_Infantry.Attack(Carthaginian_Gallic_Infantry);
            }, 8).ToList().ForEach(x => x());
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Numidian_Cavalry.Attack(Roman_Velites);
                Carthaginian_Numidian_Cavalry.Attack(Roman_Principes);
                Carthaginian_Numidian_Cavalry.Attack(Roman_Socii_Infantry);
                Carthaginian_Lybian_Infantry.Attack(Roman_Velites);
                Carthaginian_Lybian_Infantry.Attack(Roman_Principes);
                Carthaginian_Lybian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Velites);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Principes);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Iberian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
            }, 21).ToList().ForEach(x => x());
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Numidian_Cavalry.Attack(Roman_Velites);
                Carthaginian_Numidian_Cavalry.Attack(Roman_Socii_Infantry);
                Carthaginian_Numidian_Cavalry.Attack(Roman_Hastatii);
                Carthaginian_Lybian_Infantry.Attack(Roman_Velites);
                Carthaginian_Lybian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Lybian_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Velites);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Gallic_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Iberian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
            }, 4).ToList().ForEach(x => x());
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Numidian_Cavalry.Attack(Roman_Socii_Infantry);
                Carthaginian_Numidian_Cavalry.Attack(Roman_Hastatii);
                Carthaginian_Lybian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Lybian_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Gallic_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Hastatii);
                Carthaginian_Iberian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Hastatii);
            }, 6).ToList().ForEach(x => x());
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Numidian_Cavalry.Attack(Roman_Socii_Infantry);
                Carthaginian_Lybian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Gallic_Infantry.Attack(Roman_Socii_Infantry);
                Carthaginian_Iberian_Infantry.Attack(Roman_Socii_Infantry);
            }, 6).ToList().ForEach(x => x());
            Carthaginian_Gallic_Infantry.Attack(Roman_Socii_Infantry);
            h1.Attack(h3);
            Console.WriteLine("***Roman Consul Gaius Terentius Varro escapes with nearly 4,500 soldiers. ***");
            Console.WriteLine("***10,000 Roman soldiers are captured by the Carthaginians.***");

            Console.WriteLine("***It would not be until World War One that this many people were killed in combat in a single day.***");

            //Alternate outcome:
            Console.WriteLine("*** ***Alternate outcome: *** ***");
            Console.WriteLine("*** Maharbal: 'You know how to win a victory, Hannibal, but you don't know how to use it.'***");
            Console.WriteLine("*** Hannibal: 'I will find a way, or make one.'***");
            Console.WriteLine("*** According to Theodore Ayrault Dodge, over 40,000 defenders wait in Rome, and hundreds of thousands of allies are ready to defend Rome. ***");

            Defenses Gates_of_Rome = new Defenses("Gates_of_Rome");
            City_Defenders Roman_City_Defenders = new City_Defenders("Roman_City_Defenders");

            Console.WriteLine("*** Carthaginian emissaries led by Mago Barca are sent to Rome's allies to promising them freedom from Roman tyranny if they do not attack Carthaginian forces, using the rings of Roman Senators as evidence of Rome's impending fall. ***");
            Console.WriteLine("*** By Baal Hammon's grace, and by comtempt for Roman rule that would have caused the Social Wars, Rome's allies wait to see what happens next. ***");
            Console.WriteLine("*** Carthaginian skirmishers and cavalry wait concealed in vegetation near the Tiber River outside of Rome. ***");
            Console.WriteLine("*** Carthaginian siege equipment is contructed and hidden in the trees amongst hiding skirmishers and cavalry. ***");
            Siege_Equipment Carthaginian_Siege_Equipment = new Siege_Equipment("Carthaginian_Siege_Equipment");
            Console.WriteLine("*** Carthaginian equipment is contructed to cross the Tiber River in the same manner as seen at Hannibal's crossing of the Rhone River. ***");
            Console.WriteLine("*** Carthaginian heavy infantry and slingers encircle Rome. ***");
            Console.WriteLine("*** Roman defenders numbering 50,000, concerned for a lack of aid from allies and growing desperate from loss of supplies, march on the Carthaginian forces. ***");
            Console.WriteLine("*** Carthaginian heavy infantry and slingers form a wedge formation along the Tiber river near hidden skirmishers, cavalry, and siege equipment. ***");
            Console.WriteLine("*** Roman defenders engage the Carthaginian infantry formation. ***");

            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Baleric_Slingers.Attack(Roman_City_Defenders);
                Roman_City_Defenders.Attack(Carthaginian_Lybian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Gaetulian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Gallic_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Iberian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Baleric_Slingers);
                Carthaginian_Lybian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Infantry.Attack(Roman_City_Defenders);
            }, 1).ToList().ForEach(x => x());

            Console.WriteLine("*** Carthaginian forces concealed in vegetation come out of hiding and hammer the Roman forces on the anvil of the Carthaginian formation. ***");

            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Lusitanian_Skirmishers.Attack(Roman_City_Defenders);
                Carthaginian_Numidian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Libyan_Pheonecian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Cavalry.Attack(Roman_City_Defenders);
            }, 1).ToList().ForEach(x => x());
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Lusitanian_Skirmishers.Attack(Roman_City_Defenders);
                Carthaginian_Numidian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Libyan_Pheonecian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Cavalry.Attack(Roman_City_Defenders);
                Roman_City_Defenders.Attack(Carthaginian_Lusitanian_Skirmishers);
                Roman_City_Defenders.Attack(Carthaginian_Numidian_Cavalry);
                Roman_City_Defenders.Attack(Carthaginian_Libyan_Pheonecian_Cavalry);
                Roman_City_Defenders.Attack(Carthaginian_Gallic_Cavalry);
                Roman_City_Defenders.Attack(Carthaginian_Iberian_Cavalry);
                Carthaginian_Lusitanian_Skirmishers.Attack(Roman_City_Defenders);
                Carthaginian_Numidian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Libyan_Pheonecian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Baleric_Slingers.Attack(Roman_City_Defenders);
                Carthaginian_Lybian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Infantry.Attack(Roman_City_Defenders);
                Roman_City_Defenders.Attack(Carthaginian_Lybian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Gaetulian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Gallic_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Iberian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Baleric_Slingers);
                Carthaginian_Baleric_Slingers.Attack(Roman_City_Defenders);
                Carthaginian_Lybian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Infantry.Attack(Roman_City_Defenders);
            }, 4).ToList().ForEach(x => x());
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Lusitanian_Skirmishers.Attack(Roman_City_Defenders);
                Carthaginian_Numidian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Cavalry.Attack(Roman_City_Defenders);
                Roman_City_Defenders.Attack(Carthaginian_Lusitanian_Skirmishers);
                Roman_City_Defenders.Attack(Carthaginian_Numidian_Cavalry);
                Roman_City_Defenders.Attack(Carthaginian_Gallic_Cavalry);
                Roman_City_Defenders.Attack(Carthaginian_Iberian_Cavalry);
                Carthaginian_Lusitanian_Skirmishers.Attack(Roman_City_Defenders);
                Carthaginian_Numidian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Baleric_Slingers.Attack(Roman_City_Defenders);
                Carthaginian_Lybian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Infantry.Attack(Roman_City_Defenders);
                Roman_City_Defenders.Attack(Carthaginian_Lybian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Gaetulian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Gallic_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Iberian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Baleric_Slingers);
                Carthaginian_Baleric_Slingers.Attack(Roman_City_Defenders);
                Carthaginian_Lybian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Infantry.Attack(Roman_City_Defenders);
            }, 13).ToList().ForEach(x => x());
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Lusitanian_Skirmishers.Attack(Roman_City_Defenders);
                Carthaginian_Numidian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Cavalry.Attack(Roman_City_Defenders);
                Roman_City_Defenders.Attack(Carthaginian_Lusitanian_Skirmishers);
                Roman_City_Defenders.Attack(Carthaginian_Numidian_Cavalry);
                Roman_City_Defenders.Attack(Carthaginian_Gallic_Cavalry);
                Roman_City_Defenders.Attack(Carthaginian_Iberian_Cavalry);
                Carthaginian_Lusitanian_Skirmishers.Attack(Roman_City_Defenders);
                Carthaginian_Numidian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Lybian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Infantry.Attack(Roman_City_Defenders);
                Roman_City_Defenders.Attack(Carthaginian_Lybian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Gaetulian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Gallic_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Iberian_Infantry);
                Carthaginian_Lybian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Infantry.Attack(Roman_City_Defenders);
            }, 2).ToList().ForEach(x => x());
            Enumerable.Repeat<Action>(() => 
            {
                Carthaginian_Lusitanian_Skirmishers.Attack(Roman_City_Defenders);
                Carthaginian_Numidian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Cavalry.Attack(Roman_City_Defenders);
                Roman_City_Defenders.Attack(Carthaginian_Lusitanian_Skirmishers);
                Roman_City_Defenders.Attack(Carthaginian_Numidian_Cavalry);
                Roman_City_Defenders.Attack(Carthaginian_Gallic_Cavalry);
                Carthaginian_Lusitanian_Skirmishers.Attack(Roman_City_Defenders);
                Carthaginian_Numidian_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Cavalry.Attack(Roman_City_Defenders);
                Carthaginian_Lybian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Infantry.Attack(Roman_City_Defenders);
                Roman_City_Defenders.Attack(Carthaginian_Lybian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Gaetulian_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Gallic_Infantry);
                Roman_City_Defenders.Attack(Carthaginian_Iberian_Infantry);
                Carthaginian_Lybian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gaetulian_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Gallic_Infantry.Attack(Roman_City_Defenders);
                Carthaginian_Iberian_Infantry.Attack(Roman_City_Defenders);
            }, 10).ToList().ForEach(x => x());
            Console.WriteLine("*** 130 Roman defenders are captured. ***");
            Console.WriteLine("*** Rome is encircled and sieged. ***");
            Enumerable.Repeat<Action>(() =>
            {
                Gates_of_Rome.Attack(Carthaginian_Siege_Equipment);
                Carthaginian_Siege_Equipment.Attack(Gates_of_Rome);
            }, 4).ToList().ForEach(x => x());
            Console.WriteLine("*** Carthaginian forces numbering 25,050 storm Rome. ***");
            Console.WriteLine("*** Rome burns. ***");
            Console.WriteLine("*** The fate of the 'Western World' has been sealed. ***");
        }
    }
}