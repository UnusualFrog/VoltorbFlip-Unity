
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public const int gridRows = 5;
    public const int gridCols = 5;
    public const float offsetX = 2.479f;
    public const float offsetY = 2.4825f;
    int[] numbers = {2,2,2,3,0,0,0,0,0,0,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1};
    public int total = 1;
    public bool activeGame = false;
    public GameObject winText;
    public GameObject loseText;
    public int MarkerValue = 1;

    List<int> col1 = new List<int>() { 0, 0 };
    List<int> col2 = new List<int>() { 0, 0 };
    List<int> col3 = new List<int>() { 0, 0 };
    List<int> col4 = new List<int>() { 0, 0 };
    List<int> col5 = new List<int>() { 0, 0 };
    List<List<int>> cols = new List<List<int>>();

    List<int> row1 = new List<int>() { 0, 0 };
    List<int> row2 = new List<int>() { 0, 0 };
    List<int> row3 = new List<int>() { 0, 0 };
    List<int> row4 = new List<int>() { 0, 0 };
    List<int> row5 = new List<int>() { 0, 0 };
    List<List<int>> rows = new List<List<int>>();

    int[] one1 = { 2, 2, 2, 3, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] one2 = { 3, 3, 3, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] one3 = { 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] one4 = { 2, 2, 3, 3, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] one5 = { 2, 2, 2, 2, 3, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

    int[] two1 = { 2, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] two2 = { 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] two3 = { 3, 3, 3, 2, 2, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] two4 = { 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] two5 = { 2, 2, 2, 2, 2, 3, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

    int[] three1 = { 2, 2, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] three2 = { 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] three3 = { 2, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] three4 = { 2, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] three5 = { 2, 2, 2, 2, 2, 2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

    int[] four1 = { 2, 2, 2, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] four2 = { 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] four3 = { 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
    int[] four4 = { 2, 2, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] four5 = { 2, 2, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

    int[] five1 = { 2, 2, 2, 2, 2, 2, 2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] five2 = { 2, 2, 2, 2, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] five3 = { 2, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] five4 = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
    int[] five5 = { 2, 2, 2, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };

    int[] six1 = { 2, 2, 2, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] six2 = { 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] six3 = { 2, 2, 2, 2, 2, 2, 2, 2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
    int[] six4 = { 2, 2, 2, 2, 2, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
    int[] six5 = { 2, 2, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };

    int[] seven1 = { 2, 2, 2, 2, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] seven2 = { 2, 2, 2, 2, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
    int[] seven3 = { 2, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };
    int[] seven4 = { 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1 };
    int[] seven5 = { 2, 2, 2, 2, 2, 2, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 };

    int[] eight1 = { 3, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
    int[] eight2 = { 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };
    int[] eight3 = { 2, 2, 2, 2, 2, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
    int[] eight4 = { 2, 2, 3, 3, 3, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1 };
    int[] eight5 = { 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1 };

    List<int[]> oneSets = new List<int[]>();
    List<int[]> twoSets = new List<int[]>();
    List<int[]> threeSets = new List<int[]>();
    List<int[]> fourSets = new List<int[]>();
    List<int[]> fiveSets = new List<int[]>();
    List<int[]> sixSets = new List<int[]>();
    List<int[]> sevenSets = new List<int[]>();
    List<int[]> eightSets = new List<int[]>();


    List<List<int[]>> numberSets = new List<List<int[]>>(); 

    IDictionary<string, int> randomSet;

    [SerializeField] private MainCard originalCard;
    [SerializeField] private Sprite[] images;
    List<MainCard> cards = new List<MainCard>();

    public void Start()
    {
        oneSets.Add(one1);
        oneSets.Add(one2);
        oneSets.Add(one3);
        oneSets.Add(one4);
        oneSets.Add(one5);
        numberSets.Add(oneSets);

        twoSets.Add(two1);
        twoSets.Add(two2);
        twoSets.Add(two3);
        twoSets.Add(two4);
        twoSets.Add(two5);
        numberSets.Add(twoSets);

        threeSets.Add(three1);
        threeSets.Add(three2);
        threeSets.Add(three3);
        threeSets.Add(three4);
        threeSets.Add(three5);
        numberSets.Add(threeSets);

        fourSets.Add(four1);
        fourSets.Add(four2);
        fourSets.Add(four3);
        fourSets.Add(four4);
        fourSets.Add(four5);
        numberSets.Add(fourSets);

        fiveSets.Add(five1);
        fiveSets.Add(five2);
        fiveSets.Add(five3);
        fiveSets.Add(five4);
        fiveSets.Add(five5);
        numberSets.Add(fiveSets);

        sixSets.Add(six1);
        sixSets.Add(six2);
        sixSets.Add(six3);
        sixSets.Add(six4);
        sixSets.Add(six5);
        numberSets.Add(sixSets);

        sevenSets.Add(seven1);
        sevenSets.Add(seven2);
        sevenSets.Add(seven3);
        sevenSets.Add(seven4);
        sevenSets.Add(seven5);
        numberSets.Add(sevenSets);

        eightSets.Add(eight1);
        eightSets.Add(eight2);
        eightSets.Add(eight3);
        eightSets.Add(eight4);
        eightSets.Add(eight5);
        numberSets.Add(eightSets);

        
        randomSet = new Dictionary<string, int>() { { "L", 1 }, { "2", 0 }, { "3", 0 }, { "V", 0 }, };
        winText.SetActive(false);
        loseText.SetActive(false);
        NewGame();
        
    }

    public void NewGame()
    {
        activeGame = true;
        loseText.SetActive(false);
        winText.SetActive(false);
        cols.Add(col1);
        cols.Add(col2);
        cols.Add(col3);
        cols.Add(col4);
        cols.Add(col5);
        rows.Add(row1);
        rows.Add(row2);
        rows.Add(row3);
        rows.Add(row4);
        rows.Add(row5);
        activeGame = true;
        Vector3 startPos = originalCard.transform.position; //pos of first card     
        numbers = ShuffleArray(numbers);
        
        for (int i = 0; i < gridCols; i++) 
        {
            for (int j = 0; j < gridRows;j++) 
            {
                MainCard card;
                if (i == 0 && j == 0) 
                {
                    card = originalCard;
                }
                else 
                {
                    card = Instantiate(originalCard) as MainCard;
                }

                int index = j * gridCols + i;
                int id = numbers[index];
                //int newCard = Random.Range(0, 4);
                //card.ChangeSprite(newCard, images[newCard]);
                card.ChangeSprite(id, images[id]);
                card.cardValue = id;

                if (card.cardValue > 1) 
                {
                    total *= card.cardValue;
                }

                float posX = (offsetX * i) + startPos.x;
                float posY = (offsetY * j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
                
                cards.Add(card);
                
            }
            
            //Debug.Log(cards.Count);
        }
        Debug.Log("Total score " + total);

        //columns
        int points = 0;
        int voltorbs = 0;
        int colIndex = 0;
        for (int i = 1; i < cards.Count + 1; i++)
        {
            if (cards[i - 1].cardValue > 0)
            {
                points += cards[i - 1].cardValue;
            }
            else
            {
                voltorbs++;
            }

            if (i % 5 == 0)
            {
                cols[colIndex][0] += points;
                cols[colIndex][1] += voltorbs;
                points = 0;
                voltorbs = 0;
                colIndex++;
            }
        }

        //rows
        int j1 = 0;
        for (int i = 0; i < cards.Count; i++)
        {
            if (j1 > 4)
            {
                j1 = 0;
            }
            if (cards[i].cardValue > 0)
            {
                rows[j1][0] += cards[i].cardValue;
            }
            else
            {
                rows[j1][1] += 1;
            }
            j1++;
        }

        

        col1Score.text = "" + cols[0][0];
        col2Score.text = "" + cols[1][0];
        col3Score.text = "" + cols[2][0];
        col4Score.text = "" + cols[3][0];
        col5Score.text = "" + cols[4][0];

        col1Volt.text = "" + cols[0][1];
        col2Volt.text = "" + cols[1][1];
        col3Volt.text = "" + cols[2][1];
        col4Volt.text = "" + cols[3][1];
        col5Volt.text = "" + cols[4][1];

        row1Score.text = "" + rows[0][0];
        row2Score.text = "" + rows[1][0];
        row3Score.text = "" + rows[2][0];
        row4Score.text = "" + rows[3][0];
        row5Score.text = "" + rows[4][0];

        row1Volt.text = "" + rows[0][1];
        row2Volt.text = "" + rows[1][1];
        row3Volt.text = "" + rows[2][1];
        row4Volt.text = "" + rows[3][1];
        row5Volt.text = "" + rows[4][1];


    }//newgame() end

    public void EndGame() 
    {
        activeGame = true;
        loseText.SetActive(false);
        winText.SetActive(false);
        col1 = new List<int>() { 0, 0 };
        col2 = new List<int>() { 0, 0 };
        col3 = new List<int>() { 0, 0 };
        col4 = new List<int>() { 0, 0 };
        col5 = new List<int>() { 0, 0 };
        cols = new List<List<int>>();
        cols.Add(col1);
        cols.Add(col2);
        cols.Add(col3);
        cols.Add(col4);
        cols.Add(col5);
        row1 = new List<int>() { 0, 0 };
        row2 = new List<int>() { 0, 0 };
        row3 = new List<int>() { 0, 0 };
        row4 = new List<int>() { 0, 0 };
        row5 = new List<int>() { 0, 0 };
        rows = new List<List<int>>();
        rows.Add(row1);
        rows.Add(row2);
        rows.Add(row3);
        rows.Add(row4);
        rows.Add(row5);
        col1Score.text = "0";
        col2Score.text = "0";
        col3Score.text = "0";
        col4Score.text = "0";
        col5Score.text = "0";
        col1Volt.text = "0";
        col2Volt.text = "0";
        col3Volt.text = "0";
        col4Volt.text = "0";
        col5Volt.text = "0";
        row1Score.text = "0";
        row2Score.text = "0";
        row3Score.text = "0";
        row4Score.text = "0";
        row5Score.text = "0";

        total = 1;
        ScoreT +=  Score;
        scoreLabelT.text = "Total Coins:\n " + ScoreT;
        Score = 0;
        scoreLabel.text = "Coins Collected:\n " + Score;



        //legacy code
        /*foreach (MainCard c in cards) 
        {
            c.Card_Back.SetActive(true);
            int newCard = Random.Range(0, 4);
            c.ChangeSprite(newCard, images[newCard]);
            c.cardValue = newCard;
            if (c.cardValue > 1)
            {
                total *= c.cardValue;
            }
            //Debug.Log(c.cardValue);
        }*/

        int x;
        switch (GameLevel) 
        {
            case 1:
                x = Random.Range(0, 5);
                numbers = numberSets[0][x];
                break;
            case 2:
                x = Random.Range(0, 5);
                numbers = numberSets[1][x];
                break;
            case 3:
                x = Random.Range(0, 5);
                numbers = numberSets[2][x];
                break;
            case 4:
                x = Random.Range(0, 5);
                numbers = numberSets[3][x];
                break;
            case 5:
                x = Random.Range(0, 5);
                numbers = numberSets[4][x];
                break;
            case 6:
                x = Random.Range(0, 5);
                numbers = numberSets[5][x];
                break;
            case 7:
                x = Random.Range(0, 5);
                numbers = numberSets[6][x];
                break;
            case 8:
                x = Random.Range(0, 5);
                numbers = numberSets[7][x];
                break;
            default:
                Debug.Log("Bad Switch statement");
                break;
        }

        numbers = ShuffleArray(numbers);
        for (int i = 0;i< cards.Count; i++) 
        {
            MainCard c = cards[i];
            c.Card_Back.SetActive(true);
            c.ChangeSprite(numbers[i], images[numbers[i]]);
            c.cardValue = numbers[i];
            c.MarkerV.SetActive(false);
            c.Marker1.SetActive(false);
            c.Marker2.SetActive(false);
            c.Marker3.SetActive(false);
            if (c.cardValue > 1)
            {
                total *= c.cardValue;
            }
        }

        Debug.Log("Total score " + total);

        //for getting columns
        int points = 0;
        int voltorbs = 0;
        int colIndex = 0;
        for (int i = 1;i < cards.Count + 1; i++) 
        {
            if (cards[i-1].cardValue > 0) 
            {
                points += cards[i-1].cardValue;
            }
            else 
            {
                voltorbs++;
            }

            if (i % 5 == 0) 
            {
                cols[colIndex][0] += points;
                cols[colIndex][1] += voltorbs;
                points = 0;
                voltorbs = 0;
                colIndex++;
            }
        }

        //for getting rows
        int j = 0;
        for (int i = 0;i < cards.Count; i++) 
        {
            if (j > 4) 
            {
                j = 0;            
            }
            if (cards[i].cardValue > 0) 
            {
                rows[j][0] += cards[i].cardValue;
            }
            else 
            {
                rows[j][1] += 1;
            }
            j++;
        }



        //text setting below
        col1Score.text =  "" + cols[0][0];
        col2Score.text = "" + cols[1][0];
        col3Score.text = "" + cols[2][0];
        col4Score.text = "" + cols[3][0];
        col5Score.text = "" + cols[4][0];
        
        col1Volt.text = "" + cols[0][1];
        col2Volt.text = "" + cols[1][1];
        col3Volt.text = "" + cols[2][1];
        col4Volt.text = "" + cols[3][1];
        col5Volt.text = "" + cols[4][1];

        row1Score.text = "" + rows[0][0];
        row2Score.text = "" + rows[1][0];
        row3Score.text = "" + rows[2][0];
        row4Score.text = "" + rows[3][0];
        row5Score.text = "" + rows[4][0];

        row1Volt.text = "" + rows[0][1];
        row2Volt.text = "" + rows[1][1];
        row3Volt.text = "" + rows[2][1];
        row4Volt.text = "" + rows[3][1];
        row5Volt.text = "" + rows[4][1];

    }


    private int[] ShuffleArray(int[] numbers) 
    {
        int[] newArray = numbers.Clone() as int[];
        for (int i = 0;i < newArray.Length; i++) 
        {
            int tmp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = tmp;
        }
        return newArray;
    }

    public (int, IDictionary<string, int>) randomValue(IDictionary<string, int> currentSet) 
    {
        int level = currentSet["L"];
        int value = Random.Range(0, 4);
        switch (level) 
        {
            case 1:

                break;
        }
        return (value, currentSet);
    }
    //-------------------------------------------------------------------

    private int _score = 0;
    public int Score { get { return _score; } set { _score = value; } }
    public TextMesh scoreLabel;

    private int _scoreT = 0;
    public int ScoreT { get { return _scoreT; } set { _scoreT = value; } }
    public TextMesh scoreLabelT;

    private int _gameLevel = 1;
    public int GameLevel { get { return _gameLevel; } set { _gameLevel = value; } }
    public TextMesh LevelText;

    public TextMesh col1Score;
    public TextMesh col2Score;
    public TextMesh col3Score;
    public TextMesh col4Score;
    public TextMesh col5Score;

    public TextMesh col1Volt;
    public TextMesh col2Volt;
    public TextMesh col3Volt;
    public TextMesh col4Volt;
    public TextMesh col5Volt;

    public TextMesh row1Score;
    public TextMesh row2Score;
    public TextMesh row3Score;
    public TextMesh row4Score;
    public TextMesh row5Score;

    public TextMesh row1Volt;
    public TextMesh row2Volt;
    public TextMesh row3Volt;
    public TextMesh row4Volt;
    public TextMesh row5Volt;



}
