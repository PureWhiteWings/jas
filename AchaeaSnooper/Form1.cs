using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // vvv Begin additions below vvv
using System.Threading;
using System.Net.Http;
using System.Globalization;
using Newtonsoft.Json;

namespace AchaeaSnooper
{
    public partial class Form1 : Form
    {

        /*------------------------------------------------------------*\
       |                           Variables                            |
        \*------------------------------------------------------------*/

        public string nameToCheck = "none";



        /*------------------------------------------------------------*\
       |                            Methods                             |
        \*------------------------------------------------------------*/

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameListBox.DataSource = irator.getCharacterList();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            nameListBox.DataSource = irator.getCharacterList();
        }

        private void nameListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            charLookup(nameListBox.SelectedValue.ToString());
        }

        private void charLookup(string nameToCheck)
        {
            Character character = irator.getCharacterData(nameToCheck);
            if (character.fullname == "Not found")
            {
                nameLabel.Text = "Character '" + nameToCheck + "' not found";
                characterDataLabel1.Text = "";
                characterDataLabel2.Text = "";
            }
            else
            {
                nameLabel.Text = character.fullname;
                characterDataLabel1.Text = "City:  " + character.city + "\nHouse: " + character.house + "\nClass: " + character.character_class;
                characterDataLabel2.Text = "XP rank:    " + character.xp_rank + "\nExpl. rank: " + character.explorer_rank + "\nDen. kills: " + character.mob_kills + "\nAdv. kills: " + character.player_kills;
            }

        }

        private void lookupButton_Click(object sender, EventArgs e)
        {
            string charToLookUp = lookupTextBox.Text;
            lookupTextBox.SelectAll();
            charLookup(charToLookUp);
        }

        private void playersVisibleLabel_Click(object sender, EventArgs e)
        {

        }
    }



    //-------------------------------------------------------------------------



    public class irator
    {

        /*------------------------------------------------------------*\
       |                           Variables                            |
        \*------------------------------------------------------------*/



        /*------------------------------------------------------------*\
       |                            Classes                             |
        \*------------------------------------------------------------*/

        private class CharacterListDeserialised
        {
            public string count { get; set; }
            public DataTable characters { get; set; }
        }



        /*------------------------------------------------------------*\
       |                            Methods                             |
        \*------------------------------------------------------------*/

        private static async Task<string> GetRequest(string uri)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(uri).ConfigureAwait(false))
                {
                    using (HttpContent content = response.Content)
                    {
                        string htmlcontent = await content.ReadAsStringAsync();
                        return htmlcontent;
                    }
                }
            }
        }

        //-------------------------------------------------------------

        public static List<string> getCharacterList()
        {
            List<string> nameList = new List<string>();
            CharacterListDeserialised characterObject = JsonConvert.DeserializeObject<CharacterListDeserialised>(GetRequest("http://api.achaea.com/characters.json").Result);

            foreach (DataRow row in characterObject.characters.Rows)
            {
                nameList.Add(row["name"].ToString());
            }

            return nameList;
        }

        //-------------------------------------------------------------

        public static Character getCharacterData(string gameCharacter)
        {

            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            string characterUri = "http://api.achaea.com/characters/" + gameCharacter + ".json";
            string jsonString = GetRequest(characterUri).Result.Replace("class", "character_class");

            try
            {
                Character tempCharacter = JsonConvert.DeserializeObject<Character>(jsonString);

                if (tempCharacter.house == "cij")
                {
                    tempCharacter.house = "CIJ";
                }
                else
                {
                    tempCharacter.house = textInfo.ToTitleCase(tempCharacter.house);
                }

                tempCharacter.city = textInfo.ToTitleCase(tempCharacter.city);
                tempCharacter.character_class = textInfo.ToTitleCase(tempCharacter.character_class);

                return tempCharacter;
            }
            catch
            {
                Character tempCharacter = new Character();
                {
                    tempCharacter.name = "Not found";
                    tempCharacter.fullname = "Not found";
                    tempCharacter.city = "Not found";
                    tempCharacter.house = "Not found";
                    tempCharacter.level = "Not found";
                    tempCharacter.character_class = "Not found";
                    tempCharacter.mob_kills = "Not found";
                    tempCharacter.player_kills = "Not found";
                    tempCharacter.xp_rank = "Not found";
                    tempCharacter.explorer_rank = "Not found";
                }
                return tempCharacter;
            }

        }

        //-------------------------------------------------------------

        public static PrivateCharacter getPrivateCharacterData(string gameCharacter, string password)
        {
            try
            {
                CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfo = cultureInfo.TextInfo;

                string characterUri = "http://api.achaea.com/characters/" + gameCharacter + ".json?character=" + gameCharacter + "&password=" + password;
                string jsonString = GetRequest(characterUri).Result.Replace("class", "character_class");

                PrivateCharacter tempCharacter = JsonConvert.DeserializeObject<PrivateCharacter>(jsonString);

                if (tempCharacter.house == "cij")
                {
                    tempCharacter.house = "CIJ";
                }
                else
                {
                    tempCharacter.house = textInfo.ToTitleCase(tempCharacter.house);
                }

                tempCharacter.city = textInfo.ToTitleCase(tempCharacter.city);
                tempCharacter.character_class = textInfo.ToTitleCase(tempCharacter.character_class);

                return tempCharacter;
            }
            catch
            {
                PrivateCharacter tempCharacter = new PrivateCharacter();
                {
                    tempCharacter.name = "Not found";
                    tempCharacter.fullname = "Not found";
                    tempCharacter.city = "Not found";
                    tempCharacter.house = "Not found";
                    tempCharacter.level = "Not found";
                    tempCharacter.character_class = "Not found";
                    tempCharacter.mob_kills = "Not found";
                    tempCharacter.player_kills = "Not found";
                    tempCharacter.xp_rank = "Not found";
                    tempCharacter.explorer_rank = "Not found";
                    tempCharacter.messages_total = "Not found";
                    tempCharacter.messages_unread = "Not found";
                }
                return tempCharacter;
            }
        }
    }

    public class Character
    {
        public string name { get; set; }
        public string fullname { get; set; }
        public string city { get; set; }
        public string house { get; set; }
        public string level { get; set; }
        public string character_class { get; set; }
        public string mob_kills { get; set; }
        public string player_kills { get; set; }
        public string xp_rank { get; set; }
        public string explorer_rank { get; set; }
    }

    public class PrivateCharacter
    {
        public string name { get; set; }
        public string fullname { get; set; }
        public string city { get; set; }
        public string house { get; set; }
        public string level { get; set; }
        public string character_class { get; set; }
        public string mob_kills { get; set; }
        public string player_kills { get; set; }
        public string xp_rank { get; set; }
        public string explorer_rank { get; set; }
        public string messages_total { get; set; }
        public string messages_unread { get; set; }
    }

}
