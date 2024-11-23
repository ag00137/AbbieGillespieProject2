using System.Collections;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text.Json;
using AbbieGillespieProject2.DictionaryWords;
using Timer = System.Windows.Forms.Timer;

namespace AbbieGillespieProject2
{
    public partial class MainForm : Form
    {
        private List<char> letterList = new List<char>();
        private Random random = new Random();
        private char[] currLetters = new char[7];
        private List<string>? dictionaryWords;
        private readonly Timer gameTimer;
        private int CurrentTime;
        private List<string> validWords = new List<string>();
        private List<string> invalidWords = new List<string>();
        private List<RoundInfo> roundHistory = new List<RoundInfo>();
        private int totalScore = 0;
        private List<WordDetail> validWordDetails = new List<WordDetail>();
        private List<WordDetail> invalidWordDetails = new List<WordDetail>();
        private List<HighScore> highScores = new List<HighScore>();
        private const string HighScoreFile = "highscores.json";

        public MainForm()
        {
            InitializeComponent();
            WordsInDictionary();
            GetLetters();

            CurrentTime = 60;
            timeLeftLbl.Text = CurrentTime.ToString();

            gameTimer = new Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += TimerOnTick;

            LoadHighScores();
        }

        private void GetLetters()
        {
            letterList.Clear();
            letterList.AddRange(new string('e', 11));
            letterList.AddRange(new string('t', 9));
            letterList.AddRange(new string('o', 8));
            letterList.AddRange(new string('a', 6));
            letterList.AddRange(new string('i', 6));
            letterList.AddRange(new string('n', 6));
            letterList.AddRange(new string('s', 6));
            letterList.AddRange(new string('h', 5));
            letterList.AddRange(new string('r', 5));
            letterList.AddRange(new string('l', 4));
            letterList.AddRange(new string('d', 3));
            letterList.AddRange(new string('u', 3));
            letterList.AddRange(new string('w', 3));
            letterList.AddRange(new string('y', 3));
            letterList.AddRange(new string('b', 2));
            letterList.AddRange(new string('c', 2));
            letterList.AddRange(new string('f', 2));
            letterList.AddRange(new string('g', 2));
            letterList.AddRange(new string('m', 2));
            letterList.AddRange(new string('p', 2));
            letterList.AddRange(new string('v', 2));
            letterList.Add('j');
            letterList.Add('k');
            letterList.Add('q');
            letterList.Add('x');
            letterList.Add('z');

            for (int i = 0; i < 7; i++)
            {
                int index = random.Next(letterList.Count);
                currLetters[i] = letterList[index];
                letterList.RemoveAt(index);
            }

            DisplayLetters();
        }

        private void DisplayLetters()
        {
            lettersTxtBox.Text = string.Join(" ", currLetters);
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string word = inputTxtBox.Text.ToLower();
            string reason = string.Empty;
            int score = CalculateScore(word);

            if (word.Length < 3)
            {
                MessageBox.Show("Word must be 3 or more letters long.");
                return;
            }

            if (!IsWordValid(word))
            {
                AddInvalidWord(word, "Word contains a letter not shown.");
                reason = "Word contains a letter not shown.";
                string wordDet = $"{word}, {reason}, {CurrentTime} seconds";
                invalidWordsListBox.Items.Add(wordDet);
                MessageBox.Show($"{word} contains a letter not shown.");
                return;
            }

            if (dictionaryWords != null && dictionaryWords.Contains(word))
            {
                AddValidWord(word, score);
                totalScore += score;

                MessageBox.Show($"{word} is valid! Score: {score}");
                string wordDet = $"{word}, {score}, {CurrentTime} seconds";
                validWordsListBox.Items.Add(wordDet);
                RemoveUsedLetters(word);
                inputTxtBox.Clear();
            }
            else
            {
                AddInvalidWord(word, "Not found in dictionary");
                reason = "Not found in dictionary";
                string wordDet = $"{word}, {reason}, {CurrentTime} seconds";
                invalidWordsListBox.Items.Add(wordDet);
                inputTxtBox.Clear();
                MessageBox.Show($"{word} is not in the dictionary");
            }
        }

        private bool IsWordValid(string word)
        {
            List<char> availableLetters = new List<char>(currLetters);

            foreach (char letter in word)
            {
                if (!availableLetters.Contains(letter))
                {
                    return false;
                }
                availableLetters.Remove(letter);
            }
            return true;
        }

        private void RemoveUsedLetters(string word)
        {
            foreach (char letter in word)
            {
                int index = Array.IndexOf(currLetters, letter);
                if (index != -1)
                {
                    if (letterList.Count > 0)
                    {
                        int newLetterIndex = random.Next(letterList.Count);
                        currLetters[index] = letterList[newLetterIndex];
                        letterList.RemoveAt(newLetterIndex);
                    }
                    else
                    {
                        currLetters[index] = ' ';
                    }
                }
            }

            DisplayLetters();
        }



        private void AddValidWord(string word, int score)
        {
            validWordDetails.Add(new WordDetail
            {
                Word = word,
                Points = score,
                TimeEntered = CurrentTime
            });
        }

        public void AddInvalidWord(string word, string reason)
        {
            invalidWordDetails.Add(new WordDetail
            {
                Word = word,
                Points = 0,
                TimeEntered = CurrentTime,
                Reason = reason
            });
        }

        public class WordDetail
        {
            public string Word { get; set; } = string.Empty;
            public int Points { get; set; }
            public int TimeEntered { get; set; }
            public string Reason { get; set; } = string.Empty;
        }

        private void WordsInDictionary()
        {
            string fileLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dictionary.json");

            if (File.Exists(fileLocation))
            {
                string jsonData = File.ReadAllText(fileLocation);

                var dictionaryEntries = JsonSerializer.Deserialize<List<AbbieGillespieProject2.DictionaryWords.DictionaryWords>>(jsonData);

                if (dictionaryEntries != null)
                {
                    dictionaryWords = dictionaryEntries
                        .SelectMany(entry => entry.words)
                        .ToList();
                }
                else
                {
                    MessageBox.Show("Failed to parse dictionary.json.");
                }
            }
            else
            {
                MessageBox.Show("Dictionary file not found.");
            }
        }

        private int CalculateScore(string word)
        {
            int length = word.Length;
            switch (length)
            {
                case 3: return 90;
                case 4: return 160;
                case 5: return 250;
                case 6: return 360;
                case 7: return 490;
                default: return 0;
            }
        }

        private void TimerOnTick(object? sender, EventArgs e)
        {
            CurrentTime--;
            timeLeftLbl.Text = CurrentTime.ToString();

            if (CurrentTime <= 0)
            {
                gameTimer.Stop();
                EndOfRound();
            }
        }

        private void timerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void oneMinuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTime = 60;
            timeLeftLbl.Text = CurrentTime.ToString();
        }

        private void twoMinutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTime = 120;
            timeLeftLbl.Text = CurrentTime.ToString();
        }

        private void threeMinutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTime = 180;
            timeLeftLbl.Text = CurrentTime.ToString();
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
        }

        private void startNewGameBtn_Click(object sender, EventArgs e)
        {
            validWordsListBox.Items.Clear();
            invalidWordsListBox.Items.Clear();
            inputTxtBox.Clear();
            GetLetters();
            CurrentTime = 60;
            timeLeftLbl.Text = CurrentTime.ToString();
            gameTimer.Start();
        }

        private void exitGameBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void twistLettersBtn_Click(object sender, EventArgs e)
        {
            currLetters = currLetters.OrderBy(x => random.Next()).ToArray();
            DisplayLetters();
        }

        public class RoundInfo
        {
            public required List<string> ValidWords { get; set; }
            public required List<string> InvalidWords { get; set; }
            public int Score { get; set; }
        }

        private void EndOfRound()
        {
            string playerName = GetPlayerName();
            highScores.Add(new HighScore
            {
                PlayerName = playerName,
                Score = totalScore,
                Time = 60 - CurrentTime
            });

            SaveHighScores();

            string validWordsSum = string.Join("\n", validWordDetails.Select(v => $"{v.Word} {v.Points} points (Time Entered: {v.TimeEntered} seconds)"));
            string invalidWordsSum = string.Join("\n", invalidWordDetails.Select(m => $"{m.Word} (Reason: {m.Reason}; Time Entered: {m.TimeEntered} seconds)"));

            MessageBox.Show($"Round Over\nTotal Round Score: {totalScore}\n\nValid Words:\n{validWordsSum}\n\nInvlaid Words:\n{invalidWordsSum}");
            validWordsListBox.Items.Clear();
            invalidWordsListBox.Items.Clear();
            inputTxtBox.Clear();
            CurrentTime = 60;
            GetLetters();
        }

        private string GetPlayerName()
        {
            return playerNameTxtBox.Text;
        }

        private void highScoreBoardBtn_Click (object sender, EventArgs e)
        {
            var sortedScores = highScores
                .OrderByDescending(h => h.Score)
                .ThenBy(h => h.Time)            
                .ToList();

            string scoreBoard = string.Join("\n", sortedScores.Select((h, i) =>
                $"{i + 1}. {h.PlayerName} - Score: {h.Score}, Time: {h.Time} seconds"));

            MessageBox.Show(scoreBoard, "High Score Board");
        }

        public class HighScore
        {
            public string PlayerName { get; set; } = string.Empty;
            public int Score { get; set; }
            public int Time { get; set; }
        }

        private void SaveHighScores()
        {
            string json = JsonSerializer.Serialize(highScores);
            File.WriteAllText(HighScoreFile, json);
        }

        private void LoadHighScores()
        {
            if (File.Exists(HighScoreFile))
            {
                string json = File.ReadAllText(HighScoreFile);
                highScores = JsonSerializer.Deserialize<List<HighScore>>(json) ?? new List<HighScore>();
            }
        }


    }
}
