using Calender_KMVHP.Database;
using Calender_KMVHP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Day = Calender_KMVHP.Models.Day;

namespace Calender_KMVHP
{

    public partial class Form1 : Form
    {


        //Переменная для хранения ячеек конструктора
        public static List<ComboBox> all_days { get; set; }

        //public static List<string> workers { get; set; }
        public Form1()
        {
            InitializeComponent();
            all_days = new List<ComboBox> { day1_box, box_day2, box_day3, box_day4, box_day5, box_day6, box_day7, box_day8, box_day9, box_day10, box_day11
            ,box_day12,  box_day13, box_day14, box_day15, box_day16, box_day17, box_day18, box_day19, box_day20, box_day21, box_day22, box_day23, box_day24, box_day25, box_day26, box_day27, box_day28, box_day29, box_day30, box_day31};
            
            

            //Создания таблицы с изначальными людьми 
            Create_Kalender();

            //Обновление списка людей из БД для конструктора Form1
            Insert_people_in_table();


        }

        public void Insert_people_in_table()
        {
            using (AppDBContext dB = new AppDBContext())
            {
                Worker_table.Items.Clear();
                List<string> workers_string = new List<string>();
                workers_string = dB.workers.Select(x => x.Name.ToString()).ToList();
                workers_string.Sort();
                foreach (string worker in workers_string)
                {
                    Worker_table.Items.Add(worker);
                   
                }

               

            }
        }


        //Метод создания календаря
        public static void Create_Kalender()
        {
            using (AppDBContext dB = new AppDBContext())
            {
                if (dB.months.Any() == false)
                {



                    Worker Pupkin = new Worker() { Name = "Пупкин В.А." };
                    Worker Kuznetsov = new Worker() { Name = "Кузнецов В.В." };
                    Worker Shishkin = new Worker() { Name = "Шишкин В.А." };
                    Worker Smirnov = new Worker() { Name = "Смирнов С.С." };
           

                    dB.SaveChanges();

                    //Строки для инициализации месяцев
                    string[] names_month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };




                    //Пупкин

                    List<Monthh> months_Pupkin = new List<Monthh>();

                    int aa = 1;
                    for (int i = 0; i < names_month.Length; i++)
                    {
                        months_Pupkin.Add(new Monthh() { Name_month = names_month[i], Worker = Pupkin });
                        aa++;
                    }




                    List<Day> days_Pupkin = new List<Day>();

                    for (int i = 0; i < months_Pupkin.Count; i++)
                    {

                        if (i == 0 || i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 11)
                        {
                            for (int ii = 0; ii < 31; ii++)
                            {
                                days_Pupkin.Add(new Day() { State = " ", Monthh = months_Pupkin[i], Number_day = (ii + 1) });
                            }

                        }



                        if (i == 3 || i == 8 || i == 10 || i == 5)
                        {
                            for (int ii = 0; ii < 30; ii++)
                            {
                                days_Pupkin.Add(new Day() { State = " ", Monthh = months_Pupkin[i], Number_day = (ii + 1) });
                            }

                        }

                        if (i == 1)
                        {
                            for (int ii = 0; ii < 29; ii++)
                            {
                                days_Pupkin.Add(new Day() { State = " ", Monthh = months_Pupkin[i], Number_day = (ii + 1) });
                            }
                        }






                    }


                    //Кузнецов


                    List<Monthh> months_Kuznetsov = new List<Monthh>();

                    for (int i = 0; i < names_month.Length; i++)
                    {
                        months_Kuznetsov.Add(new Monthh() { Name_month = names_month[i], Worker = Kuznetsov });
                    }




                    List<Day> days_Kuznetsov = new List<Day>();
                    for (int i = 0; i < months_Kuznetsov.Count; i++)
                    {

                        if (i == 0 || i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 11)
                        {
                            for (int ii = 0; ii < 31; ii++)
                            {
                                days_Kuznetsov.Add(new Day() { State = " ", Monthh = months_Kuznetsov[i], Number_day = (i + 1) });
                            }

                        }



                        if (i == 3 || i == 8 || i == 10 || i == 5)
                        {
                            for (int ii = 0; ii < 30; ii++)
                            {
                                days_Kuznetsov.Add(new Day() { State = " ", Monthh = months_Kuznetsov[i], Number_day = (i + 1) });
                            }

                        }

                        if (i == 1)
                        {
                            for (int ii = 0; ii < 29; ii++)
                            {
                                days_Kuznetsov.Add(new Day() { State = " ", Monthh = months_Kuznetsov[i], Number_day = (i + 1) });
                            }
                        }






                    }


                    //Шишкин


                    List<Monthh> months_Shishkin = new List<Monthh>();

                    for (int i = 0; i < names_month.Length; i++)
                    {
                        months_Shishkin.Add(new Monthh() { Name_month = names_month[i], Worker = Shishkin });
                    }




                    List<Day> days_Shishkin = new List<Day>();
                    for (int i = 0; i < months_Shishkin.Count; i++)
                    {

                        if (i == 0 || i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 11)
                        {
                            for (int ii = 0; ii < 31; ii++)
                            {
                                days_Shishkin.Add(new Day() { State = " ", Monthh = months_Shishkin[i], Number_day = (i + 1) });
                            }

                        }



                        if (i == 3 || i == 8 || i == 10 || i == 5)
                        {
                            for (int ii = 0; ii < 30; ii++)
                            {
                                days_Shishkin.Add(new Day() { State = " ", Monthh = months_Shishkin[i], Number_day = (i + 1) });
                            }

                        }

                        if (i == 1)
                        {
                            for (int ii = 0; ii < 29; ii++)
                            {
                                days_Shishkin.Add(new Day() { State = " ", Monthh = months_Shishkin[i], Number_day = (i + 1) });
                            }
                        }






                    }


                    //Смирнов


                    List<Monthh> months_Smirnov = new List<Monthh>();

                    for (int i = 0; i < names_month.Length; i++)
                    {
                        months_Smirnov.Add(new Monthh() { Name_month = names_month[i], Worker = Smirnov });
                    }




                    List<Day> days_Smirnov = new List<Day>();
                    for (int i = 0; i < months_Smirnov.Count; i++)
                    {

                        if (i == 0 || i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 11)
                        {
                            for (int ii = 0; ii < 31; ii++)
                            {
                                days_Smirnov.Add(new Day() { State = " ", Monthh = months_Smirnov[i], Number_day = (i + 1) });
                            }

                        }



                        if (i == 3 || i == 8 || i == 10 || i == 5)
                        {
                            for (int ii = 0; ii < 30; ii++)
                            {
                                days_Smirnov.Add(new Day() { State = " ", Monthh = months_Smirnov[i], Number_day = (i + 1) });
                            }

                        }

                        if (i == 1)
                        {
                            for (int ii = 0; ii < 29; ii++)
                            {
                                days_Smirnov.Add(new Day() { State = " ", Monthh = months_Smirnov[i], Number_day = (i + 1) });
                            }
                        }






                    }




                    //Добавление всего в базу данных

                    dB.workers.AddRange(Pupkin, Shishkin, Smirnov, Kuznetsov);


                    dB.months.AddRange(months_Pupkin);
                    dB.months.AddRange(months_Smirnov);
                    dB.months.AddRange(months_Shishkin);
                    dB.months.AddRange(months_Kuznetsov);





                    dB.days.AddRange(days_Pupkin);
                    dB.days.AddRange(days_Smirnov);
                    dB.days.AddRange(days_Shishkin);
                    dB.days.AddRange(days_Kuznetsov);





                    dB.SaveChanges();



                }
            }
        }


        //Добавление нового пользователя
        public void Add_new_worker(string new_name)
        {

            Worker_table.Items.Add(new_name);
            using (AppDBContext dB = new AppDBContext())
            {
               
                Worker new_worker = new Worker()  {Name = new_name };

                string[] names_month = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь" };


                List<Monthh> months_new_worker = new List<Monthh>();
                int aa = 1;
                for (int i = 0; i < names_month.Length; i++)
                {
                    months_new_worker.Add(new Monthh() { Name_month = names_month[i], Worker = new_worker });
                    aa++;
                }




                List<Day> days_new_worker = new List<Day>();

                for (int i = 0; i < months_new_worker.Count; i++)
                {

                    if (i == 0 || i == 2 || i == 4 || i == 6 || i == 7 || i == 9 || i == 11)
                    {
                        for (int ii = 0; ii < 31; ii++)
                        {
                            days_new_worker.Add(new Day() { State = " ", Monthh = months_new_worker[i], Number_day = (ii + 1) });
                        }

                    }



                    if (i == 3 || i == 8 || i == 10 || i == 5)
                    {
                        for (int ii = 0; ii < 30; ii++)
                        {
                            days_new_worker.Add(new Day() { State = " ", Monthh = months_new_worker[i], Number_day = (ii + 1) });
                        }

                    }

                    if (i == 1)
                    {
                        for (int ii = 0; ii < 29; ii++)
                        {
                            days_new_worker.Add(new Day() { State = " ", Monthh = months_new_worker[i], Number_day = (ii + 1) });
                        }
                    }






                }
                dB.workers.Add(new_worker);
                dB.months.AddRange(months_new_worker);
                dB.days.AddRange(days_new_worker);
                               
                dB.SaveChanges();

            }
        }

        //Подсчёт количества дней
        private void Count_all_Click(object sender, EventArgs e)
        {


            int work_days = 0;
            int trip_days = 0;
            int illness_days = 0;
            int vacation_days = 0;

            foreach (var day_b in all_days)
            {
                if ((day_b.Text == " " || day_b.Text == null || day_b.Text == "") && day_b.Enabled == true) work_days++;
                if (day_b.Text == "к" && day_b.Enabled == true) trip_days++;
                if (day_b.Text == "б" && day_b.Enabled == true) illness_days++;
                if (day_b.Text == "о" && day_b.Enabled == true) vacation_days++;


            }
            Work_days.Text = $"Рабочие дни: {work_days}";
            Trip_days.Text = $"Командировочные дни: {trip_days}";
            Illness_days.Text = $"Больничные дни: {illness_days}";
            Vacation_days.Text = $"Отпускные дни: {vacation_days}";

        }

        //Сохранить дни в базу данных
        private void Save_data_Click(object sender, EventArgs e)
        {
            using (AppDBContext dB = new AppDBContext())
            {
                //Добавление нового пользователя, если нет в списке
                if (!dB.workers.Select(x => x.Name).Contains(Worker_table.Text) && dB.months.Select(x => x.Name_month).Contains(Month.Text))
                {
                    

                    Add_new_worker(Worker_table.Text);

                }

                string month_name = Month.Text;

                List<Day> check = dB.days.Where(x => x.Monthh.Name_month == Month.Text && x.Monthh.Worker.Name == Worker_table.Text).OrderBy(x => x.Number_day).ToList();




                for (int y = 0; y < check.Count; y++)
                {




                    check[y].State = all_days[y].Text;



                }



                Month.Text = "Сохранено";  //"Сохранено";

                Thread thread_saved = new Thread(new ThreadStart(Had_saved));
                thread_saved.Start();
                thread_saved.Join();
                Month.Text = month_name;




                dB.SaveChanges();


            }

        }
        //Небольшая пауза при сохранении
        public void Had_saved() => Thread.Sleep(1000);





        //Загрузить дни из базы данных
        private void Load_data_b_Click(object sender, EventArgs e)
        {

            using (AppDBContext dB = new AppDBContext())
            {
                //Добавление нового пользователя, если нет
                if (!dB.workers.Select(x => x.Name).Contains(Worker_table.Text) && dB.months.Select(x => x.Name_month).Contains(Month.Text))
                {


                    Add_new_worker(Worker_table.Text);

                }

                //Отбор дней из БД на основании выбранного месяца
                List<string> selected_days = dB.days.Where(x => x.Monthh.Name_month == Month.Text && x.Monthh.Worker.Name == Worker_table.Text).OrderBy(x => x.Number_day).Select(x => x.State).ToList();

                //Количество дней в месяце
                int count_days = selected_days.Count();

                //Проверка на то, високосный ли текущий год
                bool is_Leap = DateTime.IsLeapYear(DateTime.Now.Year);



                //Сокрытие лишних кнопок в конструкторе
                if (count_days == 31)
                {
                    all_days[27].Enabled = true;
                    all_days[28].Enabled = true;
                    all_days[29].Enabled = true;
                    all_days[30].Enabled = true;

                }

                if (count_days == 30)
                {
                    all_days[27].Enabled = true;
                    all_days[28].Enabled = true;
                    all_days[29].Enabled = true;
                    all_days[30].Enabled = false;
                }

                if (count_days == 29)
                {

                    // all_days[28].Enabled = false;
                    all_days[29].Enabled = false;
                    all_days[30].Enabled = false;
                    if (!is_Leap)
                    {
                        all_days[28].Enabled = false;
                    }

                }



                //Ввод данных из базы данных в кнопки
                for (int n = 0; n < selected_days.Count; n++)
                {
                    int nn = n + 1;
                    all_days[n].Text = selected_days[n];
                }


            }


            Count_all_Click(sender, e);
        }

        //Удаление работника
        private void Delete_worker_Click(object sender, EventArgs e)
        {
            string name_removing = Worker_table.Text;

            if (Worker_table.Items.Contains(name_removing))
            {

           
            using (AppDBContext dB = new AppDBContext())
            {
                //Получение удаляемого пользователя
                Worker worker_removing = dB.workers.Where(x => x.Name == name_removing).FirstOrDefault();

                //Получение месяцев удаляемого пользователя
                var monthhs_removing = dB.months.Where(x => x.Worker == worker_removing);

                //Получение дней удаляемого пользователя
                var days_removing = dB.days.Where(x => x.Monthh.Worker == worker_removing);

                //Удаление из базы данных по полученным значениям
                dB.workers.Remove(worker_removing);
                dB.months.RemoveRange(monthhs_removing);
                dB.days.RemoveRange(days_removing);

                Worker_table.Items.Remove(name_removing);

                    dB.SaveChanges();

            }
            }

        }



        private void Worker_table_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void day1_box_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        

        private void Work_days_Click(object sender, EventArgs e)
        {

        }

        private void box_day2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Trip_days_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void Illness_days_Click(object sender, EventArgs e)
        {

        }

        private void Month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
    }
}
