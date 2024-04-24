using System.Collections.ObjectModel;
using System.Text.Json;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Note> notes;


        private void Form1_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("notes.json", FileMode.OpenOrCreate))
            {
                if (!File.Exists("notes.json"))
                {
                    notes = new List<Note>();
                    JsonSerializer.Serialize(fs, notes);
                }
                else
                {
                    try
                    {
                        notes = JsonSerializer.Deserialize<List<Note>>(fs);
                    }
                    catch
                    {
                        notes = new List<Note>();
                        JsonSerializer.Serialize(fs, notes);
                    }
                }
            }


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            var note = (from n in notes
                        where n.Date == monthCalendar1.SelectionStart.Date
                        select n).ToList();
            if (note.Count > 0)
            {
                for (int i = 0; i < notes.Count; i++)
                {
                    if (notes[i].Date == monthCalendar1.SelectionStart.Date)
                    {
                        notes[i].Text = textBox1.Text;
                    }
                }
            }
            else
            {
                notes.Add(new Note() { Date = monthCalendar1.SelectionStart.Date, Text = textBox1.Text });
            }
        }


        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("notes.json", FileMode.Create))
            {
                JsonSerializer.Serialize(fs, notes);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var note = from n in notes
                       where n.Date == monthCalendar1.SelectionStart.Date
                       select n;
            if (note.ToList().Count > 0)
                textBox1.Text = note.ToList()[0].Text;
            else textBox1.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for(int i=0; i<notes.Count; i++)
            {
                if (notes[i].Date.Date == monthCalendar1.SelectionStart.Date)
                {
                    notes.RemoveAt(i); textBox1.Text = ""; break;
                }
            }
        }
    }
}
