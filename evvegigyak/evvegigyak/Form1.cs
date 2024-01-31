using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace evvegigyak
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private List<string> lista = new List<string>();
        private Dictionary<int, int> szamelof = new Dictionary<int, int>();

        public Form1()
        {
            InitializeComponent();
            LoadData();

            // DomainUpDown inicializálása
            domainUpDown.Items.AddRange(Enumerable.Range(1, 52).Select(i => i.ToString()).ToArray());
            domainUpDown.SelectedIndex = 0;

            // Button kattintás eseménykezelõ
            buttonCalculate.Click += ButtonCalculate_Click;
        }

        private void LoadData()
        {
            // Fájl elérési útja
            string f = "C:\\Users\\Munkacsi\\oraimunka\\evvegi_v_gy\\gyakorlas\\bin\\Debug\\net7.0\\sorsolas.txt";

            // StreamReader példány létrehozása a fájl olvasásához
            using (StreamReader r = new StreamReader(f))
            {
                // Fájl tartalmának beolvasása soronként és hozzáadás a listához
                string sor;
                while ((sor = r.ReadLine()) != null)
                {
                    lista.Add(sor);
                }
            }
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            int het = int.Parse(domainUpDown.SelectedItem.ToString());

            // Kiválasztott sor (hét) kiírása a konzolra
            if (het - 1 < lista.Count)
            {
                string vsor = lista[het - 1];
                string[] szamok = vsor.Split(';');

                CalculateStatistics();

                // Legtöbbször húzott szám
                int leggyakelof = szamelof
                    .OrderByDescending(kv => kv.Value)
                    .FirstOrDefault()
                    .Key;

                // Páros számok elõfordulása
                int paroselof = szamelof
                    .Where(kv => kv.Key % 2 == 0)
                    .Sum(kv => kv.Value);

                // 4-es és 73-as szám elõfordulása
                int elof4 = szamelof.ContainsKey(4) ? szamelof[4] : 0;
                int elof73 = szamelof.ContainsKey(73) ? szamelof[73] : 0;

                // Statisztikák kiírása a label-re
                labelResults.Text = $"2. A(z) {het}. héten húzott számok: {string.Join(", ", szamok)}\n";
                labelResults2.Text = $"3. Legtöbbször húzott szám: {leggyakelof}\n";
                labelResults3.Text = $"4. Páros számok elõfordulása: {paroselof}\n";
                labelResults4.Text = $"5. 4-es szám elõfordulása: {elof4}\n";
                labelResults5.Text = $"6. 73-as szám elõfordulása: {elof73}\n";


            }
            else
            {
                labelResults.Text = $"A(z) {het}. hét nem található a megadott tartományban.";
            }
            FillDataGridView();
        }


        private void FillDataGridView()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Number", "Szám");
            dataGridView1.Columns.Add("Occurrences", "Elõfordulások");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            foreach (var kvp in szamelof.OrderBy(kv => kv.Key))
            {
                dataGridView1.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void CalculateStatistics()
        {
            // Minden soron végigmegyünk és számoljuk az elõfordulásokat (az elsõ értéket nem számoljuk)
            foreach (var sor in lista)
            {
                var szamok = sor.Split(';').Skip(1).Select(int.Parse);

                foreach (var szam in szamok)
                {
                    if (szamelof.ContainsKey(szam))
                    {
                        szamelof[szam]++;
                    }
                    else
                    {
                        szamelof[szam] = 1;
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

