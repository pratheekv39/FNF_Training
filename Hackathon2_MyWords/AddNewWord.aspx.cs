using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hackathon2_MyWords
{

    public partial class AddNewWord : System.Web.UI.Page
    {
        protected void btnAddWord_Click(object sender, EventArgs e)
        {
            string word = txtNewWord.Text.Trim().ToLower();
            string meaning = txtMeaning.Text.Trim();

            if (string.IsNullOrEmpty(word) || string.IsNullOrEmpty(meaning))
            {
                lblStatus.Text = "Please enter both word and meaning.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                return;
            }

            if (WordStore.WordExists(word))
            {
                lblStatus.Text = $"'{word}' already exists.";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                WordStore.AddWord(word, meaning);
                lblStatus.Text = $"'{word}' added successfully.";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}