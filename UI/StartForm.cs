using AppWinFormCRUD.Data.Tables;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace AppWinFormCRUD.UI
{
    public partial class StartForm : Form
    {

        private Person person = new Person();
        private Car car = new Car();
        private Crew crew = new Crew();

        private readonly string headerPersonFullName = "ФИО";
        private readonly string headerPersonAge = "Возраст";
        private readonly string headerPersonExpAge = "Стаж";
        private readonly string headerCarIdNumber = "Госномер";
        private readonly string headerCarModel = "Модель";
        private readonly string headerCarMileage = "Пробег";
        private readonly string headerCrewTransfer = "Маршрут";

        private string rememberCrewNamePerson = "";
        private string rememberCrewIdNumberCar = "";
        private long rememberCrewId = -1;

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

        private void StartForm_Load(object sender, EventArgs e)
        {
            ClearPerson();
            ClearCar();
            ClearCrew();

            this.ActiveControl = txtPersonName;

            LoadDataCrew();
            LoadDataCar();
            LoadDataPerson();
            
            LoadDataPersonComboBox();
            LoadDataCarComboBox();

            btnDelete.Enabled = false;
        }

        private void dataPersonCarCrew_DoubleClick(object sender, EventArgs e)
        {
            if (dataPersonCarCrew.CurrentRow.Index != -1)
            {
                if (dataPersonCarCrew.Columns[1].HeaderText == headerPersonFullName
                    && dataPersonCarCrew.Columns[3].HeaderText != headerCrewTransfer)
                {
                    person.Id = Convert.ToInt32(dataPersonCarCrew.CurrentRow.Cells["tblPersonId"].Value);

                    using (var cont = new Data.MyDbContext())
                    {
                        person = cont.Persons.Where(x => x.Id == person.Id).FirstOrDefault();
                        txtPersonName.Text = person.Name;
                        txtPersonAge.Text = person.Age.ToString();
                        txtPersonExpAge.Text = person.ExperienceAge.ToString();

                        rememberCrewNamePerson = txtPersonName.Text;
                    }

                    ClearCar();
                    ClearCrew();
                }

                if (dataPersonCarCrew.Columns[1].HeaderText == headerCarIdNumber)
                {
                    car.Id = Convert.ToInt32(dataPersonCarCrew.CurrentRow.Cells["tblCarId"].Value);

                    using (var cont = new Data.MyDbContext())
                    {
                        car = cont.Cars.Where(x => x.Id == car.Id).FirstOrDefault();
                        txtCarIdNumber.Text = car.IdNumber;
                        txtCarModel.Text = car.Model;
                        txtCarMileage.Text = car.Mileage.ToString();

                        rememberCrewIdNumberCar = txtCarIdNumber.Text;
                    }

                    ClearPerson();
                    ClearCrew();
                }

                if (dataPersonCarCrew.Columns[3].HeaderText == headerCrewTransfer)
                {
                    crew.Id = Convert.ToInt32(dataPersonCarCrew.CurrentRow.Cells["tblCrewId"].Value);
                    using (var cont = new Data.MyDbContext())
                    {
                        crew = cont.Crews.Where(x => x.Id == crew.Id).FirstOrDefault();
                        txtCrewPerson.Text = crew.NamePerson;
                        txtCrewCar.Text = crew.IdNumberCar;
                        txtCrewTransef.Text = crew.Transfer;
                    }

                    ClearPerson();
                    ClearCar();
                }

                btnSave.Text = "Обновить";
                btnDelete.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPersonName.Text.Trim().Equals("")
                && (!txtPersonAge.Text.Trim().Equals("") || !txtPersonExpAge.Text.Trim().Equals("")))
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
            
            else if ((txtCrewCar.Text.Trim().Equals("") || txtCrewPerson.Text.Trim().Equals("")) 
                && !txtCrewTransef.Text.Trim().Equals(""))
            {
                MessageBox.Show("Выбирете госномер автомобиля и водителя");
                return;
            }

            else
            {
                if (!txtPersonName.Text.Trim().Equals(""))
                {
                    SavePerson();
                    ClearPerson();
                    LoadDataPerson();
                }
                if (!txtCarIdNumber.Text.Trim().Equals(""))
                {
                    SaveCar();
                    ClearCar();
                    LoadDataCar();
                }
                if (!txtCrewCar.Text.Trim().Equals(""))
                {
                    SaveCrew();
                    ClearCrew();
                    LoadDataCrew();
                }
            }

            btnSave.Text = "Сохранить";
            btnDelete.Enabled = false;
            LoadDataPersonComboBox();
            LoadDataCarComboBox();
        }

        private void SavePerson()
        {
            person.Name = txtPersonName.Text.Trim();

            if (txtPersonAge.Text.Trim().Equals("")) person.Age = null;
            else person.Age = int.Parse(txtPersonAge.Text.Trim());
            
            if (txtPersonExpAge.Text.Trim().Equals("")) person.ExperienceAge = null;
            else person.ExperienceAge = int.Parse(txtPersonExpAge.Text.Trim());

            bool similar1 = false;

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
                            break;
                        } 
                    }

                    if (similar) MessageBox.Show("Водитель с таким ФИО есть в базе. Уточните ФИО");
                    else
                    {
                       cont.Persons.Add(person);
                       cont.SaveChanges();
                       MessageBox.Show("Данные в базу водителей успешно добавлены");
                    }
                }
                else
                {
                    foreach (Crew item in cont.Crews.ToList<Crew>())
                    {
                        if (item.NamePerson.Equals(rememberCrewNamePerson))
                        {
                            similar1 = true;
                            rememberCrewId = item.Id;
                            rememberCrewIdNumberCar = item.IdNumberCar;
                            rememberCrewNamePerson = person.Name;
                            break;
                        }
                    }
                    cont.Entry(person).State = EntityState.Modified;
                    cont.SaveChanges();
                    MessageBox.Show("Данные в базе водителей успешно обновлены");
                }
            }

            if (similar1) UpdateCrew(rememberCrewNamePerson, rememberCrewIdNumberCar, rememberCrewId);

            person = new Person();
        }

        private void SaveCar()
        {
            car.IdNumber = txtCarIdNumber.Text.Trim().ToUpper();
            car.Model = txtCarModel.Text.Trim();

            if (txtCarMileage.Text.Trim().Equals("")) car.Mileage = null;
            else car.Mileage = int.Parse(txtCarMileage.Text.Trim());

            bool similar1 = false;

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
                            break;
                        } 
                    }
                    if (similar) MessageBox.Show("Автомобиль с таким госномером есть в базе. Уточните госномер");
                    else
                    {
                        cont.Cars.Add(car);
                        cont.SaveChanges();
                        MessageBox.Show("Данные в базу автомобилей успешно добавлены");
                    }
                }

                else 
                {
                    foreach (Crew item in cont.Crews.ToList<Crew>())
                    {
                        if (item.IdNumberCar.Equals(rememberCrewIdNumberCar))
                        {
                            similar1 = true;
                            rememberCrewId = item.Id;
                            rememberCrewIdNumberCar = car.IdNumber;
                            rememberCrewNamePerson = item.NamePerson;
                            break;
                        } 
                    }
                    cont.Entry(car).State = EntityState.Modified;
                    cont.SaveChanges();
                    MessageBox.Show("Данные в базе автомобилей успешно обновлены");
                }
            }

            if (similar1) UpdateCrew(rememberCrewNamePerson, rememberCrewIdNumberCar, rememberCrewId);

            car = new Car();
        }

        private void SaveCrew ()
        {
            crew.NamePerson = txtCrewPerson.Text.Trim();
            crew.IdNumberCar = txtCrewCar.Text.Trim();
            crew.Transfer = txtCrewTransef.Text.Trim();

            using (var cont = new Data.MyDbContext())
            {
                if (crew.Id == 0)
                {
                    bool similarPerson = false;
                    bool similarIdNumberCar = false;
                    foreach (Crew item in cont.Crews.ToList<Crew>())
                    {
                        if (item.NamePerson.Equals(crew.NamePerson)) similarPerson = true;
                        if (item.IdNumberCar.Equals(crew.IdNumberCar)) similarIdNumberCar = true;
                    }
                    if (similarPerson && !similarIdNumberCar) MessageBox.Show("Выбранный водитель занят. Выберете другого или обновите экипаж");
                    else if (!similarPerson && similarIdNumberCar) MessageBox.Show("Выбранный автомобиль занят. Выберете другой или обновите экипаж");
                    else if (similarPerson && similarIdNumberCar) MessageBox.Show("Выбранный экипаж занят. Выберете другой экипаж или обновите существующий");
                    else
                    {
                        cont.Crews.Add(crew);
                        cont.SaveChanges();
                        MessageBox.Show("Данные в базу экипажей успешно добавлены");
                    }  
                }
                else
                {
                    cont.Entry(crew).State = EntityState.Modified;
                    cont.SaveChanges();
                    MessageBox.Show("Данные в базе экипажей успешно обновлены");
                }
            }

            crew = new Crew();
        }

        private void UpdateCrew(string namePerson, string idNumberCar, long id) 
        {
            using (var cont = new Data.MyDbContext())
            {
                crew = cont.Crews.Find(id);
                crew.NamePerson = namePerson;
                crew.IdNumberCar = idNumberCar;
                cont.Entry(crew).State = EntityState.Modified;
                cont.SaveChanges();
            }
            crew = new Crew();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить данные?", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!txtPersonName.Text.Equals(""))
                {
                    using (var cont = new Data.MyDbContext())
                    {
                        bool similar = false;
                        foreach (Crew item in cont.Crews.ToList<Crew>())
                        {
                            if (item.NamePerson.Equals(person.Name))
                            {
                                similar = true;
                                break;
                            } 
                        }
                        if (similar) MessageBox.Show("Водитель состоит в экипаже. Сначала обновите или удалите экипаж");
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
                    person = new Person();
                    ClearPerson();
                }

                else if (txtPersonName.Text.Equals("") &&
                    (!txtPersonAge.Text.Trim().Equals("") || !txtPersonExpAge.Text.Trim().Equals("")))
                {
                    MessageBox.Show("Удаление водителя не удалось. ФИО должно быть заполнено");
                    ClearPerson();
                }

                if (!txtCarIdNumber.Text.Equals(""))
                {
                    using (var cont = new Data.MyDbContext())
                    {
                        bool similar = false;
                        foreach (Crew item in cont.Crews.ToList<Crew>())
                        {
                            if (item.IdNumberCar.Equals(car.IdNumber))
                            {
                                similar = true;
                                break;
                            } 
                        }
                        if (similar) MessageBox.Show("Автомобиль состоит в экипаже. Сначала обновите или удалите экипаж");

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

                    car = new Car();
                }

                else if (txtCarIdNumber.Text.Equals("") &&
                    (!txtCarModel.Text.Trim().Equals("") || !txtCarMileage.Text.Trim().Equals("")))
                {
                    MessageBox.Show("Удаление автомобиля не удалось. Госномер должены быть заполнен");
                    ClearCar();
                }

                if (!txtCrewPerson.Text.Equals("") && !txtCrewCar.Text.Equals(""))
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
                    crew = new Crew();
                }

                else if ((txtCrewPerson.Text.Equals("") || txtCrewCar.Text.Equals("")) 
                    && !txtCrewTransef.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Удаление экипажа не удалось. ФИО водителя и госномер должны быть заполнены");
                    ClearCrew();
                }

                btnSave.Text = "Сохранить";
                btnDelete.Enabled = false;
                LoadDataPersonComboBox();
                LoadDataCarComboBox();
            }
        }

        private void txtPersonName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) return;
            e.Handled = true;
        }

        private void txtPersonAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (Char.IsDigit(number)) return;
            if (Char.IsControl(number)) return;
            e.Handled = true;
        }

        private void txtPersonExpAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPersonAge_KeyPress(sender, e);
        }

        private void txtCarMileage_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPersonAge_KeyPress(sender, e);
        }

        private void LoadDataPerson()
        {
            using (var cont = new Data.MyDbContext())
            {
                                      
                dataPersonCarCrew.DataSource = cont.Persons.ToList<Person>();
                dataPersonCarCrew.Columns[1].HeaderText = headerPersonFullName;
                dataPersonCarCrew.Columns[2].HeaderText = headerPersonAge;
                dataPersonCarCrew.Columns[3].HeaderText = headerPersonExpAge;
                dataPersonCarCrew.Refresh();
            }
        }

        private void LoadDataPersonComboBox()
        {
            using (var cont = new Data.MyDbContext())
            {
                txtCrewPerson.Items.Clear();
                foreach (Person item in cont.Persons.ToList<Person>())
                {
                    txtCrewPerson.Items.Add(item.Name);
                }                   
            }
        }

        private void LoadDataCar()
        {
            using (var cont = new Data.MyDbContext())
            {
                dataPersonCarCrew.DataSource = cont.Cars.ToList<Car>();
                dataPersonCarCrew.Columns[1].HeaderText = headerCarIdNumber;
                dataPersonCarCrew.Columns[2].HeaderText = headerCarModel;
                dataPersonCarCrew.Columns[3].HeaderText = headerCarMileage;
                dataPersonCarCrew.Refresh();
            }
        }

        private void LoadDataCarComboBox()
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

        private void LoadDataCrew()
        {
            using (var cont = new Data.MyDbContext())
            {
                dataPersonCarCrew.DataSource = cont.Crews.ToList<Crew>();
                dataPersonCarCrew.Columns[1].HeaderText = headerPersonFullName;
                dataPersonCarCrew.Columns[2].HeaderText = headerCarIdNumber;
                dataPersonCarCrew.Columns[3].HeaderText = headerCrewTransfer;
                dataPersonCarCrew.Refresh();
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

        private void ClearPerson()
        {
            txtPersonName.Text = "";
            txtPersonAge.Text = "";
            txtPersonExpAge.Text = "";
        }

        private void ClearCar()
        {
            txtCarIdNumber.Text = "";
            txtCarModel.Text = "";
            txtCarMileage.Text = "";
        }

        private void ClearCrew()
        {
            txtCrewPerson.SelectedIndex = -1;
            txtCrewCar.SelectedIndex = -1;
            txtCrewTransef.Text = "";
        }
    }
}
