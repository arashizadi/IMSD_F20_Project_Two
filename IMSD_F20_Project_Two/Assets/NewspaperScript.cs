using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewspaperScript : MonoBehaviour
{
    public Button factCheck, scrollUp, scrollDown;
    public TMP_InputField userText;
    public GameObject newspaperObject;
    public TMP_Text newspaperText;

    int level = 1;
    int numberOfFailedAttempts = 0;
    int page = 1, _page = 0;
    bool lastPage;
    string content;
    void Start()
    {
        factCheck.onClick.AddListener(Check);
        scrollUp.onClick.AddListener(ScrollUp);
        scrollDown.onClick.AddListener(ScrollDown);
        Debug.Log("Pick up the NEWSPAPER on the table. It's from NY Types...");
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

        if (_page != page)
        {
            StartCoroutine(Content());
            _page = page;
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
                        Debug.Log("Well Done | You have just one step ");
                        level++;
                        if (numberOfFailedAttempts == 0)
                            Debug.Log("Bravo, In your first attempt you were able to win this round. You are trully a wise person.");
                        else
                            Debug.Log("You tried " + numberOfFailedAttempts + " times in order to succeed to the next round.");

                        Debug.Log("Your current Level: " + level);
                        newspaperObject.SetActive(false);
                        numberOfFailedAttempts = 0;
                    }

                    else
                    {
                        numberOfFailedAttempts++;
                        Debug.Log("You did not answer correctly. Please try again.");
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
        yield return newspaperText.text = content;    
    }

}

