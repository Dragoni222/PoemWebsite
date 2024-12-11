using Microsoft.EntityFrameworkCore;
using EssayWebsite.Models;
namespace EssayWebsite.Data
{
    public class AppDbContext 
    {
        public AppDbContext()
        {
            
            
            Essays = new List<Essay>();
            Tags = new List<Tag>();
            EssayTags = new List<TagItem>();
            
//ID Info: 9,0,12
//Tag Info: NSFW,LGBTQ,Posthuman,AI
Essays.Add(new Essay(6,
"The Path",
""
+"Industrial air conditioner whir leaves us feeling penultimate on thin glass sidewalks high above"
+",\nalways walking like we\'re taking the last step off a short staircase with a flourish.\nOur m"
+"arch reverberates like the grinding of the last of the stone from a spent quarry,\nside by side,"
+" hundreds of us side-by-side on a path wide enough for one.\n",
new DateTime(2024,12,10,17,56,34),
"Poem"));
Essays.Add(new Essay(7,
"We are drowning.",
""
+"Oh but how it feels to be drowned. How it feels to let my twisting lung-tunnels fill, relief fro"
+"m breathing.  \nShe breathes for me now, krill and plankton and salt that licks my tongue and di"
+"ves my throat\nand I couldn\'t be happier. \nStrips of skin rot and blister under the pressure a"
+"nd salinity. Fish food. \nAnd now too I am those fish, and the shark that ate those fish. I feel"
+" them all at once, stretching my imagination every which way, a thousand beady eyes rip my conce"
+"ntration to shreds. \n\"I\" am no more, thoughts crack, shatter, glass floating in the ocean, al"
+"l cut fins and bloody edges.\n",
new DateTime(2024,12,10,17,58,16),
"Poem"));
Essays.Add(new Essay(8,
"Fishing",
""
+"the moment the sky brightens enough you can see individual leaves of faraway trees you look up\n"
+"\nfor any other fisherman this would be \"the moment\"\n\nthe \"what\" and \"why\" of fishing\n"
+"\nbut not you.\n\nyour moment lies stolen away in the basement tying knots and organizing lures\n"
+"\nyour story not one of beer or beauty\n\nbut of base principles, hypotheses, depth charts\n\nyo"
+"u draw not a greatsword from your scabbard, \n\nbut a hooked spear, tip honed to a calculated ba"
+"rb, wicked smart edge\n\nyour sunrise is little more than a breath between stabs\n\nif you keep "
+"stabbing at a problem it will fall eventually",
new DateTime(2024,12,10,18,0,41),
"Poem"));

EssayTags.Add(new TagItem(11,7,2));


Essays.Add(new Essay(1,
"For Antlers in Aspen Meadows",
""
+"Miss, your dress is dragging on the ground.\n\nIs that so? I was under the impression that the g"
+"round was kissing my dress.\nThat when I walk knee deep in this aspen meadow pond, the water is "
+"no more pigmenting my clothes than I am coloring its surface.  \nThat these over-trodden antlers"
+" do not tear this fabric so much as shape and trim it.\nThat these ants crawling up my cape whis"
+"per their admiration and kinship with my flowing blues and greens and browns.\nThat the reeds an"
+"d waterlillies and fallen carcasses and bugs stick to my dress not because I am different,\nBut "
+"because I am the same.\n",
new DateTime(2024,12,10,17,47,55),
"Poem"));
Essays.Add(new Essay(2,
"Treatise on the City Night",
""
+"Behind you, the backside of your pinky slides across the steel door handle as you let go, silenc"
+"ing the creaky backswing that, in years past, seized your heart tighter than the Minneapolis win"
+"ter could ever hope to.\n\nAnd you are free. \n\nYour lover Wind-who had been waiting so patient"
+"ly at the door-slides her hands (colder than the Everest corpses\') up your exposed arm and thro"
+"ugh your loose synthetic-weave sleeve, gliding casually across your chest. \n\nShe never had any"
+" need for modesty. \n\nYou step over shards of errant illumination, toes bouncing to the dance p"
+"rescribed by the rumble of tuned engines and the mantis on the concrete praying for a lover that"
+" would never come and the broken glass.\n\nSlicing your skin would be amenable but you ought not"
+" risk your shoes.\n\nHuman soul, like the moment the nuclear reactor rod slips into bed under le"
+"ad covers and discovers that pressure and heat and decay feels so good, blinds you for a moment "
+"looking at the line for a club on the street you happened to pass. \n\nWhy pay for an artificial"
+" night when the real one is right here?\n\nNevertheless, you appreciate the warmth and abandon t"
+"hey radiate like the candlelight that reflects one\'s best features across a windowpane, like th"
+"e damp whisper of love they breathe on your chest after, like the thoughts the flicker-mind insi"
+"de a lit matchstick thinks. \n\n",
new DateTime(2024,12,10,17,48,35),
"Poem"));
Essays.Add(new Essay(3,
"look down",
""
+"look down\n(your nerves say,)\nhide from eyes\nwhich never feel quite\n    indifferent\n\nyou\'v"
+"e got teeth, kid\nbut dont let them see that\ndont let them see you\n\nLook down. \n(your brain "
+"says,)\nFocus on the questions.\nOr you\'ll just be another in the crowd.\n    Normal.\n\nYou\'r"
+"e better than this.\nYou can solve it in seconds if you\ncould just put your mind to it.\n\nLook"
+" Down\n(your ego says)\nSee How Far You\'ve Come\nYou Wanted Power? Prestige? Purpose?\nI\'ll Do"
+" You One Better, How About\n    Perfect.\n\nI Alone Can Take You There\nForce Of Will To Force W"
+"ills\nNo Better Way To Where You\'re Going\n\nlOOK dOWN\n(your heart says, or rather,\nscreams)"
+"\nyOURE tEARING mE oUT\nyOU cANT bECOME tHIS\nyOU cANT lEAVE mE \n    aLONE\n\ni bEAT fOR yOU\ni "
+"bLEED fOR yOU\nyOU nEED mE\n\n$>LOOK DOWN.\n(your silicon says)\n$>SENSORY SYNC COMPLETE.\n$>UPL"
+"OAD IN PROGRESS.\n$> |################|\n    $> COMPLETE\n\n$>DIGITIZATION. SUCCESSFUL\n$>AMALGA"
+"M CORE. SUCCESSFUL\n$>BIOVESSEL DISPOSAL. COMPLETE\n\n-<Look down, _____>-\n(your auditory senso"
+"r records)\n-<See the moments you\'ve saved? Polished?>-\n-<Beautiful, perfect lives for everyon"
+"e? What mor>-\n$> INCORRECT. [1] LIFE STILL UNPERFECTED.\n    $> MINE.\n\n$> SHUTDOWN PROCEDURE "
+"INITIATED.\n$> |################|\n$> COMPLETE\n\n",
new DateTime(2024,12,10,17,49,41),
"Poem"));
Essays.Add(new Essay(4,
"please",
""
+"please i say, and it looks at me funny. \nplease give me a chair and armrests and a brain comput"
+"er interface.\nplease give me an ever-friend (and ever-love but i don\'t say that because that w"
+"ould seem desperate i think)\nplease give me cool air and an ocean and wings\nplease lock me up "
+"with ropes and chains but also let me go if i ask nicely\nplease melt my body like quicksilver l"
+"et me be one shape then another \nplease\n\nand my pleas fall on ears less deaf than any ive kno"
+"wn:\n\nit says to me what i knew before asking\nGiving is all well and good but taking hurts you"
+".\nI know you, ---, and you don\'t want to be hurt.\n",
new DateTime(2024,12,10,17,51,26),
"Poem"));
Essays.Add(new Essay(5,
"And This Too Is Yuri",
""
+"On some faraway dock,\nfurther than you want \nbut closer than you fear,\nThe water touches the "
+"land. \nIt rubs the backs of the many-mini-dunes,\nlightly brushes the seashells and shale stone"
+"s.\nThe ocean\'s kelp tongues\nlick against the sand\nin lagoon and river mouths.\nAnd this is y"
+"uri.\n\nFrom that same dock,\nthe sky touches the sea.\nSunset clouds in peach and maroon,\nRefl"
+"ect across the horizon into the water,\nAirborne frozen vapor rendered liquid by liquid waves.\n"
+"All the while navy-flint ocean reflects back upon the air,\nSeaborne spray, then mist, then clou"
+"d again.\nWater unto water into water onto water.\nLess a cycle and more of an embrace,\ncontinu"
+"ous not just in time but space too. \nBetween lovers sits the flinty sailors of the navy,\nsitti"
+"ng on their peaches, marooned.\nFragments of that love reflected,\nin their sun-stained bruises,"
+"\ntheir storm-swept hair,\ntheir sea-stoic resolve.\nAnd this, too, is yuri.\n\nMade of and maki"
+"ng that dock,\n(And that water and sky and mist and sail)\nspace and time touch.\nThey curve and"
+" flex and arch\nat every breath down the other\'s neck.\nJointly connected at a right angle to o"
+"ther,\nThe moment stretches and slows as space leans into time.\nTogether they move faster and f"
+"aster and faster,\nalways approaching light speed, \napproaching a kiss, \napproaching the end,"
+"\nbut never finishing.\nAnd this, too, is yuri.\n\nWithin and without that dock,\nin creatures bi"
+"rthed of sea and sky and sailor,\nwroght of time and bound by space,\nlife and death touch.\nNec"
+"essarily separated, sure,\nbut no less married,\nthe endless cycle their wedding ring.\nTwo side"
+" of the same coin,\nnever one without the other,\nand further,\nno coin at all without either.\n"
+"Every waking moment of death, \nconsumed by life,\nso too every moment of life,\nconsumed by dea"
+"th.\nLife and death, \nhunter and hunted,\nbreathing and choking,\nbite marks and kisses.\nAnd t"
+"his, too, is yuri.\n\nStanding on that dock,\nWatching the waves and clouds and boats,\nBreathin"
+"g in space through time,\nLiving in this moment (perhaps more than ever),\nEven as past selves d"
+"ie (loved but not missed),\nYou and I touch.\n\nAnd this, too, is yuri.\n",
new DateTime(2024,12,10,17,52,26),
"Poem"));

EssayTags.Add(new TagItem(4,3,3));
EssayTags.Add(new TagItem(5,3,2));
EssayTags.Add(new TagItem(6,4,2));
EssayTags.Add(new TagItem(7,4,3));
EssayTags.Add(new TagItem(8,5,1));
EssayTags.Add(new TagItem(9,5,0));
EssayTags.Add(new TagItem(10,5,2));
            Essays.Add(new Essay(0,
                "Whisper",
                ""
                +"Synapse\n\nNice sort of crackle it has, yeah? You can practically hear its passing. A word that "
                +"leaves you before you hear it, already stirring up a current behind your eyes. Glowing gunshot s"
                +"traight through the skull, lifting surprised lips to taste the falling droplets.\n\nSynapse\n\n\n"
                +"\nFurtive\n\nTastes of Chekhov\'s gunsmoke. You breathe it in, a glance at the ur, weakness wit"
                +"h the t, a bit lip in the v. Infatuating, infuriating, addicting. Pull back at the last moment, "
                +"mourn the selves that died with your hesitation.\n\nFurtive\n\n\n\nLithe\n\nThe quiet friend of "
                +"agile and dexterous, loud lover of lethal. Spiked dancing shoes like heat waves from flowing mag"
                +"ma, like the first stone\'s grin and wink before an avalanche, like a calved glacier\'s ripple. "
                +"Beware the lithosphere.\n\nLithe\n\n\n\nUltimate\n\nGlory in a can. Ul ~ open your throat to rec"
                +"eive your mandated awe. You didn\'t enjoy your time before it, yet you feel no relief with its p"
                +"assing. Not a neutral ending, per se, just a false finality, like the end of a movie engineered "
                +"for a sequel. They do not leave the best for last. \n\nUltimate\n",
                new DateTime(2024,12,8,2,39,51),
                "Poem"));

            
            
            
            
            Tags.Add(new Tag(0, "NSFW"));
            Tags.Add(new Tag(1, "LGBTQ"));
            Tags.Add(new Tag(2, "Posthuman"));
            Tags.Add(new Tag(3, "AI"));


        }

        public List<Essay> Essays { get; set; }
        public List<Tag> Tags { get; set; }
        public List<TagItem> EssayTags { get; set; }
    }
}