using System;
using System.Data;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private SQLiteConnection _db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _db = new SQLiteConnection("Data source=FilmsBD.db; Version=3");
            _db.Open();

            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("select * from Film", _db);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Info");
            grdFilm.DataSource = ds.Tables[0];

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _db.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFILM.Text != "" && tbAssessment.Text != "")
            {

                var allNums = Regex.Matches(tbAssessment.Text, @"\d+");
                var assessment = new int[allNums.Count];
                
                for (var i = 0; i < assessment.Length; ++i)
                {
                    assessment[i] = int.Parse(allNums[i].Value);
                }
                tbAssessment.Text = assessment[0].ToString();
                
                
                if (1 <= assessment[0] && assessment[0] <= 10)
                {
                    SQLiteCommand cmd = _db.CreateCommand();
                    cmd.CommandText = "insert into Film(Фильмы, Оценка) values(@film, @assessment)";
                    cmd.Parameters.Add("@film", DbType.AnsiString).Value = tbFILM.Text.ToUpper();
                    cmd.Parameters.Add("@assessment", DbType.Double).Value = assessment[0];
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Оцените фильм от 1 до 10!");
                }
                

                btnAll_Click(sender, e);
           
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("select * from Film", _db);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Info");
            grdFilm.DataSource = ds.Tables[0];
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var allNums = Regex.Matches(tbID.Text, @"\d+");
            var tmp = new int[allNums.Count];
            for (var i = 0; i < tmp.Length; ++i)
            {
                tmp[i] = int.Parse(allNums[i].Value);
            }
            try
            {
                tbID.Text = tmp[0].ToString();

                SQLiteCommand cmd = _db.CreateCommand();
                try
                {
                    cmd.CommandText = "DELETE FROM Film WHERE id like " + tmp[0];
                    cmd.ExecuteNonQuery();
                    btnAll_Click(sender, e);
                }
                catch
                {
                    
                }
            }
            catch
            {
                MessageBox.Show(@"Введите допустимое значение", @"Обнаружены ошибки");
            }


        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            
            var allNums = Regex.Matches(tbID.Text, @"\d+");
            var tmp = new int[allNums.Count];
            for (var i = 0; i < tmp.Length; ++i)
            {
                tmp[i] = int.Parse(allNums[i].Value);
            }
            
            var allNums2 = Regex.Matches(tbAssessment.Text, @"[-+]?\d+");
            var assessment = new int[allNums2.Count];
            for (var i = 0; i < assessment.Length; ++i)
            {
                assessment[i] = int.Parse(allNums2[i].Value);
            }

            try
            {
                tbAssessment.Text = assessment[0].ToString();
            }
            catch
            {
                tbAssessment.Text = "";
            }

            try
            {
                tbID.Text = tmp[0].ToString();

                SQLiteCommand cmd = _db.CreateCommand();
                try
                {
                    if (tbFILM.Text != "" && tbAssessment.Text != "")
                    {
                        cmd.CommandText = "update Film set Оценка = " + assessment[0] + ", Фильмы = '" +
                                          tbFILM.Text.ToUpper() + "'  where id like " + tmp[0];
                        cmd.ExecuteNonQuery();
                        if (1 <= assessment[0] && assessment[0] <= 10)
                        {
                             cmd = _db.CreateCommand();
                            cmd.CommandText = "insert into Film(Фильмы, Оценка) values(@film, @assessment)";
                            cmd.Parameters.Add("@film", DbType.AnsiString).Value = tbFILM.Text.ToUpper();
                            cmd.Parameters.Add("@assessment", DbType.Double).Value = assessment[0];
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Оцените фильм от 1 до 10!");
                        }
                        btnAll_Click(sender, e);
                    }
                    else if (tbAssessment.Text != "")
                    {
                        cmd.CommandText = "update Film set Оценка = " + assessment[0] + "  where id like " +
                                          tmp[0];
                        cmd.ExecuteNonQuery();
                        if (1 <= assessment[0] && assessment[0] <= 10)
                        {
                            cmd = _db.CreateCommand();
                            cmd.CommandText = "insert into Film(Фильмы, Оценка) values(@film, @assessment)";
                            cmd.Parameters.Add("@film", DbType.AnsiString).Value = tbFILM.Text.ToUpper();
                            cmd.Parameters.Add("@assessment", DbType.Double).Value = assessment[0];
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Оцените фильм от 1 до 10!");
                        }
                        

                    }
                    else if (tbFILM.Text != "")
                    {
                        cmd.CommandText = "update Film set Фильмы = '" + tbFILM.Text.ToUpper() +
                                          "'  where id like " + tmp[0];
                        cmd.ExecuteNonQuery();
                        btnAll_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show(@"Поля не заполнены", @"Обнаружены ошибки");
                    }

                }
                catch
                {
                    MessageBox.Show(@"Введите допустимое значение", @"Обнаружены ошибки");
                }
            }
            catch
            {
                tbID.Text = "";
                tbAssessment.Text = "";
                MessageBox.Show(@"Введите допустимое значение", @"Обнаружены ошибки");

            }
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAll_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
        private void grdStud_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdFilm.Rows[e.RowIndex].Cells[0].Value.ToString() != string.Empty)
            {
                tbID.Text = grdFilm.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbFILM.Text = grdFilm.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbAssessment.Text = grdFilm.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        private void infobutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данную программу разработал студент СПбГТИ(ТУ)\nФакультета Информационных технологий и управления\n475 группы: Овчинников Роман Сергеевич.", "Информация о программе");
        }
    }
}
