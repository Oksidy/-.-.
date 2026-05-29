using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    // Класс главной формы Form1, наследующий базовый функционал окна (Form)
    public partial class Form1 : Form
    {
        // Конструктор формы, вызываемый при ее создании в памяти
        public Form1()
        {
            // Системный метод инициализации визуальных компонентов
            InitializeComponent();
        }

        // Пустые обработчики событий изменения состояния радиокнопок.
        // Проверка их состояния выполняется по факту нажатия кнопки, поэтому логика здесь не требуется.
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton5_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton6_CheckedChanged(object sender, EventArgs e) { }

        // Обработчик события нажатия на кнопку подтверждения выбора
        private void button1_Click(object sender, EventArgs e)
        {
            // Объявление переменной для хранения ссылки на целевую форму
            Form targetForm = null;

            // Каскадная проверка выбранной радиокнопки для создания экземпляра соответствующей формы
            if (radioButton1.Checked) targetForm = new Form2();
            else if (radioButton2.Checked) targetForm = new Form3();
            else if (radioButton3.Checked) targetForm = new Form4();
            else if (radioButton4.Checked) targetForm = new Form5();
            else if (radioButton5.Checked) targetForm = new Form6();
            else if (radioButton6.Checked) targetForm = new Form7();
            else
            {
                // Вывод диалогового окна с ошибкой, если пользователь не выбрал ни один пункт
                MessageBox.Show("Пожалуйста, выберите задачу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Прерывание работы метода
                return;
            }

            // Отображение целевой формы (выбранной задачи)
            targetForm.Show();
            // Скрытие текущей формы главного меню
            this.Hide();
        }

        // Пустой обработчик события первоначальной загрузки формы
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}