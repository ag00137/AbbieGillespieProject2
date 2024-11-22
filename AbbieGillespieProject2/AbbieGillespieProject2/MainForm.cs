using System.Collections;
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

            if (word.Length < 3)
            {
                MessageBox.Show("Word must be 3 or more letters long.");
                return;
            }

            if (!IsWordValid(word))
            {
                MessageBox.Show($"{word} is not valid.");
                return;
            }

            if (dictionaryWords != null && dictionaryWords.Contains(word))
            {
                int score = CalculateScore(word);
                MessageBox.Show($"{word} is valid! Score: {score}");
                validWordsListBox.Items.Add(word);
                RemoveUsedLetters(word);
                inputTxtBox.Clear();
            }
            else
            {
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
                    currLetters[index] = ' ';
                }
            }

            DisplayLetters();
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
            GetLetters();
            CurrentTime = 60;
            timeLeftLbl.Text= CurrentTime.ToString();
            gameTimer.Start();
        }
    }
}
