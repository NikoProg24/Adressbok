using Inlämningsuppgift1._1.Classes;

namespace Inlämningsuppgift1._1
{
    public partial class Adressbok : Form
    {
        public Adressbok()
        {
            InitializeComponent();
        }

        //Skapa kontakt och skicka in i textfil.
        private void buttonCreate_Click(object sender, EventArgs e)
        //Ta emot datan från textboxar och skicka till textfilen.
        {
            Contact contact = new Contact(textBoxName.Text, textBoxAddress.Text, textBoxZipCode.Text,
                textBoxCity.Text, textBoxPhone.Text, textBoxEmail.Text);

            contact.Save();
            ClearFields();

            LoadContacts();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        //Söka från textfil och om det man söker hittas i filen så visas kontakten i listboxen.
        {
            //Öppnar upp textfilen.
            string file = @"C:\Users\niko\Documents\Textfiler\Kontakter.txt";
            string searchCondition = textBoxSearch.Text;
            listBoxContacts.Items.Clear();

            using (StreamReader reader = new StreamReader(file))
            {
                //Sålänge det finns en rad att läsa från så letar vi igenom textfilen efter sökvillkoret
                //och lägger sedan in de rader i listboxen som matchar sökvillkoret.
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.ToLower().Contains(searchCondition))
                    {
                        listBoxContacts.Items.Add(line);
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
         //Här ska en vald kontakt från listboxen raderas från listan och textfilen.
        {
            //Kontroll om en kontakt är vald i listboxen.
            if (listBoxContacts.Items != null)
            {
                string file = @"C:\Users\niko\Documents\Textfiler\Kontakter.txt";

                //Hämta den valda kontakten från listboxen.
                string selectedContact = listBoxContacts.SelectedItem.ToString();

                //Läser av alla rader från filen.
                string[] lines = File.ReadAllLines(file);

                //Här skapar vi en lista av alla kontakter som inte ska raderas.
                List<string> updatedContacts = new List<string>();

                //Loopa igenom alla rader och lägg till kontakter som inte ska tas bort.
                foreach (string line in lines)
                {
                    if (line != selectedContact)
                    {
                        updatedContacts.Add(line);
                    }
                }
                //Skicka tillbaka de återstående kontakterna till textfilen.
                File.WriteAllLines(file, updatedContacts);

                //Ta bort den valda kontakten från listboxen.
                listBoxContacts.Items.Remove(selectedContact);

                ClearFields();
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        //Klicka på kontakt i listboxen och skicka värdena till textboxarna. Skriv sedan över värdena
        //och spara nya värden när man klickar på uppdatera. 
        {
            string file = @"C:\Users\niko\Documents\Textfiler\Kontakter.txt";

            //Hämta den valda kontakten från listboxen.
            string selectedContact = listBoxContacts.SelectedItem.ToString();

            //Här skapas en sträng med 6st platshållare som ersätts av nya värden från textboxarna.
            string updatedContact = string.Format("{0}, {1}, {2}, {3}, {4}, {5}",
                textBoxName.Text,
                textBoxAddress.Text,
                textBoxZipCode.Text,
                textBoxCity.Text,
                textBoxPhone.Text,
                textBoxEmail.Text);

            //Läs alla rader från textfilen.
            string[] lines = File.ReadAllLines(file);

            //Här loopar vi igenom varje rad i arrayen och om en rad matchar den valda kontakten
            //*selectedContact* så byts den ut med *updatedContact*. Loopen avbryts när en match hittas och ersätts.
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == selectedContact)
                {
                    //Ersätt den gamla raden mot den nya.
                    lines[i] = updatedContact;
                    break;
                }
            }

            //Skriv tillbaka den uppdaterade arrayern till filen.
            File.WriteAllLines(file, lines);

            //Uppdatera listbox med det nya värdet.
            listBoxContacts.Items[listBoxContacts.SelectedIndex] = updatedContact;

            ClearFields();


        }

        //Metod som kan anropas för att rensa fält.
        public void ClearFields()
        {
            textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxZipCode.Clear();
            textBoxCity.Clear();
            textBoxZipCode.Clear();
            textBoxPhone.Clear();
            textBoxEmail.Clear();
            textBoxSearch.Clear();
        }


        //Metod för att läsa upp kontkter.
        public void LoadContacts()
        {
            listBoxContacts.Items.Clear();

            string file = @"C:\Users\niko\Documents\Textfiler\Kontakter.txt";
            using (StreamReader reader = new StreamReader(file))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    listBoxContacts.Items.Add(line);
                }
            }
        }

        private void Adressbok_Load(object sender, EventArgs e)
        {
             LoadContacts();
            //Flyttar kontakt från listbox till textboxar när kontakt är vald i listbox.
            listBoxContacts.SelectedIndexChanged += listBoxSearch_SelectedIndexChanged;
        }



        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        //Metod som söker på kontakt från textfil, visar kontakten i listboxen och sedan skickar
        //värde från arrayern till textboxarna. 
        {

            //Kontrollera om en konatkt är vald.
            if (listBoxContacts.SelectedItem != null)
            {
                //Hämta den valda kontakten i listboxen.
                string selectedContact = listBoxContacts.SelectedItem.ToString();
                string[] listBoxArray = selectedContact.Split(',');

                if (listBoxArray.Length >= 6)
                {
                    textBoxName.Text = listBoxArray[0];
                    textBoxAddress.Text = listBoxArray[1];
                    textBoxZipCode.Text = listBoxArray[2];
                    textBoxCity.Text = listBoxArray[3];
                    textBoxPhone.Text = listBoxArray[4];
                    textBoxEmail.Text = listBoxArray[5];
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxContacts.Items.Clear();
        }
    }
}
