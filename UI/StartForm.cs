using AppWinFormCRUD.Data.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AppWinFormCRUD.UI
{
    public partial class StartForm : Form
    {

        Person person = new Person();
        Car car = new Car();
        Crew crew = new Crew();

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearCar();
            ClearCrew();
            ClearPerson();
            btnSave.Text = "Сохранить";
            btnDelete.Enabled = false;

            person = new Person();
            car = new Car();
            crew = new Crew();

        }

        private void ClearPerson() 
        {
            txtDriverName.Text = "";
            txtDriverAge.Text = "";
            txtDriverExpAge.Text = "";

        }
        private void ClearCar()
        {
            txtCarIdNumber.Text = "";
            txtCarModel.Text = "";
            txtCarMileage.Text = "";

        }

        private void ClearCrew()
        {
            txtCrewDriver.Text = "";
            txtCrewCar.Text = "";
            txtCrewTransef.Text = "";

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            ClearPerson();
            ClearCar();
            ClearCrew();

            this.ActiveControl = txtDriverName;

            LoadDataCrew();
            LoadDataCar();
            LoadDataPerson();
            
            LoadDataPersonComboBox();
            LoadDataCarComboBox();

            btnDelete.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDriverName.Text.Trim().Equals("")
                && (!txtDriverAge.Text.Trim().Equals("") || !txtDriverExpAge.Text.Trim().Equals("")))
            {
                MessageBox.Show("Введите ФИО водителя");
                return;
            }
            else if (txtCarIdNumber.Text.Trim().Equals("")
                && (!txtCarModel.Text.Trim().Equals("") || !txtCarMileage.Text.Trim().Equals("")))
            {
                MessageBox.Show("Введите госномер автомобиля");
                return;
            }
            else if ((txtCrewCar.Text.Trim().Equals("") || txtCrewDriver.Text.Trim().Equals("")) 
                && !txtCrewTransef.Text.Trim().Equals(""))
            {
                MessageBox.Show("Выбирете госномер автомобиля и водителя");
                return;
            }
            else
            {
                if (!txtDriverName.Text.Trim().Equals(""))
                {
                    try
                    {
                        SavePerson();
                        ClearPerson();
                        LoadDataPerson();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
                if (!txtCarIdNumber.Text.Trim().Equals(""))
                {
                    try
                    {
                        SaveCar();
                        ClearCar();
                        LoadDataCar();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                if (!txtCrewCar.Text.Trim().Equals(""))
                {
                    try
                    {
                        SaveCrew();
                        ClearCrew();
                        LoadDataCrew();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                }
            }
            btnSave.Text = "Сохранить";
            btnDelete.Enabled = false;
            LoadDataPersonComboBox();
            LoadDataCarComboBox();
        }

        private void SavePerson()
        {

            person.Name = txtDriverName.Text.Trim();

            if (txtDriverAge.Text.Trim().Equals(""))
            {
                person.Age = null;
            }
            else
            {
                person.Age = int.Parse(txtDriverAge.Text.Trim());
            }
            
            if (txtDriverExpAge.Text.Trim().Equals(""))
            {
                person.ExperienceAge = null;
            }
            else 
            {
                person.ExperienceAge = int.Parse(txtDriverExpAge.Text.Trim());
            }
            
            try
            {
                using (var cont = new Data.MyDbContext())
                {
                    if (person.Id == 0)
                    {
                        bool similar = false;
                        foreach (Person item in cont.Persons.ToList<Person>())
                        {
                            if (item.Name.Equals(person.Name))
                            {
                                similar = true;
                            }
                        }
                        if (similar)
                        {
                            MessageBox.Show("Водитель с таким ФИО есть в базе. Уточните ФИО");
                        }
                        else
                        {
                            cont.Persons.Add(person);
                            cont.SaveChanges();
                            MessageBox.Show("Данные в базу водителей успешно добавлены");
                        }
                    }
                    else
                    {
                        cont.Entry(person).State = EntityState.Modified;
                        cont.SaveChanges();
                        MessageBox.Show("Данные в базе водителей успешно обновлены");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            person = new Person();
        }

        private void SaveCar()
        {

            car.IdNumber = txtCarIdNumber.Text.Trim().ToUpper();

            car.Model = txtCarModel.Text.Trim();

            if (txtCarMileage.Text.Trim().Equals(""))
            {
                car.Mileage = null;
            }
            else
            {
                car.Mileage = int.Parse(txtCarMileage.Text.Trim());
            }

            try
            {
                using (var cont = new Data.MyDbContext())
                {
                    if (car.Id == 0)
                    {
                        bool similar = false;
                        foreach (Car item in cont.Cars.ToList<Car>())
                        {
                            if (item.IdNumber.Equals(car.IdNumber))
                            {
                                similar = true;
                            }
                        }
                        if (similar)
                        {
                            MessageBox.Show("Автомобиль с таким госномером есть в базе. Уточните госномер");
                        }
                        else
                        {
                            cont.Cars.Add(car);
                            cont.SaveChanges();
                            MessageBox.Show("Данные в базу автомобилей успешно добавлены");
                        }

                    }
                    else 
                    {
                        cont.Entry(car).State = EntityState.Modified;
                        cont.SaveChanges();
                        MessageBox.Show("Данные в базе автомобилей успешно обновлены");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            car = new Car();
        }

        private void SaveCrew ()
        {

            crew.NamePerson = txtCrewDriver.Text.Trim();
            crew.IdNumberCar = txtCrewCar.Text.Trim();
            crew.Transfer = txtCrewTransef.Text.Trim();

            try
            {
                using (var cont = new Data.MyDbContext())
                {
                    if (crew.Id == 0)
                    {
                        cont.Crews.Add(crew);
                        cont.SaveChanges();
                        MessageBox.Show("Данные в базу экипажей успешно добавлены");
                    }
                    else
                    {
                        cont.Entry(crew).State = EntityState.Modified;
                        cont.SaveChanges();
                        MessageBox.Show("Данные в базе экипажей успешно обновлены");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            crew = new Crew();
        }

        private void dataDriverCarCrew_DoubleClick(object sender, EventArgs e)
        {
            if (dataDriverCarCrew.CurrentRow.Index != -1)
            {
                if (dataDriverCarCrew.Columns[1].HeaderText == "ФИО" && dataDriverCarCrew.Columns[3].HeaderText != "Маршрут")
                {

                    person.Id = Convert.ToInt32(dataDriverCarCrew.CurrentRow.Cells["tblPersonId"].Value);

                    try
                    {
                        using (var cont = new Data.MyDbContext())
                        {
                            person = cont.Persons.Where(x => x.Id == person.Id).FirstOrDefault();
                            txtDriverName.Text = person.Name;
                            txtDriverAge.Text = person.Age.ToString();
                            txtDriverExpAge.Text = person.ExperienceAge.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (dataDriverCarCrew.Columns[1].HeaderText == "Госномер")
                {

                    car.Id = Convert.ToInt32(dataDriverCarCrew.CurrentRow.Cells["tblCarId"].Value);

                    try
                    {
                        using (var cont = new Data.MyDbContext())
                        {
                            car = cont.Cars.Where(x => x.Id == car.Id).FirstOrDefault();
                            txtCarIdNumber.Text = car.IdNumber;
                            txtCarModel.Text = car.Model;
                            txtCarMileage.Text = car.Mileage.ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                if (dataDriverCarCrew.Columns[3].HeaderText == "Маршрут")
                { 
                    crew.Id = Convert.ToInt32(dataDriverCarCrew.CurrentRow.Cells["tblCrewId"].Value);

                    try
                    {
                        using (var cont = new Data.MyDbContext())
                        {
                            crew = cont.Crews.Where(x => x.Id == crew.Id).FirstOrDefault();
                            txtCrewDriver.Text = crew.NamePerson;
                            txtCrewCar.Text = crew.IdNumberCar;
                            txtCrewTransef.Text = crew.Transfer;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }    

                btnSave.Text = "Обновить";
                btnDelete.Enabled = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы точно хотите удалить данные?", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!txtDriverName.Text.Equals(""))
                {
                    try
                    {
                        using (var cont = new Data.MyDbContext())
                        {
                            bool similar = false;
                            foreach (Crew item in cont.Crews.ToList<Crew>())
                            {
                                if (item.NamePerson.Equals(person.Name))
                                {
                                    similar = true;
                                }
                            }
                            if (similar)
                            {
                                MessageBox.Show("Водитель состоит в экипаже. Сначала обновите или удалите экипаж");
                            }
                            else
                            {
                                var entry = cont.Entry(person);
                                if (entry.State == EntityState.Detached)
                                {
                                    cont.Persons.Attach(person);
                                    cont.Persons.Remove(person);
                                    cont.SaveChanges();
                                    LoadDataPerson();
                                    ClearPerson();
                                    MessageBox.Show("Данные из базы водителей успешно удалены");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    person = new Person();
                    ClearPerson();
                }

                if (!txtCarIdNumber.Text.Equals(""))
                {
                    try
                    {
                        using (var cont = new Data.MyDbContext())
                        {
                            bool similar = false;
                            foreach (Crew item in cont.Crews.ToList<Crew>())
                            {
                                if (item.IdNumberCar.Equals(car.IdNumber))
                                {
                                    similar = true;
                                }
                            }
                            if (similar)
                            {
                                MessageBox.Show("Автомобиль состоит в экипаже. Сначала обновите или удалите экипаж");
                            }
                            else
                            {
                                var entry = cont.Entry(car);
                                if (entry.State == EntityState.Detached)
                                {
                                    cont.Cars.Attach(car);
                                    cont.Cars.Remove(car);
                                    cont.SaveChanges();
                                    LoadDataCar();
                                    ClearCar();
                                    MessageBox.Show("Данные из базы автомобилей успешно удалены");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    car = new Car();
                }

                if (!txtCrewDriver.Text.Equals("") && !txtCrewCar.Text.Equals(""))
                {
                    try
                    {
                        using (var cont = new Data.MyDbContext())
                        {
                            var entry = cont.Entry(crew);
                            if (entry.State == EntityState.Detached)
                            {
                                cont.Crews.Attach(crew);
                                cont.Crews.Remove(crew);
                                cont.SaveChanges();
                                LoadDataCrew();
                                ClearCrew();
                                MessageBox.Show("Данные из базы экипажей успешно удалены");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    crew = new Crew();
                }
            }

            btnSave.Text = "Сохранить";
            btnDelete.Enabled = false;
            LoadDataPersonComboBox();
            LoadDataCarComboBox();
        }

        private void txtDriverName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number)) return;

            e.Handled = true;

        }

        private void txtDriverAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number)) return;
            if (Char.IsControl(number)) return;

            e.Handled = true;

        }

        private void txtDriverExpAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number)) return;
            if (Char.IsControl(number)) return;

            e.Handled = true;
        }

        private void txtCarMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (Char.IsDigit(number)) return;
            if (Char.IsControl(number)) return;

            e.Handled = true;
        }

        private void LoadDataPerson()
        {
            try
            {
                using (var cont = new Data.MyDbContext())
                {
                                      
                    dataDriverCarCrew.DataSource = cont.Persons.ToList<Person>();
                    dataDriverCarCrew.Columns[1].HeaderText = "ФИО";
                    dataDriverCarCrew.Columns[2].HeaderText = "Возраст";
                    dataDriverCarCrew.Columns[3].HeaderText = "Стаж";
                    dataDriverCarCrew.Refresh();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void LoadDataPersonComboBox()
        {
            try
            {
                using (var cont = new Data.MyDbContext())
                {
                    txtCrewDriver.Items.Clear();
                    foreach (Person item in cont.Persons.ToList<Person>())
                    {
                        txtCrewDriver.Items.Add(item.Name);
                    }                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void LoadDataCar()
        {
            try
            {
                using (var cont = new Data.MyDbContext())
                {
                    dataDriverCarCrew.DataSource = cont.Cars.ToList<Car>();
                    dataDriverCarCrew.Columns[1].HeaderText = "Госномер";
                    dataDriverCarCrew.Columns[2].HeaderText = "Модель";
                    dataDriverCarCrew.Columns[3].HeaderText = "Пробег";
                    dataDriverCarCrew.Refresh();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void LoadDataCarComboBox()
        {
            try
            {
                using (var cont = new Data.MyDbContext())
                {
                    txtCrewCar.Items.Clear();
                    foreach (Car item in cont.Cars.ToList<Car>())
                    {
                        txtCrewCar.Items.Add(item.IdNumber);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void LoadDataCrew()
        {
            try
            {
                using (var cont = new Data.MyDbContext())
                {
                    dataDriverCarCrew.DataSource = cont.Crews.ToList<Crew>();
                    dataDriverCarCrew.Columns[1].HeaderText = "ФИО";
                    dataDriverCarCrew.Columns[2].HeaderText = "Госномер";
                    dataDriverCarCrew.Columns[3].HeaderText = "Маршрут";
                    dataDriverCarCrew.Refresh();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void labelPerson_Click(object sender, EventArgs e)
        {
            LoadDataPerson();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoadDataPerson();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoadDataCar();
        }

        private void labelCar_Click(object sender, EventArgs e)
        {
            LoadDataCar();
        }

        private void labelCrew_Click(object sender, EventArgs e)
        {
            LoadDataCrew();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadDataCrew();
        }
    }
}
