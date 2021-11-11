using ChuckNorrisAPI;
using System.Collections;
using System.Linq;

namespace ChuckNorrisJokes
{
    public partial class ChuckNorrisJokesGenerator : Form
    {
        public ChuckNorrisJokesGenerator()
        {
            InitializeComponent();
        }

        private async void ChuckNorrisJokesGenerator_Load(object sender, EventArgs e)
        {
            List<string> categoryList = new List<string>(await ChuckNorrisAPI.ChuckNorrisClient.GetCategories());
           
            foreach (string category in categoryList)
            {
                jokeCategoryBox.Items.Add(category);
            }
        }

        private async void jokeButton_Click(object sender, EventArgs e)
        {
            Joke randomJoke = await ChuckNorrisAPI.ChuckNorrisClient.GetRandomJoke();
            if (!randomJoke.Categories.Contains(jokeCategoryBox.SelectedValue))
            {
                randomJoke = await ChuckNorrisAPI.ChuckNorrisClient.GetRandomJoke();
            }
            List<string> categoryList = new List<string>(await ChuckNorrisAPI.ChuckNorrisClient.GetCategories());
            string jokeCategory = (string)jokeCategoryBox.SelectedItem;

            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(randomJoke.JokeText, jokeCategory, button);
        }

        private async void multipleJokesButton_Click(object sender, EventArgs e)
        {
            IEnumerable<Joke> randomJokes = await ChuckNorrisAPI.ChuckNorrisClient.GetRandomJokes(Decimal.ToInt32(jokeAmount.Value));
            string jokeCategory = (string)jokeCategoryBox.SelectedItem;

            MessageBoxButtons button = MessageBoxButtons.OK;
            DialogResult result;

            foreach (Joke joke in randomJokes)
            {
                result = MessageBox.Show(joke.JokeText, jokeCategory, button);
            }
        }
    }
}