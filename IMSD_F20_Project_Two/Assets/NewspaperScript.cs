using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewspaperScript : MonoBehaviour
{
    public Button factCheck, scrollUp, scrollDown, close;
    public TMP_InputField userText;
    public GameObject newspaperObject;
    public TMP_Text newspaperText;
    public NextDay nextDay;

    public int level = 1;
    int numberOfFailedAttempts = 0, _level = 0;
    int page = 1, _page = 0;
    bool lastPage;
    string content;
    void Start()
    {
        factCheck.onClick.AddListener(Check);
        scrollUp.onClick.AddListener(ScrollUp);
        scrollDown.onClick.AddListener(ScrollDown);
        close.onClick.AddListener(Close);
    }

    // Update is called once per frame
    void Update()
    {

        if (page > 1)
            scrollUp.interactable = true;
        else
            scrollUp.interactable = false;
        if (lastPage)
            scrollDown.interactable = false;
        else
            scrollDown.interactable = true;

        if (_page != page || _level != level)
        {
            StartCoroutine(Content());
            _page = page;
            _level = level;
        }
    }
    void Check()
    {
        if (userText.text == "Guess The Amount")
            Debug.LogWarning("Please use the YELLOW text field in order to input the correct count then use \"Fact Check\" button to check the answer.");
        else
            foreach (char num in userText.text)
            {
                if (!char.IsDigit(num))
                {
                    Debug.Log("Wrong input! You must only enter a number value.");
                    numberOfFailedAttempts++;
                }
                else
                {
                    if ((level == 1 && userText.text == "22")
                        || (level == 2 && userText.text == "4")
                        || (level == 3 && userText.text == "9"))
                    {
                        Debug.Log("Well Done | You are now one step closer to understanding news!");
                        level++;
                        if (numberOfFailedAttempts == 0)
                            Debug.Log("Bravo, In your first attempt you were able to win this round. You are trully a wise person.");
                        else
                            Debug.Log("You tried " + numberOfFailedAttempts + " times in order to succeed to the next round.");

                        Debug.Log("Your current Level: " + level);
                        newspaperObject.SetActive(false);
                        numberOfFailedAttempts = 0;
                        userText.text = "Guess The Amount";
                    }

                    else
                    {
                        numberOfFailedAttempts++;
                        if (nextDay.day == level)
                        {
                            Debug.Log("You did not answer correctly. Please try again.");
                        }
                        if (numberOfFailedAttempts > 9)
                            Debug.Log("Stop Looking, Open Your Eyes and Start Seeing. You must shift your awareness completely and watch the reality from the unbias point of view.");
                        if (numberOfFailedAttempts > 19)
                            Debug.Log("Pro Tip: You need to start reading some books and stop watching same TV channel all the time.");
                    }
                }
            }

    }
    void ScrollUp()
    {
        if (page > 1)
        page--;
        StartCoroutine(Content());

    }
    void ScrollDown()
    {
        if (!lastPage)
        page++;
        StartCoroutine(Content());
    }

    IEnumerator Content()
    {
        if (level == 1)
        {
            if (page == 1)
                content = "If the polls are right, Joe Biden could post the most decisive victory in a presidential election in three and a half decades, surpassing Bill Clinton’s win in 1996. \n That’s a big \"if.\" \n The indelible memory of 2016’s polling misfire, when Donald J.Trump trailed in virtually every pre - election poll and yet swept the battleground states and won the Electoral College, has hovered over the 2020 campaign. \n Mr.Biden’s unusually persistent lead has done little to dispel questions about whether the polls could be off again. \n President Trump needs a very large polling error to have a hope of winning the White House.Joe Biden would win even if polls were off by as much as they were in 2016.";
            else if (page == 2)
                content = "But while President Trump’s surprising victory has imbued him with an aura of political invincibility, the polls today put him in a far bigger predicament than the one he faced heading into Election Day in 2016. The polls show Mr. Biden with a far more significant lead than the one held by Hillary Clinton, and many of the likeliest explanations for the polling misfire do not appear to be in play today. \n Of course, it’s possible the polls could be off by even more than they were four years ago. But to win, that’s exactly what Mr. Trump needs. He would need polls to be even worse than they were in the Northern battleground states four years ago. Crucially, he would also need polls to be off to a far greater extent at the national level as well as in the Sun Belt — and those polls have been relatively accurate in recent contests.";
            else if (page == 3)
                content = "Another way to think of it: Pollsters would have far fewer excuses than they did for missing the mark four years ago. Mr. Trump’s upset victory was undoubtedly a surprise, but pollsters argued, with credibility, that the polling wasn’t quite as bad as it seemed. Mrs. Clinton did win the national vote, as polls suggested she would, and even the state polls weren’t so bad outside of a handful of mostly white working-class states where there were relatively few high-quality polls late in the election. \n In post-election post-mortems, pollsters arrived at a series of valid explanations for what went wrong. None of those would hold up if Mr. Trump won this time.";
            else if (page == 4)
                content = "Here are the many ways the polls are different today than they were in 2016. \n The national polls show a decisive Biden win. Four years ago, the national polls showed Mrs. Clinton with a lead of around four percentage points, quite close to her eventual 2.1-point margin in the national vote. This year, the national polls show Mr. Biden up by 8.5 percentage points, according to our average. The higher-quality national surveys generally show him ahead by even more. \n Unlike in 2016, the national polls do not foreshadow the gains Mr. Trump made in the Northern battleground states. \n Unlike in 2016, the national polls do not foreshadow the gains Mr. Trump made in the Northern battleground states.";
            else if (page == 5)
                content = "Four years ago, national polls showed Mr. Trump making huge gains among white voters without a college degree. It hinted that he was within striking distance of winning in the Electoral College, with possible victories in relatively white working-class states like Wisconsin, even though the state polls still showed Mrs. Clinton ahead. \n This year, the national polls have consistently shown Mr. Biden making big gains among white voters and particularly among white voters without a degree. In this respect, the national polls are quite similar to state polls showing Mr. Biden running well in relatively white Northern battleground states like Wisconsin and Michigan. The national pollsters won’t be able to sidestep blame while pointing fingers at the state pollsters.";
            else if (page == 6)
                content = "There are far fewer undecided or minor-party voters. Four years ago, polls showed a large number of voters who were either undecided or backing a minor-party candidate, and it was always an open question how these voters would break at the end. \n Over all, Mrs. Clinton led Mr. Trump, 45.7 to 41.8, in the FiveThirtyEight average, and 12.5 percent of voters were either undecided or supporting a minor-party candidate like Gary Johnson or Jill Stein.";
            else if (page == 7)
                content = "There’s significant evidence that undecided and minor-party voters shifted to Mr. Trump in 2016. The exit polls found that late deciders broke toward him, 45-42 — but by even higher margins in the states where the polling error was worst, like Wisconsin, where late deciders broke toward him, 59-30, in the last week. Post-election surveys, which sought to re-contact voters reached in pre-election polls, found voters drifting to Mr. Trump. And all of this was foreshadowed by pre-election polls, which showed the race tightening after the third debate and the Comey letter. It doesn’t explain the whole polling error four years ago, but it probably does explain part of it.";
            else if (page == 8)
            {
                content = "This year, just 4.6 percent are undecided or backing a minor-party candidate, according to the FiveThirtyEight average. Even if these voters broke unanimously to Mr. Trump, he would be far short of victory across the battleground states and nationwide. \n Some pollsters — including the New York Times/Siena poll — do show more undecided voters, voters backing a minor-party candidate, or voters who simply refuse to state whom they’ll back for president. Yet there’s little evidence that they’re poised to break unanimously for the president.";
                lastPage = true;
            }
            else if (page > 8 || page < 1)
                content = "ERROR";
            if (page != 8)
                lastPage = false;
        }
        else if (level == 2)
        {
            if (page == 1)
                content = "Democratic presidential nominee Joe Biden dismissed the U.S. economy's record-shattering growth as not \"nearly enough\" to get the country out of a \"deep hole\" on Thursday. \n \"This report underscores three inescapable truths about Donald Trump’s economy: we are in a deep hole and President Trump’s failure to act has meant that Q3 growth wasn’t nearly enough to get us out of; the recovery is slowing if not stalling; and the recovery that is happening is helping those at the top, but leaving tens of millions of working families and small businesses behind,\" Biden said in a statement.";
            else if (page == 2)
                content = "US ECONOMIC GROWTH SHATTERS RECORD AT 33.1%, BUT FAILS TO SNAP CORONAVIRUS RECESSION \n Gross domestic product, the broadest measure of goods and services produced across the economy, surged by 33.1% on an annualized basis in the three-month period from July through September, the Commerce Department said in its first reading of the data Thursday. The previous post-World War II record was a 16.7% increase in 1950. \n The economy had contracted at an annual revised rate of 31.4% in the previous quarter, the sharpest decline in modern American history, and the economy remains 3.5% smaller than at the end of 2019.";
            else if (page == 3)
                content = "The GDP data, released Thursday morning, was one of the last major economic indicators to come out ahead of Election Day on Tuesday. Another key indicator, weekly unemployment claims, showed that the number of Americans filing for claims fell under 800,000 for the first time since March. \n More than 65 million Americans ‒ roughly 40% of the nation's labor force ‒ have sought jobless aid since the coronavirus lockdowns began in mid-March.";
            else if (page == 4)
                content = "\"Even with today’s report, GDP still remains $6,000 per household below its pre-crisis level, payrolls are down by nearly 11 million workers, and 23 million people are claiming unemployment ‒ including 750,000 new claims last week,\" Biden continued. \"Today's report is not a victory for these families.\" \n BIDEN AND TRUMP TO TANGLE IN TAMPA ON THURSDAY \n The Trump campaign, however, took a victory lap on the GDP figure, touting it as \"absolute validation of President Trump's policies, which create jobs and opportunities for Americans in every corner of the country.\" \n \"The president built the world’s best economy once and he's rapidly doing it again,\" Trump 2020 communications director Tim Murtaugh said in a statement.";
            else if (page == 5)
                content = "\"GDP number just announced,\" President Trump wrote on Twitter on Thursday. \"Biggest and Best in the History of our Country, and not even close. Next year will be FANTASTIC!!! However, Sleepy Joe Biden and his proposed record setting tax increase, would kill it all. So glad this great GDP number came out before November 3rd.\" \n Biden also hit Trump after hope for another coronavirus relief being passed before the election faded, saying Trump has \"no plan to convene Congress to get a deal done to get economic relief to those who badly need it.\"";
            else if (page == 6)
            {
                content = "White House economic adviser Larry Kudlow told \"America's Newsroom\" Thursday that House Speaker Nancy Pelosi, D-Calif., was \"stringing us along\" and \"going to hold up key assistance like the [Paycheck Protection Program], small business assistance and unemployment assistance.\" \n CLICK HERE TO GET THE FOX NEWS APP \n \"I don't think this recovery depends on the assistance package, per se,\" Kudlow said. \"But I do think unemployment assistance, PPP, small business assistance, helping the schools, that could have helped a lot. And it's not going to happen. The Democrats have been completely intransigent.\"";
                lastPage = true;
            }
            else if (page > 6 || page < 1)
                content = "ERROR";
            if (page != 6)
                lastPage = false;
        }
        else if (level == 3)
        {
            if (page == 1)
                content = "Millions of legally cast votes are being counted in elections offices around the country as the presidential race between President Donald Trump and former Vice President Joe Biden comes down to a handful of battleground states. \n Biden holds the lead in the Electoral College at this stage in the night, 224-213; 270 electoral votes are needed to become president. \n Experts had warned for months that a result may not be known on election night, or even days afterward, as voters voted by mail in record numbers. As of early Wednesday morning, it was still too close to call in Arizona, North Carolina, Nevada, Wisconsin, Michigan, Maine, Georgia and the potentially critical state of Pennsylvania.";
            else if (page == 2)
                content = "Trump won a close race in Florida, which was one of the states Biden had hoped to peel away from the President's 2016 map and has a narrow edge in North Carolina. The former vice president has taken the lead in Wisconsin and is hoping that Arizona, where he has a 5-percentage point lead with 82% of the ballots counted, could be his first victory of the night that turns a red state blue. \n With more than 90% of the vote counted in Wisconsin, Biden holds a narrow lead over Trump in that state of just more than 20,000 votes, with all of Milwaukee's vote counted.";
            else if (page == 3)
                content = "The state of Nevada, which Clinton won by a slender margin in 2016, also appeared to be a much closer race than Democrats had expected. With 85% of the votes counted in that state, Biden leads by less than a percentage point. \n Increasingly, it appears that the result of the entire election could hinge on whether Biden can restore the Democratic \"blue wall\" in Michigan, Wisconsin and Pennsylvania, a scenario that could stretch into the coming days as large numbers of mail-in votes are counted.";
            else if (page == 4)
                content = "Biden pulled ahead by a slight margin in Michigan Wednesday morning with 90% of the vote counted. The clerk of the key suburban Michigan county of Wayne, Cathy Garrett, told CNN election officials are still counting votes, and she would not estimate when officials may conclude. The county is reporting that more than 64% of those cast there have been counted. Wayne County is the largest county in Michigan and includes Detroit and its metro area.";
            else if (page == 5)
                content = "Michigan's Secretary of State Jocelyn Benson said in a tweet Wednesday morning that \"hundreds of thousands of ballots in our largest jurisdictions are still being counted including Detroit, Grand Rapids, Flint, Warren & Sterling Heights.\" \n The night unfolded as the most unorthodox election night in modern memory. At times it appeared like one candidate or the other was heading for an early win in important states. But batches of mail-in and early votes meant the count often dramatically shifted one way or the other.";
            else if (page == 6)
                content = "Polls are now closed across the US on a nerve-jangling night that will set the nation's course for the next four years and cast judgment on the most tumultuous presidency of the modern age. Results are flowing in from battlegrounds and it's too early to make a projection in many key states. /n CNN projects Biden will win Hawaii, Rhode Island, Minnesota, Virginia, California, Oregon, Washington, Illinois, New Hampshire, New Mexico, Colorado, Connecticut, New Jersey, New York, Vermont, Delaware, Washington, DC, Maryland, Massachusetts and one of Nebraska's five electoral votes. Nebraska awards two electoral votes to its statewide winner and divides three others over its three congressional districts.";
            else if (page == 7)
                content = "CNN projects Trump will also win in Montana, Texas, Iowa, Idaho, Ohio, Mississippi, Wyoming, Missouri, Kansas, Utah, Louisiana, Alabama, South Carolina, North Dakota, South Dakota, Arkansas, Indiana, Oklahoma, Kentucky, West Virginia and Tennessee and four of Nebraska's five electoral votes. /n Trump's chilling threat to vote counting /n Trump attempted to claim victory in the presidential race and called for a halt to legitimate vote counting that is underway around the country in a chilling threat to American democracy";
            else if (page == 8)
                content = "In fact, the election is far from over with millions of votes outstanding in key states like Pennsylvania, Wisconsin and Michigan -- ballots that were cast before Election Day that have yet to be counted. Yet Trump sought to mislead his loyal supporters by conflating the legitimate counting of ballots with voting as he falsely claimed Democrats were trying to \"steal the election.\"";
            else if (page == 9)
                content = "Facing the real possibility that he could lose, Trump -- as expected -- appeared to be seizing the opportunity to confuse his supporters about the democratic process and suggest that there was something nefarious about the fact that many states are still counting votes. The lengthy vote count, which could extend for several days, was widely anticipated because so many Americans cast vote-by-mail ballots to protect themselves from exposure to the coronavirus in the middle of a pandemic.";
            else if (page == 10)
                content = "While making the ludicrous suggestion that the counting of legally cast votes should stop as he watched his margins narrow in several key swing states, Trump made a wild threat that his lawyers would take their case to the Supreme Court even though it remains unclear what their legal rationale would be. \n Even within Trump's short speech there was a glaring inconsistency in his position as he advocated for votes to continue to be counted in Arizona, a state that he believes is more favorable to him, while expressing anger that one network had called it early. CNN has not projected a winner in Arizona.";
            else if (page == 11)
                content = "He celebrated his victories in Florida and Ohio, and claimed to win multiple states that CNN has yet to project. His call for an end to the counting was the kind of dangerous election night speech that political observers long feared Trump would make, in which he falsely claimed, \"This is a major fraud on our nation.\" \n Biden campaign manager Jen O'Malley Dillon ripped Trump's speech as \"a naked effort to take away the democratic rights of American citizens.\"";
            else if (page == 12)
                content = "\"The President's statement tonight about trying to shut down the counting of duly cast ballots was outrageous, unprecedented, and incorrect,\" she said, adding, \"It was unprecedented because never before in our history has a president of the United States sought to strip Americans of their voice in a national election. Having encouraged Republican efforts in multiple states to prevent the legal counting of these ballots before Election Day, now Donald Trump is saying these ballots can't be counted after Election Day either.\"";
            else if (page == 13)
                content = "Biden was the first candidate to speak to supporters early Wednesday morning, after a night of results didn't deliver a quick winner, saying that \"we believe we're on track to win this election.\" \n The former vice president said it was not up to him or Trump to decide the winner of the election and that the votes would be counted. \n \"Keep the faith guys, we're going to win this,\" Biden said. \n Trump wins two must-have states \n Wins for Trump in the Sunshine State and Ohio are crucial to keep open his pathway to win a second term.";
            else if (page == 14)
                content = "Florida Democrats were concerned early in the night about populous southern Miami-Dade County where Biden appeared to be underperforming Clinton's mark in 2016. \n The early Biden deficit in Miami-Dade could be a sign of what was apparent in pre-election polls that suggested the President had been making incursions into traditional Democratic support with Black and Latino men. Former President Barack Obama made two trips to Miami-Dade in the closing days of the race to drive up turnout.";
            else if (page == 15)
                content = "Miami-Dade, which Biden is still likely to win, has large concentrations of voters of Cuban and Venezuelan descent who tend to be more conservative than other Latino groups and were targeted by the President with claims that Democrats were akin to socialists. \n The President also opened up a solid lead in Ohio after early returns showed Biden in the lead. The Buckeye State was another battleground that Trump's campaign thought he must win in order to earn another four years in Washington. Biden spent time in the state on Monday and was another place that the Democrat had hoped to flip.";
            else if (page == 16)
                content = "Biden does not need to win Florida and Ohio in order to win the presidency, but his campaign had hoped to flip those states after several encouraging polls in the final weeks of the campaign. /n Biden performs well in Arizona /n Biden appears to have made significant gains in Arizona where demographic changes have accelerated the state's shift from traditional Republican territory to a potential Democratic pick up. The President's unpopularity and the rapid growth of the state -- from its rising Latino population to the influx of retirees from the Midwest and other parts of the country -- has made its politics more unpredictable, even in just the four years since 2016, when Trump beat Hillary Clinton in the state 49% to 45.5%.";
            else if (page == 17)
                content = "Clinton built up Democratic margins in populous Maricopa County, which includes Phoenix and its suburbs -- and the majority of the state's voters -- and Biden appears to be continuing that trend Tuesday night, with turnout looking strong in that key county. \n Even within the patchwork of early returns, some trends were emerging that pointed to the fact that is a very different race than 2016. In states like Ohio and parts of Florida, Biden appears to be performing better in the suburbs than Clinton did four years ago. At the same time, the President's team seems to have succeeded in turning out their voters as promised -- in some cases making up for what appeared to be an advantage for Democrats in the early vote count in key swing states.";
            else if (page == 18)
                content = "Results may not be known for days \n Millions of ballots were still outstanding in those critical three states of Michigan, Pennsylvania and Wisconsin, many of them vote-by-mail ballots that were cast early and were expected to favor Democrats. \n Even Georgia appeared at a standstill as officials in Fulton County, which includes Atlanta and its populous suburbs said they had stopped counting mail-in ballots around 10:30 p.m. ET and that count would resume at 8 a.m. Wednesday. The Fulton County tabulation was initially delayed by a water leak near the room where ballots were being counted but no ballots were damaged.";
            else if (page == 19)
                content = "Election officials in the so-called \"Blue Wall\" states of the Midwest tried to prepare the public late Tuesday night for the likelihood that a full count would continue through the night, and could stretch well into Wednesday and later this week -- meaning America may not know the winner of the presidential contest for quite some time. \n The slow count in those Midwestern states is creating mounting anxiety for Democrats, who had hoped Biden could post some early wins on the board in swing states to prevent President Trump from declaring a premature victory before even crossing the 270 electoral vote threshold that he needs to win.";
            else if (page == 20)
                content = "For weeks now, Trump has hammered the message that voters should know the results on election night -- even though that is rarely the case in America -- while suggesting that a later count could be a sign of voting irregularities, even though there is no evidence to support that and counting has been much more complex this cycle because so many people cast votes by mail in order to stay safe during the pandemic. \n Michigan officials are predicting record turnout, and are hoping that ballots counted overnight could give a sense of at least the unofficial result within 24 hours of poll closures, instead of several days as some were initially expecting, but that appeared uncertain.";
            else if (page == 21)
                content = "Michigan Secretary of State Jocelyn Benson told reporters Tuesday night that the state could \"potentially see a full result of every tabulation out of Michigan in the next 24 hours,\" which would be an improvement on the state's original prediction that it would not finish tabulating results until Friday. The state is on track to break turnout records with more than 3 million absentee ballots cast. \n \"I'm here tonight to ask you all to be patient,\" Benson said. \"No matter how long it takes, no matter what candidates say, we're going to work methodically and meticulously to count every single valid ballot and that, and only that, will determine who wins every race on the ballot in the state of Michigan.\"";
            else if (page == 22)
                content = "The tipping point state of Pennsylvania may see some of the longest delays, not only because of its very complex ballot with its inner and outer envelopes, but also because election officials were not permitted to start counting the vote-by-mail ballots until Election Day. Late Tuesday night, the Pennsylvania secretary of state urged patience and told result-watchers to expect batches of vote totals to come in in fits and starts throughout the night. \n In Wisconsin, some results in the key area of Milwaukee may not be reported until after 5 a.m. on Wednesday, meaning the vote tallies in some of the most critical areas for Biden would not be known until then.";
            else if (page == 23)
                content = "Historic amount of early votes \n Across the country, officials were counting the more than 100 million votes that were cast before Election Day, according to a survey of election officials by CNN, Edison Research and Catalist. \n The economy is the top issue on the minds of voters Tuesday, according to the preliminary results of a nationwide CNN exit poll. Those results are incomplete because Americans were still voting, but in those early measures about a third said the economy is the most critical issue. About 1 in 5 said racial inequality is the top issue and 1 in 6 said the coronavirus pandemic was most important to their vote. However, a majority said the nation should prioritize containing Covid-19 over rebuilding the economy.";
            else if (page == 24)
            {
                content = "Republicans have made a huge effort to invalidate ballots and limit voter turnout through legal challenges and questionable monitoring tactics that bordered on voter intimidation in some states. Trump spent his final days trying to cast aspersions on vote counting, insisting that a winner should be declared on Tuesday night, even though America has long counted ballots well into the days and weeks after Election Day. \n With Biden leading in many national and battleground state polls, the President's team is counting on explosive Election Day turnout within the GOP and relying on their intensive, data-driven ground game to turn out quiet Trump voters, who they say have not been reflected in the polls.";
                lastPage = true;
            }

            else if (page > 24 || page < 1)
                content = "ERROR";
            if (page != 24)
                lastPage = false;
        }

        yield return newspaperText.text = content;    
    }

    void Close()
    {
        newspaperObject.SetActive(false);
    }

}

