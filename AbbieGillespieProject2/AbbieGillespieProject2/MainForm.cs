namespace AbbieGillespieProject2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetLetters();
        }

        private List<char> letterList = new List<char>();
        private Random random = new Random();
        private char[] currLetters = new char[7];

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

        }
    }
}
