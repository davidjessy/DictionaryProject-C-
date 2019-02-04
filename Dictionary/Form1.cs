using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection conn;
        //SqlDataAdapter dataAdapter;
        public Form1()
        {
            InitializeComponent();
            setButtonVisibility();
        }

        //Button Visibility //Disable the submit button if the text box is empty
        private void setButtonVisibility()
        {
            if ((EnterWordTextBox.Text != String.Empty) && (EnterDescriptionTextBox.Text != String.Empty))
            {
                AddWordButton.Enabled = true;
            }
            else
            {
                AddWordButton.Enabled = false;
            }
        }

        private void EnterWordTextBox_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility(); //Disable the submit button if the text box is empty
        }

        private void EnterDescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            setButtonVisibility(); //Disable the submit button if the text box is empty
        }

        private void AddWordButton_Click(object sender, EventArgs e)
        {
            string WordtoAdd = EnterWordTextBox.Text;
            string DescriptionToAdd = EnterDescriptionTextBox.Text;
            try
            {
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\kunjumon\Documents\Visual Studio 2015\Projects\Dictionary\Dictionary\Dictionary.mdf';Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("INSERT INTO DictWords(word,meaning)VALUES(@word,@meaning)", conn);
                cmd.Parameters.AddWithValue("@word", WordtoAdd);
                cmd.Parameters.AddWithValue("@meaning", DescriptionToAdd);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Word Inserted to the Database");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void SearchWordsKeyUp(object sender, KeyEventArgs e)
        {
            string searchwordstring = SearchWordsTextbox.Text;

            int searchwordstringLength = SearchWordsTextbox.Text.Length;
            
            if(searchwordstringLength == 0)
            {
                listView1.Items.Clear();
            }
            else if (searchwordstringLength>=4)
            {
                SqlDataReader dataReader;
                conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\kunjumon\Documents\Visual Studio 2015\Projects\Dictionary\Dictionary\Dictionary.mdf';Integrated Security=True");
                conn.Open();
                cmd = new SqlCommand("SELECT word,meaning FROM DictWords WHERE word LIKE @searchedWord", conn);
                string Gensearchstring = "%" + searchwordstring + "%";
                cmd.Parameters.AddWithValue("@searchedWord", Gensearchstring);

                 try
                 {
                 dataReader = cmd.ExecuteReader();
                    listView1.Items.Clear();
                    while (dataReader.Read())
                    {
                           string[] arr = new string[4];
                           ListViewItem itm;
                           
                           arr[0] = dataReader.GetString(0);
                           arr[1] = dataReader.GetString(1);
                           itm = new ListViewItem(arr);
                           listView1.Items.Add(itm);
                     }
               }
               catch(Exception ex)
               {
                  MessageBox.Show(ex.Message);
               }
            }

        }

    }
}
