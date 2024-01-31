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

            // DomainUpDown inicializ�l�sa
            domainUpDown.Items.AddRange(Enumerable.Range(1, 52).Select(i => i.ToString()).ToArray());
            domainUpDown.SelectedIndex = 0;

            // Button kattint�s esem�nykezel�
            buttonCalculate.Click += ButtonCalculate_Click;
        }

        private void LoadData()
        {
            // F�jl el�r�si �tja
            string f = "C:\\Users\\Munkacsi\\oraimunka\\evvegi_v_gy\\gyakorlas\\bin\\Debug\\net7.0\\sorsolas.txt";

            // StreamReader p�ld�ny l�trehoz�sa a f�jl olvas�s�hoz
            using (StreamReader r = new StreamReader(f))
            {
                // F�jl tartalm�nak beolvas�sa soronk�nt �s hozz�ad�s a list�hoz
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

            // Kiv�lasztott sor (h�t) ki�r�sa a konzolra
            if (het - 1 < lista.Count)
            {
                string vsor = lista[het - 1];
                string[] szamok = vsor.Split(';');

                CalculateStatistics();

                // Legt�bbsz�r h�zott sz�m
                int leggyakelof = szamelof
                    .OrderByDescending(kv => kv.Value)
                    .FirstOrDefault()
                    .Key;

                // P�ros sz�mok el�fordul�sa
                int paroselof = szamelof
                    .Where(kv => kv.Key % 2 == 0)
                    .Sum(kv => kv.Value);

                // 4-es �s 73-as sz�m el�fordul�sa
                int elof4 = szamelof.ContainsKey(4) ? szamelof[4] : 0;
                int elof73 = szamelof.ContainsKey(73) ? szamelof[73] : 0;

                // Statisztik�k ki�r�sa a label-re
                labelResults.Text = $"2. A(z) {het}. h�ten h�zott sz�mok: {string.Join(", ", szamok)}\n";
                labelResults2.Text = $"3. Legt�bbsz�r h�zott sz�m: {leggyakelof}\n";
                labelResults3.Text = $"4. P�ros sz�mok el�fordul�sa: {paroselof}\n";
                labelResults4.Text = $"5. 4-es sz�m el�fordul�sa: {elof4}\n";
                labelResults5.Text = $"6. 73-as sz�m el�fordul�sa: {elof73}\n";


            }
            else
            {
                labelResults.Text = $"A(z) {het}. h�t nem tal�lhat� a megadott tartom�nyban.";
            }
            FillDataGridView();
        }


        private void FillDataGridView()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("Number", "Sz�m");
            dataGridView1.Columns.Add("Occurrences", "El�fordul�sok");

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            foreach (var kvp in szamelof.OrderBy(kv => kv.Key))
            {
                dataGridView1.Rows.Add(kvp.Key, kvp.Value);
            }
        }

        private void CalculateStatistics()
        {
            // Minden soron v�gigmegy�nk �s sz�moljuk az el�fordul�sokat (az els� �rt�ket nem sz�moljuk)
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

