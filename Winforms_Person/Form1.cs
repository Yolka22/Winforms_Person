using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Person
{
    public partial class Form1 : Form
    {
        List<Person> Persons = new List<Person>();

        public void Write()
        {

            try
            {
                using (StreamWriter sw = new StreamWriter("Workers.txt"))
                {
                    sw.WriteLine(Persons.Count);

                    foreach (var item in Persons)
                    {
                        sw.WriteLine(item.Surname);
                        sw.WriteLine(item.Salary);
                        sw.WriteLine(item.Place);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }


        public void Read()
        {

            

            try
            {
                using (StreamReader sr = new StreamReader("Workers.txt"))
                {

                    int Size = Convert.ToInt32(sr.ReadLine());

                    for (int i = 0; i < Size; i++)
                    {
                        Person person = new Person();

                        person.Surname = sr.ReadLine();
                        person.Salary = sr.ReadLine();
                        person.Place = sr.ReadLine();

                        Persons.Add(person);


                    }

                    for (int i = 0; i < Persons.Count; i++)
                    {
                        WorkersListBoks.Items.Add(Persons[i].Surname);
                        WorkersListBoks.Items.Add(Persons[i].Salary);
                        WorkersListBoks.Items.Add(Persons[i].Place);
                        WorkersListBoks.Items.Add("");
                    }
                    
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

        }

        public Form1()
        {

            

            InitializeComponent();
            Read();
        }

        private void fillbutton_Click(object sender, EventArgs e)
        {
            Person personObject = new Person();


            if (txtSurName.Text!="")
            {
                personObject.Surname = txtSurName.Text;
                
            }
            else
            {
                MessageBox.Show("Введите фамилию");
            }

            if (txtSalary.Text != "")
            {
                personObject.Salary = txtSalary.Text;
            }
            else
            {
                MessageBox.Show("Введите зарплату");
            }

            if (txtPlace.Text != "")
            {
                personObject.Place = txtPlace.Text;
            }
            else
            {
                MessageBox.Show("Введите должность");
            }

            if (personObject.Surname!=null&&personObject.Salary!= null && personObject.Place!=null)
            {
                txtSurName.Clear();
                txtSalary.Clear();
                txtPlace.Clear();

                WorkersListBoks.Items.Add(personObject.Surname);
                WorkersListBoks.Items.Add(personObject.Salary);
                WorkersListBoks.Items.Add(personObject.Place);
                WorkersListBoks.Items.Add("");

                Persons.Add(personObject);

                Write();
            }
            

           
        }
    }
}
