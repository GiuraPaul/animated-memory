using System;
using System.ComponentModel.Design;

namespace UntitledTextGame
{
    class Program
    {
        static void Main(string[] args)
        {

          
                Console.WriteLine("A beautiful sunset is falling over the horizon and bathes the bloodied, ravaged lands that were once lush and filled with humans,\n" +
               " it embraces the world in a grim and tender embrace. You are walking through a dense forest without any idea of where you're headed,\n" +
               " your only hope leading being the discovery of a potential shelter, and soon.\n" +
               " The leaves make gentle cracking noises beneath your hurried steps as the sun continues its majestic descent and darkness settles in slowly.\n" +
               " Panic begins taking over you as you are unable to see any houses nearby, only the grim extent of a never-ending forest, almost as if it is mocking you, trying to pull you down.\n" +
               " You move on, however, refusing to give up in front of life's mischievous game, running as carefully as you can through the dense forest maze and grunting quietly with fear.\n" +
               " Although it felt hopeless, you are barely able make out the distinct shape of a house in the distance.\n" +
               " You start running as fast as you can and in less than a minute you find yourself in a large clearing, and just a couple dozen meters ahead lies your supposed salvation;\n" +
               " A large house that seemed mostly intact, as if it has never been touched by the wrathful hands of destruction.\n" +
               " You approach the house carefully, scrutinizing it as best as you can from your position.Eventually you reach the porch, standing a couple meters away from the front door, hesitating to enter.");

                Console.WriteLine();
                Console.WriteLine("You feel anxious, unsure if it is a good idea to enter the house,\n" +
                    " thinking that maybe you should move on and find another place. What do you do?");

                string expectedInput = Console.ReadLine();

                if (expectedInput == "go west")
                {
                    Console.WriteLine("You hesitate and at one point decide that it's best to stay out of the house, not knowing what might lie inside its walls.\n" +
                        " Backing away from the house, you sigh confusedly and start walking the other way, to the west, hoping to find a better suited safe-house for yourself.\n" +
                        " You wander into the pitch black field and pull your flashlight out, though it does not help you very much as you cannot cover too much ground with it.\n" +
                        " You hear faint snarling nearby and the grass shuffling out of sight. Your breathing becomes heavy and fear overwhelms you as you frantically shove your light around you\n" +
                        " in an attempt to find out what lurks in the darkness. You turn around over and over and around your last twist you find a rotting corpse lunging for you with its deteriorated arms and bony hands.\n" +
                        " In your defense you land a punch in the walker's face and send it stumbling to the ground, only for another one to lunge from behind and bite deeply into your neck,\n" +
                        " ripping a good chunk of flesh from your body. You shove it away from you and collapse on your knees in pain, grasping your wound and grunting painfully.\n" +
                        " As you tried to pull yourself together, another one lunges in to attack and succeeds in pinning you to the ground, taking a hefty bite out of your succulent flesh,\n" +
                        " digging its rotten, bony fingers into your body and ripping out more flesh as other walkers come out from the darkness, alongside the ones you tried fending off.\n" +
                        " They all lean over you and feast upon your flesh, leaving a messy, indescribably disgusting pile of half-eaten flesh and blood splattered upon the grass.");
                    Console.WriteLine();
                    Console.WriteLine("You have died.");
                }

                else if (expectedInput == "go house")
                {
                    Console.WriteLine("Your hesitation soon fades away and you try to remind yourself that this is your only hope of survival at this point, thus you approach the door and try the knob.\n" +
                        "The door does not open. You sigh disappointedly, letting go of the doorknob.\n" +
                        " Looking around, you realize that it's already dark so you try to carefully search around the house for a way inside,\n" +
                        " crouching down to avoid being spotted by whatever vicious creatures lurk in the dark depths of the night. You go to the back of the house and try the back door,\n" +
                        " it does not open either. You grunt in desperation and try it again, but you can immediately tell it won't budge.\n" +
                        " It's blocked from the other side, like the front door. You let go of the doorknob and try to think, then it occurs to you;\n" +
                        " you saw a window being slightly open. You go to it and pry it open, successfully making your way inside and shutting the window behind you.");
                    Console.WriteLine();
                    Console.WriteLine("As you made your clandestine entrance inside the home, you are unable to see a thing around you.\n" +
                        " It is almost pitch black inside, the only source of light being the moonshine that shone through the dirty windows.\n" +
                        " You wanted to turn on your flashlight but you ended up not doing so because you thought it might draw unwanted attention, and you were right about it.\n" +
                        " Faint groans were heard outside, a small number of walkers wandering around the clearing, passing by the house, unaware of your presence.\n" +
                        " You try to keep quiet as much as possible as you proceed deeper into the house, putting a tremendous amount of care in each step you took.\n" +
                        " Luckily for you, standing in the dark for this long has given you slightly better visibility in the dark, so now you could somewhat make out what was around you.");

                    Console.WriteLine();
                    Console.WriteLine("You carefully wander around in dark as you go from room to room, and you eventually come up at the front door and try to feel for the doorknob,\n" +
                        " but instead you feel a rather massive structure in front of you. Looking closer, you notice it is a large, heavy wooden wardrobe that was blocking the entrance.\n" +
                        " Looking back to the back door, you can hardly make out the shape of an object similar to the one you just saw, and you begin to realize that this house might have been attacked recently.\n" +
                        " Nonetheless, you decide it is better than nothing, so you continue exploring the ground floor, and doing so proves to be quite useful as you find a handful of wooden planks and\n" +
                        " other materials that you could use for fortifying the ground floor at least. You leave them where you found them for now and decide to go upstairs,\n" +
                        " hoping to find something that you could sleep on.");
                    Console.WriteLine("You sigh wearily, holding your head with one hand, feeling exhausted. As you reach the upper floor, you stop, staring dead at the wall as a distant voice is calling\n" +
                        " out to you, but you can't make out anything it says. You remain in this position for a minute until you regain consciousness, you shake your head and look around.");

                    Console.WriteLine();
                    Console.WriteLine("Your eyes catch a glimpse of two rooms in the darkness, one on the left and another to the right.\n" +
                        " They look like children's bedrooms. What do you do?");

                    string expectedInput2 = Console.ReadLine();

                    if (expectedInput2 == "go left")
                    {
                        Console.WriteLine("You ponder upon your decision as you make your way inside the room on the left, grabbing the doorknob firmly.\n" +
                            " Your hand turns and the lock clicks softly as the door opens with a slight squeak. You step inside and breathe out in relief; the room looks mostly intact,\n" +
                            " with a sturdy, comfortable-looking bed and a chair, a heavy-looking wardrobe, a mirror and a nightstand beside the bed. There is also a moderately-sized window near the bed,\n" +
                            " from which the moonlight shone through so brightly that you would almost forget the horrid predicament in which you find yourself in.\n" +
                            " The window doesn't look extremely sturdy but you think it will do until you get to fortifications.");
                        Console.WriteLine("The room looks like a girls' room, but you pay no attention that detail. You step forth and inspect the bed briefly before you sit down upon it\n" +
                            " and take off your stuffed backpack, putting it on the bed, just beside the pillow. Your body starts to feel heavy, your eyes slowly shutting themselves\n" +
                            " but you try to keep them open for a little while longer, as you prepare yourself for your much-needed rest. You look at the door and go to it sluggishly,\n" +
                            " closing it shut and locking it, but you also drag the nightstand and block the door with it for good measure, and then you go to the window.\n" +
                            " You look through it and see the wide clearing to the west, now teeming with vicious, rotten creatures that longed to devour your flesh.\n" +
                            " If you're lucky, they might not try to breach the house and you could have the night for yourself. You go ahead and lie down on the bed,\n" +
                            " equipping yourself with a powerful pistol as your defense during the night, and let exhaustion take over you and send you sleeping as quickly as you could've imagined.");
                        Console.WriteLine();
                        Console.WriteLine("You are sleeping soundly, sitting motionless in your bed as you feel a presence crawling closer and closer to you.\n" +
                            " A voice begins to whisper in your ear things that you cannot comprehend, and then suddenly it yells a hushed scream that sends you jolting out of your bed.\n" +
                            " You look around frantically but you cannot find anyone in the room. While you try to calm down, you hear distant voices yelling and gunfire outside.\n" +
                            " You go to inspect. As you approach the window, you immediately spot the bright lights of a vehicle that stationed nearby your house, in the clearing visible from your window.\n" +
                            " The vehicle itself looks like a van, no, more like a large armored vehicle that could transport a hefty amount of people, around 10 or so,\n" +
                            " and around it were a handful of people armed with assault rifles and military shotguns and pistols, weapons of all sorts.\n" +
                            " You feel anxious again, you fear that they have come to seize your hideout, that they would come and take everything away from you,\n" +
                            " like the festering infected have taken everything from you.");
                        Console.WriteLine();
                        Console.WriteLine("Fear overwhelms you. You back away from the window and collapse against the wall, quivering in terror. A visage flashes before your eyes,\n" +
                            " the image of a long forgotten person that you hardly remember, but know they meant the world to you. The voice you heard in your sleep returns with its shallow whispers,\n" +
                            " but this time you can make out what they are saying. \"KILL... THEM.. ALL!\" That is the only thing it whispers to you,\n" +
                            " its voice growing louder yet more silent at the same time, driving you insane slowly. ");
                        Console.WriteLine("Suddenly, you feel nothing. Your fear, terror, anxiety have faded in the blink of an eye and you can no longer tell if what happens around you.\n" +
                            " There is a moment of serenity surrounding you as you look up at the ceiling, a single tear sliding down your cheek and smashing against the wooden floor.");
                        Console.WriteLine("You stand up slowly, looking around you. You can still hear the yells and endless gunfire outside the house, fading away gradually.\n" +
                            " They seem to try to escape from the horde but they are surrounded by walkers. You begin feeling a strong urge to kill, your fists clench furiously without your control,\n" +
                            " your body becomes stiff as a statue until you make a step towards the window.");
                        Console.WriteLine();
                        Console.WriteLine("You try your best to hold back the rage but it feels unbearable to contain it. It is prying at unseen doors, trying to get out,\n" +
                            " begging you to let it become one with you. You have a choice.\n" +
                            " Will you resist, will you give in to the rage?");

                        string expectedInput1 = Console.ReadLine();

                        if (expectedInput1 == "resist")
                        {
                            Console.WriteLine("You become dizzy with every second that you try to resist the madness, you collapse to the ground. You wake up minutes later,\n" +
                                " your head is spinning painfully and your body feels numb. You feel like you managed to fight off the urge, but as you look out the window,\n" +
                                " you see the people from before being slaughtered mercilessly by the large horde of rotten corpses, feasting upon their lifeless bodies with the remaining survivors\n" +
                                " desperately trying to run away but ending up in the vicious claws of the undead. You suddenly feel an unrelenting rage and madness, you cannot resist anymore.\n" +
                                " You jump out the window, falling from the second story of the building but surviving without a scratch, apparently, dashing for the walkers\n" +
                                " and punching the brains out of the first one that you came upon. Then you rip the head off another, you stomp and kill another walker, then another,\n" +
                                " then another, over and over and over. You couldn't control yourself anymore, you went on a massive rampage with your bare hands,\n" +
                                " ripping and tearing the undead assailants to shreds like they were tissue paper. You would eventually lose consciousness and would 'wake up' to a gruesome sight;\n" +
                                " the entire clearing, stained with guts, blood and shredded rotten flesh and yourself... bathed in blood and guts.");
                            Console.WriteLine();
                            Console.WriteLine("You smile. A madman smile crawls upon your face, the kind of smile you would see on a mentally deranged person.\n" +
                                " You realize what happened, and you are at peace with it. You look around and spot the abandoned vehicle, and its previous owners now turned into messy meals for the dead.\n" +
                                " You failed to save them because of your hesitation, but you survived to become a monster of your own creation. Maybe you will use your madness to cleanse the land,\n" +
                                " but that will be up to you, if you can control it.");
                        }
                        else if (expectedInput1 == "give in")
                        {
                            Console.WriteLine("Your mind stops, and you can no longer resist. You give in to the enraging fury, and you shoot out of the window, landing right on your feet.\n" +
                                " Walkers notice you and make their approach on you, but you are prepared now. You grab the heads of two walkers coming close and smash them together,\n" +
                                " splashing their brains on the floor and a little blood on yourself, then you proceed to the others. You begin murdering any walkers that came too close to you;\n" +
                                " breaking necks, bones, bashing their skulls in, beating them until they died, all with your bare hands, and none of the walkers could touch you.\n" +
                                " You became a vicious machine of killing that those rotting cadavers could not break through any means. Your killings caught the attention of the nearby survivors,\n" +
                                " almost ready to shoot you but backing away upon seeing your fierce and relentless slaughter of undead. They stared fearfully as you kept tearing through the walkers\n" +
                                " with unnatural ease, breaking them in half and smashing their skulls in a few if not one powerful punch. Sooner than you could realize, you slaughtered them all,\n" +
                                " leaving only dirty, bloody remains of the horde all over the area. The survivors approach you and one of them steps forward, gazing at you steadily.\n" +
                                " It is a woman, seemingly in her 30s, with azure eyes and silky soft, brown hair. She stares at your blood-stained face and speaks softly, as if a little afeared of you.\n" +
                                " She tells you a genuine \"Thank you\" and looks down at the ground, but you slowly put your hand on her shoulder and motion her to raise her head.\n" +
                                " The others stand behind her, looking at you fearfully but they slowly come forth themselves and give their honest thanks for your help.");
                            Console.WriteLine();
                            Console.WriteLine("You gave in to your rage, you felt as if it was a mistake, but it ended up being the right choice at the right time.\n" +
                                " A minute later and you would have failed to save them.");
                            Console.WriteLine();
                            Console.WriteLine("You have become a vicious hero for these people. Perhaps they might consider joining forces with you against the endless hordes that roam the earth now.");
                        }
                    }

                   

                    else if (expectedInput2 == "go right")
                    {
                        Console.WriteLine("You are not sure what lies inside the room on the right, so you pull out your powerful survival knife and open the door slowly,\n" +
                            " a little squeak coming from its half-rusted hinges. You look inside and you sigh in relief that there is nothing there.\n" +
                            " Stepping inside, you notice the room is a little bit of a mess, with clothes scattered around the room and chairs collapsed on the floor messily.\n" +
                            " There is also a desk with a computer that is no longer functioning, a half-open closet, a big, slightly messy bed and a broken window near it.\n" +
                            " You think that these aren't the best conditions to sleep in but you cannot really choose these days, so you swallow your disappointment and lock yourself inside the room\n" +
                            " and start searching it carefully in case of any unwanted guests trying to kill you. You thoroughly search the room in the few minutes that you've allocated and find nothing,\n" +
                            " except a bunch of comfortable clothes and items that you might find useful along the way.");
                        Console.WriteLine("This room looks like a boys' room. Not very surprising to you that it's so messy, after all. You go to the window and look out,\n" +
                            " seeing the dense forest that surrounds your hideout expanding far into the darkness. Faint growls and snarls can be heard from outside, walkers are nearby\n" +
                            " but luckily unaware of you. You feel anxious but thankfully it does not last too long, knowing that you are safe for the time being.\n" +
                            " You approach the bed and put your things upon it, placing them near your pillow. For the night, you decide to take your trusty survival knife for protection,\n" +
                            " just in case something manages to sneak inside and tries to attack you. Your body begins feeling very heavy the moment you lie down on the bed,\n" +
                            " your eyes slowly but steadily closing under the weight of exhaustion. You succumb to it willingly, falling asleep quicker than you would have imagined.");
                        Console.WriteLine();
                        Console.WriteLine("You are sleeping soundly, sitting motionless in your bed as you feel a presence crawling closer and closer to you.\n" +
                            " A voice begins to whisper in your ear things that you cannot comprehend, and then suddenly it yells a hushed scream that sends you jolting out of your bed.\n" +
                            " You look around frantically but you cannot find anyone in the room. While you try to calm down, you hear distant voices yelling and gunfire outside. You go to inspect.\n" +
                            " You look out the window but you can't see anything expect the shallow silhouettes of walkers stumbling towards the sounds that are beginning to fill your head.\n" +
                            " Gunfire and yells are comind from somewhere around your house, somewhere from the west, where the clearing was but you have no visibility of it from your position.");
                        Console.WriteLine();
                        Console.WriteLine("Fear overwhelms you. You back away from the window and collapse against the wall, quivering in terror. A visage flashes before your eyes,\n" +
                            " the image of a long forgotten person that you hardly remember, but know they meant the world to you. The voice you heard in your sleep returns with its shallow whispers,\n" +
                            " but this time you can make out what they are saying. \"KILL... THEM.. ALL!\" That is the only thing it whispers to you,\n" +
                            " its voice growing louder yet more silent at the same time, driving you insane slowly.");
                        Console.WriteLine("Suddenly, you feel nothing. Your fear, terror, anxiety have faded in the blink of an eye and you can no longer tell if what happens around you.\n" +
                            " There is a moment of serenity surrounding you as you look up at the ceiling, a single tear sliding down your cheek and smashing against the wooden floor.");
                        Console.WriteLine("You stand up slowly, looking around you. You can still hear the yells and endless gunfire outside the house, fading away gradually.\n" +
                            " They seem to try to escape from the horde but they are surrounded by walkers. You begin feeling a strong urge to kill, your fists clench furiously without your control,\n" +
                            " your body becomes stiff as a statue until you make a step towards the window.");
                        Console.WriteLine();
                        Console.WriteLine("You try your best to hold back the rage but it feels unbearable to contain it. It is prying at unseen doors, trying to get out,\n" +
                            " begging you to let it become one with you. You have a choice.\n" +
                            " Will you resist, will you give in to the rage?");

                        string expectedInput3 = Console.ReadLine();

                        if (expectedInput3 == "resist")
                        {
                            Console.WriteLine("You become dizzy with every second that you try to resist the madness, you collapse to the ground. You wake up minutes later,\n" +
                                " your head is spinning painfully and your body feels numb. You feel like you managed to fight off the urge, but as you look out the window,\n" +
                                " you see the people from before being slaughtered mercilessly by the large horde of rotten corpses, feasting upon their lifeless bodies\n" +
                                " with the remaining survivors desperately trying to run away but ending up in the vicious claws of the undead. You suddenly feel an unrelenting rage and madness,\n" +
                                " you cannot resist anymore. You jump out the window, falling from the second story of the building but surviving without a scratch, apparently,\n" +
                                " dashing for the walkers and punching the brains out of the first one that you came upon. Then you rip the head off another, you stomp and kill another walker,\n" +
                                " then another, then another, over and over and over. You couldn't control yourself anymore, you went on a massive rampage with your bare hands,\n" +
                                " ripping and tearing the undead assailants to shreds like they were tissue paper. You would eventually lose consciousness and would 'wake up' to a gruesome sight;\n" +
                                " the entire clearing, stained with guts, blood and shredded rotten flesh and yourself... bathed in blood and guts.");
                            Console.WriteLine();
                            Console.WriteLine("You smile. A madman smile crawls upon your face, the kind of smile you would see on a mentally deranged person. You realize what happened,\n" +
                                " and you are at peace with it. You look around and spot the abandoned vehicle, and its previous owners now turned into messy meals for the dead.\n" +
                                " You failed to save them because of your hesitation, but you survived to become a monster of your own creation. Maybe you will use your madness to cleanse the land,\n" +
                                " but that will be up to you, if you can control it.");
                        }
                        else if (expectedInput3 == "give in")
                        {
                            Console.WriteLine("Your mind stops, and you can no longer resist. You give in to the enraging fury, and you shoot out of the window, landing right on your feet.\n" +
                                " Walkers notice you and make their approach on you, but you are prepared now. You grab the heads of two walkers coming close and smash them together,\n" +
                                " splashing their brains on the floor and a little blood on yourself, then you proceed to the others. You begin murdering any walkers that came too close to you;\n" +
                                " breaking necks, bones, bashing their skulls in, beating them until they died, all with your bare hands, and none of the walkers could touch you.\n" +
                                " You became a vicious machine of killing that those rotting cadavers could not break through any means. Your killings caught the attention of the nearby survivors,\n" +
                                " almost ready to shoot you but backing away upon seeing your fierce and relentless slaughter of undead. They stared fearfully as you kept tearing through the walkers\n" +
                                " with unnatural ease, breaking them in half and smashing their skulls in a few if not one powerful punch. Sooner than you could realize, you slaughtered them all,\n" +
                                " leaving only dirty, bloody remains of the horde all over the area.");
                            Console.WriteLine("The survivors approach you and one of them steps forward, gazing at you steadily. It is a woman, seemingly in her 30s, with azure eyes and silky soft, brown hair.\n" +
                                " She stares at your blood-stained face and speaks softly, as if a little afeared of you. She tells you a genuine \"Thank you\" and looks down at the ground,\n" +
                                " but you slowly put your hand on her shoulder and motion her to raise her head.\n" +
                                " The others stand behind her, looking at you fearfully but they slowly come forth themselves and give their honest thanks for your help.");
                            Console.WriteLine();
                            Console.WriteLine("You gave in to your rage, you felt as if it was a mistake, but it ended up being the right choice at the right time.\n" +
                                " A minute later and you would have failed to save them.");
                            Console.WriteLine();
                            Console.WriteLine("You have become a vicious hero for these people.\n" +
                                " Perhaps they might consider joining forces with you against the endless hordes that roam the earth now.");
                        }
                    }
                }

        }
    }
}
