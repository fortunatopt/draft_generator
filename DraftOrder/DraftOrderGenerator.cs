using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DraftOrder
{
    public partial class DraftOrderGenerator : Form
    {
        /// <summary>
        /// Random object for ShuffleList functionality
        /// </summary>
        private Random r = new Random();
        private int counter = int.Parse(ConfigurationManager.AppSettings["Counter"]);
        private DateTime dt = new DateTime();
        private bool timerRunning = false;
        /// <summary>
        /// Initialize Application and Randomize Users from app.config
        /// </summary>
        public DraftOrderGenerator()
        {
            InitializeComponent();
            //tmrTimer.Stop();
            RandomListGenerator();
        }
        /// <summary>
        /// Reset button was clicked. Prompt user first
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnRandomDraft_Click(object sender, EventArgs e)
        {
            DialogResult reset = MessageBox.Show("Are you sure you want to Reset the list?", "Reset?", MessageBoxButtons.YesNo);

            if (reset == DialogResult.Yes)
                RandomListGenerator();

        }
        /// <summary>
        /// Quit button was clicked. Prompt user first
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult quit = MessageBox.Show("Are you sure you want to Quit?", "Quit?", MessageBoxButtons.YesNo);

            if (quit == DialogResult.Yes)
                Application.Exit();
        }
        /// <summary>
        /// Gets the users and rounds, and then creates the randomized DataTable
        /// </summary>
        private void RandomListGenerator()
        {
            var users = ConfigurationManager.AppSettings["Users"].Split(new char[] { ',' });
            int rounds = int.Parse(ConfigurationManager.AppSettings["Rounds"]);

            var data = new List<dynamic>();

            for (int i = 0; i < rounds; i++)
            {
                var row = new ExpandoObject() as IDictionary<string, Object>;

                List<string> people = users.ToList();

                List<string> shuffledUsers = ShuffleList<string>(people);

                for (int k = 0; k < users.Count(); k++)
                {
                    int userNumber = k + 1;
                    row.Add($"User {userNumber.ToString()}", shuffledUsers[k]);
                }

                data.Add(row);

            }

            DataTable dt = ToDataTable(data);

            grdResults.DataSource = dt;
            for (int z = 0; z < grdResults.ColumnCount; z++)
                grdResults.Columns[z].SortMode = DataGridViewColumnSortMode.NotSortable;
        }
        /// <summary>
        /// Shuffles the data
        /// </summary>
        /// <typeparam name="E">The type to be randomized</typeparam>
        /// <param name="inputList">List list of data to be randomized</param>
        /// <returns></returns>
        private List<E> ShuffleList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();
            
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }
        /// <summary>
        /// Convert dynamic list to DataTable for binding to grid
        /// </summary>
        /// <param name="items">Dynamic list</param>
        /// <returns>DataTable created from dynamic list</returns>
        public static DataTable ToDataTable(IEnumerable<dynamic> items)
        {
            var data = items.ToArray();
            if (data.Count() == 0) return null;

            var dt = new DataTable();
            foreach (var key in ((IDictionary<string, object>)data[0]).Keys)
            {
                dt.Columns.Add(key);
            }
            foreach (var d in data)
            {
                dt.Rows.Add(((IDictionary<string, object>)d).Values.ToArray());
            }
            return dt;
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            counter --;
            if (counter == 0)
            {
                timerRunning = false;
                tmrTimer.Stop();
                lblTimer.ForeColor = Color.Red;
                btnTimer.Text = "Restart Timer";
                btnCancelTimer.Visible = false;
            }

            lblTimer.Text = dt.AddSeconds(counter).ToString("HH:mm:ss");
            //d = new DateTime()
            //   lblTimer.Text = DateTime.Now.ToString();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {

            if (timerRunning == false)
            {
                if (counter == 0)
                    counter = int.Parse(ConfigurationManager.AppSettings["Counter"]);
                lblTimer.ForeColor = Color.Lime;
                timerRunning = true;
                btnTimer.Text = "Pause Timer";
                tmrTimer.Start();
                btnCancelTimer.Visible = true;
            }
            else
            {
                btnTimer.Text = "Start Timer";
                timerRunning = false;
                tmrTimer.Stop();
            }
        }

        private void btnCancelTimer_Click(object sender, EventArgs e)
        {
            btnTimer.Text = "Start Timer";
            timerRunning = false;
            tmrTimer.Stop();
            btnCancelTimer.Visible = false;
            counter = int.Parse(ConfigurationManager.AppSettings["Counter"]);
            lblTimer.Text = dt.AddSeconds(counter).ToString("HH:mm:ss");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (AboutAppBox box = new AboutAppBox())
            {
                box.ShowDialog(this);
            }
        }
    }
}
