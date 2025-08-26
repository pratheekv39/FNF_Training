using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hackathon2_MyWords
{

    public partial class SearchWord : System.Web.UI.Page
    {
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string word = txtWord.Text.Trim().ToLower();
            if (WordStore.WordExists(word))
            {
                string meaning = WordStore.GetMeaning(word);
                lblMessage.Text = $"<b>{word}</b>: {meaning}";
                gvWords.Visible = false;
            }
            else
            {
                lblMessage.Text = $"'{word}' is not present in the application.";
                gvWords.Visible = false;
            }
        }

        protected void btnDisplayAll_Click(object sender, EventArgs e)
        {
            gvWords.DataSource = WordStore.GetAllWords();
            gvWords.DataBind();
            gvWords.Visible = true;
            lblMessage.Text = "";
        }
    }
}